using Mhrs.BLL;
using Mhrs.DTO;
using Mhrs.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mhrs.UI.WinForm
{
    public partial class RandevuListFrm : Form
    {
        DoktorCalismaTakvimiController _doktorCalisma;
        RandevuController _randevuController;
        DoktorCalismaTakvimiController _doktorCalismaTakvimiController;
        DepRandevuDTO _depRandevuDTO;
        int _drID;
        int _hastaID;
        public RandevuListFrm(int drID,int hastaID, DepRandevuDTO depRandevuDTO = null)
        {
            InitializeComponent();
            _depRandevuDTO = depRandevuDTO;
            _drID = drID;
            _doktorCalismaTakvimiController = new DoktorCalismaTakvimiController();
            _randevuController = new RandevuController();
            _doktorCalisma = new DoktorCalismaTakvimiController();
            _hastaID = hastaID;
        }

        ListViewItem lvi;
        private void RandevuListFrm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            label1.Text ="Hastane Adı : "+ _depRandevuDTO.HastaneAdi + "\n\nPoliklinik Adı : " + _depRandevuDTO.PoliklinikAdi;

            listView1.Columns.Add("DoktorAdi",100);
            listView1.Columns.Add("PoliklinikAdi",250);
            listView1.Columns.Add("Gun",150);
            listView1.Columns.Add("Saat",80);
            Listele();
        }
        void Listele()
        {
            listView1.Items.Clear();
            foreach (var item in _doktorCalismaTakvimiController.DoktorCalismaTakvimigetir(_drID))
            {
                lvi = new ListViewItem();
                lvi.Text = item.DoktorAdi;
                lvi.SubItems.Add(item.PoliklinikAdi);
                lvi.SubItems.Add(item.Gun);
                lvi.SubItems.Add(item.Saat);
                lvi.Tag = item;
                if (item.Durum == "True")
                {
                    lvi.BackColor = Color.Red;
                }
                listView1.Items.Add(lvi);
            }
        }


        private void btnSeansAl_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem == null)
            {
                return;
            }
            if (listView1.FocusedItem.BackColor == Color.Red)
            {
                MessageBox.Show("Seans daha önce alınmış");
                return;
            }
            DCTDTO randevu = new DCTDTO();
            randevu =(DCTDTO) listView1.FocusedItem.Tag;
            randevu.Durum = "True";
            bool result = _randevuController.Ekle(randevu,_hastaID);
            if (result)
            {
                _doktorCalisma.SeansAl(randevu);
                Listele();
                MessageBox.Show("Seans Alma Başarılı..");
                this.Close();
            }
            else
            {
                MessageBox.Show("Seans Alma Başarısız!!");
            }
        }
    }
}
