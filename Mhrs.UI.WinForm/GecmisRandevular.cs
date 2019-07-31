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
    public partial class GecmisRandevular : Form
    {
        int _hastaID;
        RandevuController _randevuController;
        List<RandevuDTO> randevular;

        public GecmisRandevular(int hastaID)
        {
            InitializeComponent();
            _randevuController = new RandevuController();
            _hastaID = hastaID;
            randevular = new List<RandevuDTO>();
        }

        private void GecmisRandevular_Load(object sender, EventArgs e)
        {
            randevular = _randevuController.GecmisRandevulariGetir();
            foreach (RandevuDTO item in randevular)
            {
                ListViewItem lvi = new ListViewItem();
                //lvi.Text = item.HastaAdi;
                lvi.Text = item.HastaneAdi;
                lvi.SubItems.Add(item.PoliklinikAdi);
                lvi.SubItems.Add(item.DepartmanAdi);
                lvi.SubItems.Add(item.DoktorAdi);
                lvi.SubItems.Add(item.RandevuTarihi.ToString());
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
        }
    }
}
