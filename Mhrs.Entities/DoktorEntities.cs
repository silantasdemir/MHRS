using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.Entities
{
    public class DoktorEntities
    {
        public int DoktorID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int HastaneID { get; set; }
        public int DepartmanID { get; set; }
    }
}
