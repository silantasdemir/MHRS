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
   public class TahlilManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        public TahlilManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }
        public List<TahlilEntities> TumTahlilleriGetir()
        {
           
            List<TahlilEntities> TahlilList = new List<TahlilEntities>();
            cmd = new SqlCommand("Select * From Tahliller", conn);
            TahlilEntities currentUser = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser = new TahlilEntities()
                {
                    TahlilID = reader.GetInt32(0),
                    TahlilAdi = reader.GetString(1),
                };
                TahlilList.Add(currentUser);
            }
            reader.Close();
            return TahlilList;

        }
        public TahlilEntities TahlilIDyeGore(int TahlilID)
        {
            TahlilEntities currentUser = new TahlilEntities();
            cmd = new SqlCommand("Select * From Tahliller Where TahlilID = @id", conn);
            cmd.Parameters.AddWithValue("@id", TahlilID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentUser.TahlilID = reader.GetInt32(0);
            currentUser.TahlilAdi = reader.GetString(1);
            reader.Close();
            return currentUser;
        }
    }
}
