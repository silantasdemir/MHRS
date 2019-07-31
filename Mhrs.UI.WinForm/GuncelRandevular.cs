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
    public partial class GuncelRandevular : Form
    {
        int _hastaID;
        RandevuController _randevuController;
        DoktorCalismaTakvimiController _doktorCalismaTakvimi;
        List<RandevuDTO> randevular;

        public GuncelRandevular(int hastaID)
        {
            InitializeComponent();
            _randevuController = new RandevuController();
            _hastaID = hastaID;
            randevular = new List<RandevuDTO>();
            _doktorCalismaTakvimi = new DoktorCalismaTakvimiController();
        }

        private void GuncelRandevular_Load(object sender, EventArgs e)
        {
            bool durum = true;
            randevular = _randevuController.GuncelRandevulariGetir(durum);
            foreach (RandevuDTO item in randevular)
            {
                ListViewItem lvi = new ListViewItem();
                //lvi.Text = item.HastaAdi;
                lvi.Text = item.HastaneAdi;
                //lvi.SubItems.Add(item.HastaneAdi);
                lvi.SubItems.Add(item.PoliklinikAdi);
                lvi.SubItems.Add(item.DepartmanAdi);
                lvi.SubItems.Add(item.DoktorAdi);
                lvi.SubItems.Add(item.RandevuTarihi.ToString());
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            RandevuDTO randevuDTO = listView1.FocusedItem.Tag as RandevuDTO;
            string doktorAdi = randevuDTO.DoktorAdi;
            string saat = randevuDTO.RandevuTarihi.Hour + ":" + randevuDTO.RandevuTarihi.Minute;
            _doktorCalismaTakvimi.DCTSeansGuncelleme(doktorAdi, saat);

            _randevuController.Sil(new Entities.RandevuEntities { RandevuID = randevuDTO.RandevuID });
        }
    }
}