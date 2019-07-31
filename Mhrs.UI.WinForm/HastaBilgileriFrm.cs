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
using Mhrs.Entities;

namespace Mhrs.UI.WinForm
{
    public partial class HastaBilgileriFrm : Form
    {
        int tempHastaID;
        HastaController hastaController;
        HastaEntities hasta;

        public HastaBilgileriFrm(int hastaID)
        {
            InitializeComponent();
            hasta = new HastaEntities();
            hastaController = new HastaController();
            tempHastaID = hastaID;
        }

        private void HastaBilgileriFrm_Load(object sender, EventArgs e)
        {
            hasta = hastaController.GetHasta(tempHastaID);
            txtad.Text = hasta.Adi;
            txtsoyad.Text = hasta.Soyadi;
            if (hasta.Cinsiyet)
            {
                txtcins.Text = "Kadın";
            }
            else
            {
                txtcins.Text = "Erkek";
            }

            txtmail.Text = hasta.KullaniciAdi;
            txtsifre.Text = hasta.Sifre;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            hasta.Sifre = txtsifre.Text;
            hasta.KullaniciAdi = txtmail.Text;
            bool result = hastaController.Update(hasta);
            MessageBox.Show("Güncelleme gerçekleşti");
        }
    }
}
