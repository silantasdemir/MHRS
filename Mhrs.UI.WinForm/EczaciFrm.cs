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
    public partial class EczaciFrm : Form
    {
        EczaciController eczaciController;
        EczaciEntities eczaci;
        ReceteController _receteController;
        List<ReceteIlaclariDTO> receteIlaclari;
        List<HastayaGoreReceteDTO> hastaReceteleri;

        public EczaciFrm(int eczaciID)
        {
            InitializeComponent();
            _receteController = new ReceteController();
            receteIlaclari = new List<ReceteIlaclariDTO>();
            hastaReceteleri = new List<HastayaGoreReceteDTO>();
            eczaciController = new EczaciController();
            eczaci = new EczaciEntities();
            eczaci = eczaciController.GetEczaci(eczaciID);
            labelEczaci.Text = "Eczaci " + eczaci.Adi + " " + eczaci.Soyadi;
        }

        private void EczaciFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void EczaciFrm_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox1.Hide();
            button1.Hide();
            lstvIlac.Hide();
            lstvRecete.Hide();
        }

        private void reçeteGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstvRecete.Hide();
            label1.Show();
            textBox1.Show();
            button1.Show();
            gBox.Show();
            gBox.Text = "İlaç Sorgulama";
            label1.Text = "Reçete ID";
            button1.Text = "İlaç Göster";
        }

        private void reçeteSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstvIlac.Hide();
            label1.Show();
            textBox1.Show();
            button1.Show();
            gBox.Show();
            gBox.Text = "Reçete Kayıt Sorgulama";
            label1.Text = "Hasta ID";
            button1.Text = "Reçete Göster";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Reçete Göster")
            {
                lstvRecete.Show();
                lstvRecete.Items.Clear();
                hastaReceteleri = _receteController.GetOldRecetes(int.Parse(textBox1.Text));
                foreach (HastayaGoreReceteDTO item in hastaReceteleri)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.HastaAdi;
                    lvi.SubItems.Add(item.HastaSoyadi);
                    lvi.SubItems.Add(item.ReceteID.ToString());
                    lvi.SubItems.Add(item.IlacAdi);
                    lstvRecete.Items.Add(lvi);
                }
            }
            if (button1.Text == "İlaç Göster")
            {
                lstvIlac.Show();
                lstvIlac.Items.Clear();
                receteIlaclari = _receteController.GetReceteIlaclari(int.Parse(textBox1.Text));
                foreach (ReceteIlaclariDTO item in receteIlaclari)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.ReceteID.ToString();
                    lvi.SubItems.Add(item.IlacID.ToString());
                    lvi.SubItems.Add(item.IlacAdi.ToString());
                    lstvIlac.Items.Add(lvi);
                }
            }
        }
    }
}
