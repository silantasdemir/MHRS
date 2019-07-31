using Mhrs.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhrs.DAL
{
    public class TeshisManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        public TeshisManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }
        public List<TeshisEntities> TumTeshisleriGetir()
        {

            List<TeshisEntities> TeshisList = new List<TeshisEntities>();
            cmd = new SqlCommand("Select * From Teshisler", conn);
            TeshisEntities currentUser = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser = new TeshisEntities()
                {
                    TeshisID = reader.GetInt32(0),
                    TeshisAdi = reader.GetString(1)
                };
                TeshisList.Add(currentUser);
            }
            reader.Close();
            return TeshisList;
        }
        public TeshisEntities TEshisIDyeGore(int TeshisID)
        {
            TeshisEntities currentUser = new TeshisEntities();
            cmd = new SqlCommand("Select * From Teshisler Where TeshisID = @id", conn);
            cmd.Parameters.AddWithValue("@id", TeshisID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentUser.TeshisID = reader.GetInt32(0);
            currentUser.TeshisAdi = reader.GetString(1);
            reader.Close();
            return currentUser;
        }
    }
}
