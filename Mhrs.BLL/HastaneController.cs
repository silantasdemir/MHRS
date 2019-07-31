using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mhrs.DAL;
using Mhrs.Entities;

namespace Mhrs.BLL
{
    public class HastaneController
    {
        HastaneManagement hastaneManagement;

        public HastaneController()
        {
            hastaneManagement = new HastaneManagement();
        }

        public List<HastanelerEntities> GetHastaneler()
        {
            return hastaneManagement.GetAllHastane();
        }

        public HastanelerEntities IDGetHastane(int hastaneID)
        {
            return hastaneManagement.GetHastaneById(hastaneID);
        }

        public List<String> GetHastaneAdları()
        {
            List<HastanelerEntities> hastaneler = GetHastaneler();
            List<string> hastaneAdlari = new List<string>();

            foreach (HastanelerEntities item in hastaneler)
            {
                hastaneAdlari.Add(item.HastaneAdi);
            }
            return hastaneAdlari;
        }

    }
}
