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
    public class DoktorController
    {
        DoktorManagement _doktorManagement;
        public DoktorController()
        {
            _doktorManagement = new DoktorManagement();
        }

        public List<DoktorEntities> DoktorlariGetir()
        {
            return _doktorManagement.TumDoktorlariGetir();
        }

        public DoktorEntities GetDoktor(int doktorID)
        {
            return _doktorManagement.DoktorIDyeGore(doktorID);
        }

        public List<DoktorEntities> HastaneIDGore(int HastID)
        {
            return _doktorManagement.HastaneIDyeGore(HastID);
        }

        public List<DoktorEntities> DepartmanIDGore(int DepID)
        {
            return _doktorManagement.DepartmanIDyeGore(DepID);
        }


        public List<string> DepIDGoreDoktorIsimler(int DepID)
        {
            List<string> doktorlar = new List<string>();
            foreach (var item in DepartmanIDGore(DepID))
            {
                doktorlar.Add(item.Adi+" "+item.Soyadi);
            }
            return doktorlar;
        }



        public string isLoginSuccess(LoginDTO login)
        {
            List<DoktorEntities> doktorlar = DoktorlariGetir();
            foreach (DoktorEntities item in doktorlar)
            {
                if (item.KullaniciAdi == login.KullaniciAdi)
                {
                    if (item.Sifre == login.Password)
                    {
                        return item.DoktorID.ToString();
                    }
                    else
                    {
                        return "Sifre yanlış";
                    }
                }
            }
            return "Kullanıcı adı yanlış";
        }
    }
}
