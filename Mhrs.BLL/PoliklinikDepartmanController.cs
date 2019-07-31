using Mhrs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.BLL
{
    public class PoliklinikDepartmanController
    {
        PoliklinikDepartmanManagement _poliklinikDepartmanManagement = new PoliklinikDepartmanManagement();
        public PoliklinikDepartmanController()
        {
            _poliklinikDepartmanManagement = new PoliklinikDepartmanManagement();
        }

        public List<string> PolIDGoreDeparmantAdlari(int polID)
        {
            return _poliklinikDepartmanManagement.PolIDGoreDepartmanAdlari(polID);
        }

    }
}
