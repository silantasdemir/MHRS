using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mhrs.DAL;
using Mhrs.Entities;

namespace Mhrs.BLL
{
    public class TahlilController
    {
        TahlilManagement tahlilManagement;

        public TahlilController()
        {
            tahlilManagement = new TahlilManagement();
        }

        public List<TahlilEntities> GetTahliller()
        {
            return tahlilManagement.TumTahlilleriGetir();
        }

        public List<String> GetTahlilAdlari()
        {
            List<String> adlar = new List<string>();
            List<TahlilEntities> tahlilller = new List<TahlilEntities>();
            tahlilller = GetTahliller();

            foreach (TahlilEntities item in tahlilller)
            {
                adlar.Add(item.TahlilAdi);
            }

            return adlar;
        }


    }
}
