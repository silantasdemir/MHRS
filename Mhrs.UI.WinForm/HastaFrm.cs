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
    public partial class HastaFrm : Form
    {
        HastaController hastaController;
        HastaEntities hasta;
        int _hastaID;
        public HastaFrm(int hastaID)
        {
            InitializeComponent();
            hastaController = new HastaController();
            hasta = new HastaEntities();
            hasta = hastaController.GetHasta(hastaID);
            labelHasta.Text = "Sn. " + hasta.Adi + " " + hasta.Soyadi;
            _hastaID = hastaID;
        }

        private void HastaFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildMethods.ChildForm(new RandevuFrm(_hastaID), this);
        }

        private void randevuTaleplerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildMethods.ChildForm(new GuncelRandevular(_hastaID), this);
        }

        private void randevuGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildMethods.ChildForm(new GecmisRandevular(_hastaID), this);
        }

        private void hesapBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildMethods.ChildForm(new HastaBilgileriFrm(_hastaID), this);
        }
    }
}
