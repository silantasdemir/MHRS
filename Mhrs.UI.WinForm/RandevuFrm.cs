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
    public partial class RandevuFrm : Form
    {
        HastaneController _hastaneController;
        PoliklinikController _poliklinikController;
        DepartmanController _departmanController;
        PoliklinikDepartmanController _poliklinikDepartmanController;
        DoktorController _doktorController;
        RandevuController _randevuController;
        int _hastaID;
        public RandevuFrm(int hastaID)
        {
            InitializeComponent();
            _hastaneController = new HastaneController();
            _poliklinikController = new PoliklinikController();
            _departmanController = new DepartmanController();
            _poliklinikDepartmanController = new PoliklinikDepartmanController();
            _doktorController = new DoktorController();
            _randevuController = new RandevuController();
            _hastaID = hastaID;
        }

        private void RandevuFrm_Load(object sender, EventArgs e)
        {
            datepicRandevu.MinDate = DateTime.Today;
            Listele();
        }

        private void btnRandevuAra_Click(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedItem == null || cmbDoktor.SelectedItem == null)
            {
                return;
            }
            ID = 0;
            foreach (var item in _doktorController.DoktorlariGetir())
            {
                if (item.Adi + " " + item.Soyadi == cmbDoktor.SelectedItem.ToString())
                {
                    ID = item.DoktorID;
                    break;
                }
            }
            DepRandevuDTO hastpol = new DepRandevuDTO();
            hastpol = _randevuController.doktorHastPol(ID, datepicRandevu.Value);
            if (hastpol.HastaneAdi == null)
            {
                MessageBox.Show("Doktorun o tarihte seansı yok");
                return;
            }
            RandevuListFrm randevuListFrm = new RandevuListFrm(ID, _hastaID, hastpol);
            randevuListFrm.Show();
            randevuListFrm.Owner = this;
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            cmbHastane.DataSource = _hastaneController.GetHastaneAdları();
            //cmbPoliklinik.DataSource = _poliklinikController.PolikliniklerAdlariGetir();
            cmbDepartman.DataSource = _departmanController.DepartmanAdlariGetir();
            cmbHastane.SelectedIndex = -1;
            cmbDepartman.SelectedIndex = -1;
            //cmbPoliklinik.SelectedIndex = -1;
            //cmbDoktor.SelectedIndex = -1;
            cmbDoktor.DataSource = null;
            datepicRandevu.Text = DateTime.Today.ToShortDateString();
        }

        int ID = 0;
        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHastane.SelectedValue == null)
            {
                return;
            }
            foreach (var item in _hastaneController.GetHastaneler())
            {
                if (item.HastaneAdi == cmbHastane.SelectedValue.ToString())
                {
                    ID = item.HastaneID;
                    break;
                }
            }
            if (ID > 0)
            {
                List<string> PolAdlari = new List<string>();
                PolAdlari.AddRange(_poliklinikController.HastaneIDGorePol(ID));
                cmbPoliklinik.Items.Clear();
                foreach (string item in PolAdlari)
                {
                    cmbPoliklinik.Items.Add(item);
                }
            }
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoliklinik.SelectedItem.ToString() == null)
            {
                return;
            }
            ID = 0;
            List<string> DepartmanAdlari = new List<string>();
            foreach (var item in _poliklinikController.TumPolGetir())
            {
                if (item.PoliklinikAdi == cmbPoliklinik.SelectedItem.ToString())
                {
                    ID = item.PoliklinikID;
                    break;
                }
            }
            List<string> departmanAdlari = new List<string>();
            departmanAdlari.AddRange(_poliklinikDepartmanController.PolIDGoreDeparmantAdlari(ID));
            cmbDepartman.DataSource = departmanAdlari;
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedValue == null)
            {
                return;
            }
            int depID = 0;
            List<string> doktorlar = new List<string>();
            foreach (var item in _departmanController.DepartmanlariGetir())
            {
                if (item.DepartmanAdi == cmbDepartman.SelectedValue.ToString())
                {
                    depID = item.DepartmanID;
                    break;
                }
            }
            if (depID != 0)
            {
                doktorlar = _doktorController.DepIDGoreDoktorIsimler(depID);
                cmbDoktor.DataSource = doktorlar;
            }
        }

        private void datepicRandevu_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
