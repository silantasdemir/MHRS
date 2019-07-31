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

namespace Mhrs.UI.WinForm
{
    public partial class MainFrm : Form
    {
        HastaController hastaController;
        DoktorController doktorController;
        EczaciController eczaciController;
        LoginDTO login;

        public MainFrm()
        {
            InitializeComponent();
            hastaController = new HastaController();
            doktorController = new DoktorController();
            eczaciController = new EczaciController();
            login = new LoginDTO();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (bosKontrol())
            {
                string result = hastaController.isLoginSuccess(login);
                int hastaID;

                if (int.TryParse(result, out hastaID))
                {
                    HastaFrm hastaFrm = new HastaFrm(hastaID);
                    hastaFrm.Owner = this;
                    hastaFrm.Show();
                    this.Hide();
                    Temizle();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            KayıtFrm register = new KayıtFrm();
            register.Show();
            register.Owner = this;
            this.Hide();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            if (bosKontrol())
            {
                string result = doktorController.isLoginSuccess(login);
                int doktorID;

                if (int.TryParse(result, out doktorID))
                {
                    DoktorFrm doktorFrm = new DoktorFrm(doktorID);
                    doktorFrm.Owner = this;
                    doktorFrm.Show();
                    this.Hide();
                    Temizle();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void btnEczaciGiris_Click(object sender, EventArgs e)
        {
            if (bosKontrol())
            {
                string result = eczaciController.isLoginSuccess(login);
                int eczaciID;

                if (int.TryParse(result, out eczaciID))
                {
                    EczaciFrm eczaciFrm = new EczaciFrm(eczaciID);
                    eczaciFrm.Owner = this;
                    eczaciFrm.Show();
                    this.Hide();
                    Temizle();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        void Temizle()
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        bool bosKontrol()
        {
            if (String.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı girin");
                return false;
            }
            else if (String.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen sifrenizi girin");
                return false;
            }
            else
            {
                login.KullaniciAdi = txtKullaniciAdi.Text;
                login.Password = txtSifre.Text;
                return true;
            }
        }

    }
}