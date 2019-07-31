using Mhrs.DAL;
using Mhrs.DTO;
using Mhrs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.BLL
{
    public class DoktorCalismaTakvimiController
    {
        DoktorCalismaTakvimiManagement _doktorCalisma;
        public DoktorCalismaTakvimiController()
        {
            _doktorCalisma = new DoktorCalismaTakvimiManagement();
        }

        public List<DCTDTO> DoktorCalismaTakvimigetir(int drID)
        {
            return _doktorCalisma.CalismaTakvimiGetir(drID);
        }

        public bool DoktorCalismaTakvimiGuncelle(DCTEntities dct)
        {
            return _doktorCalisma.CalismaTakvimiGuncelle(dct);
        }

        public bool SeansAl(DCTDTO dCTDTO)
        {
            return _doktorCalisma.SeansAl(dCTDTO);
        }

        public void DCTSeansGuncelleme(string doktorAdi, string saat)
        {
            _doktorCalisma.DCTSeansGuncelle(doktorAdi, saat);
        }

        public List<DCTEntities> CalismaTakvimiGetir(RandevuEntities randevu, String tarih)
        {
            return _doktorCalisma.CalismaTakvimiGetir(randevu, tarih);
        }


    }
}
