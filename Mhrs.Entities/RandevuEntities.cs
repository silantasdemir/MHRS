using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.Entities
{
    public class RandevuEntities
    {
        public int RandevuID { get; set; }
        public int  HastaID { get; set; }
        public int DoktorID { get; set; }
        public int PoliklinikID { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public bool Durum { get; set; }
    }
}
