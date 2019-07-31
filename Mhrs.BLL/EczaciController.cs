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
    public class EczaciController
    {
        EczaciManagement eczaciManagement;

        public EczaciController()
        {
            eczaciManagement = new EczaciManagement();
        }

        public bool Add(EczaciEntities eczaci)
        {
            return eczaciManagement.Add(eczaci) > 0;
        }

        public bool Update(EczaciEntities eczaci)
        {
            return eczaciManagement.Update(eczaci) > 0;
        }

        public bool Delete(EczaciEntities eczaci)
        {
            return eczaciManagement.Delete(eczaci.EczaciID) > 0;
        }

        public List<EczaciEntities> GetEczacilar()
        {
            return eczaciManagement.GetAllEczaci();
        }

        public EczaciEntities GetEczaci(int eczaciID)
        {
            return eczaciManagement.GetEczaciById(eczaciID);
        }

        public string isLoginSuccess(LoginDTO login)
        {
            List<EczaciEntities> eczacilar = GetEczacilar();
            foreach (EczaciEntities item in eczacilar)
            {
                if (item.KullaniciAdi == login.KullaniciAdi)
                {
                    if (item.Sifre == login.Password)
                    {
                        return item.EczaciID.ToString();
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
