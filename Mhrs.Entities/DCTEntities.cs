using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.Entities
{
    public class DCTEntities
    {
        public int DoktorID { get; set; }
        public int PoliklinikID { get; set; }
        public DateTime Gun { get; set; }
        public bool Durum { get; set; }
        public string Saat { get; set; }


    }
}
