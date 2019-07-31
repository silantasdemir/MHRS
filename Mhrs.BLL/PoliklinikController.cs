using Mhrs.DAL;
using Mhrs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.BLL
{
    public class PoliklinikController
    {
        PoliklinikManagement _poliklinikManagement;
        public PoliklinikController()
        {
            _poliklinikManagement = new PoliklinikManagement();
        }

        public List<PoliklinikEntities> TumPolGetir()
        {
            return _poliklinikManagement.TumPoliklinikleriGetir();
        }

        public List<string> PolikliniklerAdlariGetir()
        {
            List<string> poliklinikAdlari = new List<string>();
            foreach (var item in _poliklinikManagement.TumPoliklinikleriGetir())
            {
                poliklinikAdlari.Add(item.PoliklinikAdi);
            }
            return poliklinikAdlari;
        }

        public List<string> HastaneIDGorePol(int hastID)
        {
            return _poliklinikManagement.HastaneIDyeGore(hastID);
        }

        //public string PolAdiGoreHastaneAdi(string polAdi)
        //{
        //    return _poliklinikManagement.PolAdiGoreHastaneAdi(polAdi);
        //}
    }
}
