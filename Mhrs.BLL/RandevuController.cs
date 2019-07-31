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
    public class RandevuController
    {
        RandevuManagement _randevuManagement;
        public RandevuController()
        {
            _randevuManagement = new RandevuManagement();
        }

        public List<RandevuDTO> RandevulariListele()
        {
            return _randevuManagement.RandevulariGetir();
        }

        public bool Ekle(DCTDTO randevuEntities, int hastaID)
        {
            return _randevuManagement.RandevuEkle(randevuEntities, hastaID);
        }

        public bool RandevuEkle(RandevuEntities randevu)
        {
            return _randevuManagement.RandevuEkle(randevu);
        }

        public bool Sil(RandevuEntities randevuEntities)
        {
            return _randevuManagement.RandevuSil(randevuEntities.RandevuID);
        }

        public bool RandevuGuncelle(int randevuID)
        {
            return _randevuManagement.RandevuGuncelle(randevuID);
        }

        public RandevuEntities GetRandevu(int randevuID)
        {
            return _randevuManagement.GetRandevu(randevuID);
        }

        public DepRandevuDTO doktorHastPol(int drID, DateTime tarih)
        {
            return _randevuManagement.DoktorHastanesiPoliklinigi(drID, tarih);
        }

        public List<RandevuHastaDTO> GetAllRandevu(int drID, string tarih)
        {
            return _randevuManagement.GetAllRandevular(drID, tarih);
        }

        public List<RandevuDTO> GuncelRandevulariGetir(bool durum)
        {
            return _randevuManagement.GuncelRandevular(durum);
        }

        public List<RandevuDTO> GecmisRandevulariGetir()
        {
            return _randevuManagement.GecmisRandevular();
        }

    }
}
