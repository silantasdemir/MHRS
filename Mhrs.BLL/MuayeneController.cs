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
    public class MuayeneController
    {
        MuayeneManagement muayeneManagement;

        public MuayeneController()
        {
            muayeneManagement = new MuayeneManagement();
        }

        public bool Add(MuayeneEntities muayene)
        {
            return muayeneManagement.Add(muayene) > 0;
        }
        public List<HastaMuaneleriDTO> getHastaMuayeneleri(int drID, int hastaID)
        {
            return muayeneManagement.GetMuayeneByHasta(drID, hastaID);
        }
        public MuayeneEntities getMuayeneByID(int ID)
        {
            return muayeneManagement.GetMuayeneByID(ID);
        }


    }
}
