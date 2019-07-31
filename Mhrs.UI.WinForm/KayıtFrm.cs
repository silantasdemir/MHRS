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
    public partial class KayıtFrm : Form
    {
        HastaController hastaController;

        public KayıtFrm()
        {
            InitializeComponent();
            hastaController = new HastaController();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (SifreKontrol() && BosKontrol())
            {
                HastaEntities hasta = new HastaEntities();
                hasta.Adi = txtAd.Text;
                hasta.Soyadi = txtSoyad.Text;
                hasta.KullaniciAdi = txtEmail.Text;
                hasta.Sifre = txtsifre.Text;
                if (cmbCinsiyet.SelectedIndex == 0)
                    hasta.Cinsiyet = false;
                else
                    hasta.Cinsiyet = true;

                bool result = hastaController.Add(hasta);
                MessageBox.Show(result ? "Kayıt başarılı" : "Kayıt başarısız");
            }
        }
        bool BosKontrol()
        {
            if (String.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("Lütfen hasta adi giriniz");
                return false;
            }
            else if (String.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen hasta soyadi giriniz");
                return false;
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Lütfen mail giriniz");
                return false;
            }
            else if (cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz");
                return false;
            }
            else if (String.IsNullOrEmpty(txtsifre.Text))
            {
                MessageBox.Show("Lütfen şifre giriniz");
                return false;
            }
            else if (String.IsNullOrEmpty(txttekrar.Text))
            {
                MessageBox.Show("Lütfen tekrar şifre giriniz");
                return false;
            }
            else
                return true;
        }

        bool SifreKontrol()
        {
            if (txtsifre.Text != txttekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor !");
                return false;
            }
            else if (txtsifre.TextLength < 8)
            {
                MessageBox.Show("Şifre 8 karakterden az olamaz !");
                return false;
            }
            else if (txtsifre.TextLength > 16)
            {
                MessageBox.Show("Şifre 16 karakterden fazla olamaz !");
                return false;
            }
            else
            {
                foreach (char item in txtsifre.Text)
                {
                    if (!char.IsLetter(item) && !char.IsNumber(item) || item == ' ')
                    {
                        MessageBox.Show("Şifre harf ve rakamlardan oluşmalıdır !");
                        return false;
                    }
                }
            }
            return true;
        }

        private void KayıtFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
