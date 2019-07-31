using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.DTO
{
    public class DCTDTO
    {
        public int DoktorID { get; set; }
        public string DoktorAdi { get; set; }
        public int PoliklinikID { get; set; }
        public string PoliklinikAdi { get; set; }
        public string Gun { get; set; }
        public string Durum { get; set; }
        public string Saat { get; set; }
    }
}
