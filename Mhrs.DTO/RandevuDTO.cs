using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.DTO
{
    public class RandevuDTO
    {
        public int HastaID { get; set; }
        public string HastaneAdi { get; set; }
        public string HastaAdi { get; set; }
        public string DoktorAdi { get; set; }
        public string PoliklinikAdi { get; set; }
        public string DepartmanAdi { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public int RandevuID { get; set; }

    }
}
