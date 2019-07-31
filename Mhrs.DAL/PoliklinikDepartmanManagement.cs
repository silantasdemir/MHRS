using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.DAL
{
    public class PoliklinikDepartmanManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        public PoliklinikDepartmanManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }

        public List<string> PolIDGoreDepartmanAdlari(int PolID)
        {
            List<string> departmanAdlari = new List<string>();
            cmd = new SqlCommand(@"select d.DepartmanAdi
                                from PoliklinikDepartmanlari pd join Departmanlar d
                                on pd.DepartmanID = d.DepartmanID
                                where PoliklinikID = @pid",conn);
            cmd.Parameters.AddWithValue("@pid",PolID);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            rd.Read();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    departmanAdlari.Add(rd["DepartmanAdi"].ToString());
                }
            }
            rd.Close();
            return departmanAdlari;
        }
    }
}
