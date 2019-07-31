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
    public partial class DoktorFrm : Form
    {
        DoktorController doktorController;
        DoktorEntities doktor;
        HastaEntities hasta;
        RandevuEntities randevu;
        DepartmanEntities departman;
        RandevuController randevuController;
        MuayeneController muayeneController;
        HastaController hastaController;
        DepartmanController departmanController;
        List<RandevuHastaDTO> randevus;
        List<HastaMuaneleriDTO> muaneler;

        public DoktorFrm(int doktorID)
        {
            InitializeComponent();
            doktorController = new DoktorController();
            randevuController = new RandevuController();
            hastaController = new HastaController();
            muayeneController = new MuayeneController();
            departmanController = new DepartmanController();
            departman = new DepartmanEntities();
            doktor = new DoktorEntities();
            randevu = new RandevuEntities();
            hasta = new HastaEntities();
            randevus = new List<RandevuHastaDTO>();
            muaneler = new List<HastaMuaneleriDTO>();
            doktor = doktorController.GetDoktor(doktorID);
            departman = departmanController.IDyeGoreDepartmanGetir(doktor.DepartmanID);
            labelDoktor.Text = departman.DepartmanAdi + " Uzmanı Dr. " + doktor.Adi + " " + doktor.Soyadi;

            gBoxMuaneSorgula.Hide();
            gBoxHesapBilgileri.Hide();
            gBoxCalismaGunu.Hide();
        }

        private void DoktorFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lstvRandevular.Items.Clear();
            randevus = randevuController.GetAllRandevu(doktor.DoktorID, datePic.Value.ToString("yyyy-MM-dd"));
            int i = 1;
            foreach (RandevuHastaDTO item in randevus)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                lvi.SubItems.Add(item.HastaFullAd);
                lvi.SubItems.Add(item.Seans.Substring(0, 5));
                lstvRandevular.Items.Add(lvi);
                if (item.Durum)
                {
                    lvi.BackColor = Color.Green;
                }
                else
                {
                    lvi.BackColor = Color.Red;
                }
                i++;
            }
        }

        private void lstvRandevular_DoubleClick(object sender, EventArgs e)
        {
            if (lstvRandevular.FocusedItem.BackColor != Color.Red)
            {
                RandevuHastaDTO randevudakiHasta = randevus[(int.Parse(lstvRandevular.FocusedItem.Text)) - 1];
                DialogResult hastaGeldiMi = new DialogResult();
                hastaGeldiMi = MessageBox.Show("Hasta geldi mi ?", "Kapıya Bak", MessageBoxButtons.YesNo);
                if (hastaGeldiMi == DialogResult.Yes)
                {
                    this.Hide();
                    MuayeneFrm muayeneFrm = new MuayeneFrm(randevudakiHasta);
                    muayeneFrm.Show();
                    muayeneFrm.Owner = this;
                }
                else
                {
                    randevuController.RandevuGuncelle(randevudakiHasta.RandevuID);
                }

                lstvRandevular.FocusedItem.BackColor = Color.Red;
            }
        }

        private void çalışmaGünüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxMuaneSorgula.Hide();
            gBoxHesapBilgileri.Hide();
            gBoxCalismaGunu.Show();
        }

        private void muayeneSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gBoxCalismaGunu.Hide();
            gBoxMuaneSorgula.Show();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHastaID.Text))
            {
                hasta = hastaController.GetHasta(int.Parse(txtHastaID.Text));
                lblID.Text = "ID : " + hasta.HastaID;
                lblAd.Text = "Ad : " + hasta.Adi;
                lblSoyad.Text = "Soyad : " + hasta.Soyadi;
                lblCinsiyet.Text = "Cinsiyet : " + (hasta.Cinsiyet ? "Kadın" : "Erkek");
                lblMail.Text = "Mail : " + hasta.KullaniciAdi;
                gBoxHesapBilgileri.Show();

                muaneler = muayeneController.getHastaMuayeneleri(hasta.HastaID, doktor.DoktorID);

                foreach (HastaMuaneleriDTO item in muaneler)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.muaneID.ToString();
                    lvi.SubItems.Add(item.randevuID.ToString());
                    lvi.SubItems.Add(item.tarih.ToShortDateString());
                    lvi.SubItems.Add(item.tarih.ToShortTimeString());
                    lsvMuaneler.Items.Add(lvi);
                }
            }
        }

        private void lsvMuaneler_DoubleClick(object sender, EventArgs e)
        {
            MuayeneEntities muayene = muayeneController.getMuayeneByID(int.Parse(lsvMuaneler.SelectedItems[0].Text));
            this.Hide();
            MuayeneFrm muayeneFrm = new MuayeneFrm(muayene, hasta);
            muayeneFrm.Show();
            muayeneFrm.Owner = this;
        }
    }
}
