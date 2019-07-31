using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mhrs.DAL;
using Mhrs.Entities;

namespace Mhrs.BLL
{
    public class IlacController
    {
        IlacManagement ilacManagement;

        public IlacController()
        {
            ilacManagement = new IlacManagement();
        }

        public List<IlacEntities> GetIlaclar()
        {
            return ilacManagement.GetIlaclar();
        }

        public List<String> GetIlacAdlari()
        {
            List<String> adlar = new List<string>();
            List<IlacEntities> ilaclar = new List<IlacEntities>();
            ilaclar = GetIlaclar();

            foreach (IlacEntities item in ilaclar)
            {
                adlar.Add(item.IlacAdi);
            }

            return adlar;
        }
    }
}
