using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mhrs.UI.WinForm
{
    static class ChildMethods
    {
        public static void ChildForm(Form childform, Form mdi)
        {
            bool durum = false;
            foreach (Form frm in mdi.MdiChildren)
            {
                if (frm.Text == childform.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }

            if (durum == false)
            {
                childform.MdiParent = mdi;
                childform.Show();
            }
        }
    }
}
