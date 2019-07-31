using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mhrs.BLL;
using Mhrs.DTO;
using Mhrs.Entities;

namespace Mhrs.UI.WinForm
{
    public partial class MuayeneFrm : Form
    {
        TeshisController teshisController;
        TahlilController tahlilController;
        RandevuController randevuController;
        IlacController ilacController;
        ReceteController receteController;
        ReceteEntities recete;
        MuayeneEntities muayene;

        MuayeneController muayeneController;
        DoktorCalismaTakvimiController dctController;
        RandevuHastaDTO randevudakiHasta;

        public MuayeneFrm(RandevuHastaDTO randevudakiHasta)
        {
            InitializeComponent();
            teshisController = new TeshisController();
            tahlilController = new TahlilController();
            randevuController = new RandevuController();
            muayeneController = new MuayeneController();
            receteController = new ReceteController();
            dctController = new DoktorCalismaTakvimiController();
            recete = new ReceteEntities();
            ilacController = new IlacController();
            muayene = new MuayeneEntities();
            this.randevudakiHasta = randevudakiHasta;
            lblHasta.Text = randevudakiHasta.HastaFullAd;

            gBoxTeshis.Hide();
            gBoxTahlil.Hide();
        }

        public MuayeneFrm(MuayeneEntities muane, HastaEntities hasta)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            teshisController = new TeshisController();
            tahlilController = new TahlilController();
            randevuController = new RandevuController();
            muayeneController = new MuayeneController();
            receteController = new ReceteController();
            recete = new ReceteEntities();
            ilacController = new IlacController();
            muayene = new MuayeneEntities();

            lblHasta.Text = hasta.Adi + " " + hasta.Soyadi;

            foreach (Control item in this.Controls)
            {
                item.Enabled = false;
            }

            txtNot.Text = muane.Not;
            if (muane.TeshisID == 0)
            {
                rButtonTahlil.Checked = true;
                gBoxTahlil.Show();
                cmbTahlil.SelectedIndex = muane.TahlilID;
            }
            else if (muane.TahlilID == 0)
            {
                rButtonTeshis.Checked = true;
                gBoxTeshis.Show();
                cmbTeshis.SelectedIndex = muane.TeshisID;
                cmbIlac.DataSource = null;
            }
            else
                MessageBox.Show("Sıkıntı var");

        }

        private void MuayeneFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void rButtonTahlil_CheckedChanged(object sender, EventArgs e)
        {
            radio_checked();
        }

        private void rButtonTeshis_CheckedChanged(object sender, EventArgs e)
        {
            radio_checked();
        }

        void radio_checked()
        {
            if (rButtonTeshis.Checked)
            {
                gBoxTeshis.Show();
                cmbTeshis.DataSource = teshisController.GetTeshisAdlari();
                cmbIlac.DataSource = ilacController.GetIlacAdlari();
                gBoxTahlil.Hide();
            }
            else if (rButtonTahlil.Checked)
            {
                gBoxTahlil.Show();
                cmbTahlil.DataSource = tahlilController.GetTahlilAdlari();
                gBoxTeshis.Hide();
            }
        }
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (cmbTahlil.SelectedIndex != -1 && cmbTahlil.SelectedIndex != 0)
            {
                muayene.TeshisID = 0;
                muayene.Not = txtNot.Text;
                muayene.TahlilID = cmbTahlil.SelectedIndex;
                muayene.RandevuID = randevudakiHasta.RandevuID;

                // Önce eski randevu bilgilerini al, 
                // sonra eski randevunun durumunu değiştirip yeni randevuyu kaydet
                // dct yeni randevu tarihi için guncelle, durumu değiştir

                RandevuEntities randevu = new RandevuEntities();
                randevu = randevuController.GetRandevu(randevudakiHasta.RandevuID);

                List<DCTEntities> dct = new List<DCTEntities>();
                dct = dctController.CalismaTakvimiGetir(randevu, dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                if (dct.Count != 0)
                {
                    DateTime tarih = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, int.Parse(dct[0].Saat.Substring(0, 2)), int.Parse(dct[0].Saat.Substring(3, 2)), 0);

                    DialogResult randevuVerilsinMi = new DialogResult();
                    randevuVerilsinMi = MessageBox.Show(tarih.ToLongDateString() + "\nSaat -> " + dct[0].Saat + "\nRandevu verilsin mi ?", "Yeni Randevu Bilgisi", MessageBoxButtons.YesNo);
                    if (randevuVerilsinMi == DialogResult.Yes)
                    {
                        randevu.RandevuTarihi = tarih;
                        // eski randevunun durumu guncelleniyor (Durum = 0 oluyor)
                        randevuController.RandevuGuncelle(randevu.RandevuID);

                        bool sonuc = randevuController.RandevuEkle(randevu);
                        MessageBox.Show(sonuc ? "Randevu Verildi" : "Randevu Başarısız");

                        sonuc = muayeneController.Add(muayene);
                        MessageBox.Show(sonuc ? "Muayene Alındı" : "Muayane Başarısız");

                        dctController.DoktorCalismaTakvimiGuncelle(dct[0]);
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Seçilen günde boş seans yok");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Tahlil Seçiniz");
            }
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            if (cmbTeshis.SelectedIndex != -1 && cmbTeshis.SelectedIndex != 0)
            {
                if (cmbIlac.SelectedIndex != -1)
                {
                    recete.IlacID = cmbIlac.SelectedIndex + 1;
                    recete.RandevuID = randevudakiHasta.RandevuID;
                    bool sonuc = receteController.Add(recete);
                    MessageBox.Show(sonuc ? "Reçete Yazıldı" : "Reçete Başarısız");
                }
                else
                {
                    MessageBox.Show("Lütfen İlaç Seçiniz");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Teşhis Seçiniz");
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (cmbTeshis.SelectedIndex != -1 && cmbTeshis.SelectedIndex != 0)
            {
                muayene.TahlilID = 0;
                muayene.Not = txtNot.Text;
                muayene.TeshisID = cmbTeshis.SelectedIndex;
                muayene.RandevuID = randevudakiHasta.RandevuID;
                bool sonuc = muayeneController.Add(muayene);
                MessageBox.Show(sonuc ? "Muayene Alındı" : "Muayane Başarısız");
                randevuController.RandevuGuncelle(randevudakiHasta.RandevuID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Teşhis Seçiniz");
            }
        }
    }
}
