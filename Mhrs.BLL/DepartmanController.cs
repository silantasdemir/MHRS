using Mhrs.DAL;
using Mhrs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.BLL
{
    public class DepartmanController
    {
        DepartmanManagement _departmanManagement;
        public DepartmanController()
        {
            _departmanManagement = new DepartmanManagement();
        }

        public List<DepartmanEntities> DepartmanlariGetir()
        {
            return _departmanManagement.GetAllDepartman();
        }

        public List<string> DepartmanAdlariGetir()
        {
            List<string> departmanAdlari = new List<string>();
            foreach (var item in _departmanManagement.GetAllDepartman())
            {
                departmanAdlari.Add(item.DepartmanAdi);
            }
            return departmanAdlari;
        }

        public DepartmanEntities IDyeGoreDepartmanGetir(int departmanID)
        {
            return _departmanManagement.GetDepartmanById(departmanID);
        }
    }
}
