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
    public class ReceteController
    {
        ReceteManagement receteManagement;
        public ReceteController()
        {
            receteManagement = new ReceteManagement();
        }

        public bool Add(ReceteEntities recete)
        {
            return receteManagement.Add(recete) > 0;
        }

        public List<HastayaGoreReceteDTO> GetOldRecetes(int hastaID)
        {
            return receteManagement.HastaIDyeGore(hastaID);
        }

        public List<ReceteIlaclariDTO> GetReceteIlaclari(int receteID)
        {
            return receteManagement.ReceteIlaclari(receteID);
        }

    }

}
