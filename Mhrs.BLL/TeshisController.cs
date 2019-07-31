using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mhrs.DAL;
using Mhrs.Entities;

namespace Mhrs.BLL
{
    public class TeshisController
    {
        TeshisManagement teshisManagement;

        public TeshisController()
        {
            teshisManagement = new TeshisManagement();
        }

        public List<TeshisEntities> GetTeshisler()
        {
            return teshisManagement.TumTeshisleriGetir();
        }

        public List<String> GetTeshisAdlari()
        {
            List<String> adlar = new List<string>();
            List<TeshisEntities> teshisler = new List<TeshisEntities>();
            teshisler = GetTeshisler();

            foreach (TeshisEntities item in teshisler)
            {
                adlar.Add(item.TeshisAdi);
            }

            return adlar;
        }


    }
}
