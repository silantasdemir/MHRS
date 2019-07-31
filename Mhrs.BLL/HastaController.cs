using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mhrs.DAL;
using Mhrs.DTO;
using Mhrs.Entities;

namespace Mhrs.BLL
{
    public class HastaController
    {
        HastaManagement hastaManagement;

        public HastaController()
        {
            hastaManagement = new HastaManagement();
        }

        void SifreKarakter(string sifre)
        {
            foreach (char item in sifre)
            {
                if (!char.IsLetter(item) && !char.IsNumber(item) || item == ' ')
                {
                    throw new Exception("Şifre Harf ve rakamlardan oluşmalıdır!!");
                }
            }
        }

        bool CheckUserByMail(string kAdi)
        {
            List<HastaEntities> hastalar = hastaManagement.GetAllHasta();
            foreach (HastaEntities item in hastalar)
            {
                if (item.KullaniciAdi == kAdi)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Add(HastaEntities hasta)
        {
            if (CheckUserByMail(hasta.KullaniciAdi))
            {
                throw new Exception("Bu mail sistemde kayıtlı olduğundan tekrar eklenemez");
            }
            return hastaManagement.Add(hasta) > 0;
        }

        public bool Update(HastaEntities hasta)
        {
            return hastaManagement.Update(hasta) > 0;
        }

        public bool Delete(HastaEntities hasta)
        {
            return hastaManagement.Delete(hasta.HastaID) > 0;
        }

        public List<HastaEntities> GetHastalar()
        {
            return hastaManagement.GetAllHasta();
        }

        public HastaEntities GetHasta(int hastaID)
        {
            return hastaManagement.GetHastaById(hastaID);
        }

        public string isLoginSuccess(LoginDTO login)
        {
            List<HastaEntities> hastalar = GetHastalar();
            foreach (HastaEntities item in hastalar)
            {
                if (item.KullaniciAdi == login.KullaniciAdi)
                {
                    if (item.Sifre == login.Password)
                    {
                        return item.HastaID.ToString();
                    }
                    else
                    {
                        return "Sifre yanlış";
                    }
                }
            }
            return "E-mail yanlış";
        }
    }
}
