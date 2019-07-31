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
    public class PoliklinikManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        public PoliklinikManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }
        public List<PoliklinikEntities> TumPoliklinikleriGetir()
        {
           
            List<PoliklinikEntities> Poliklist = new List<PoliklinikEntities>();
            cmd = new SqlCommand("Select * From Poliklinikler", conn);
            PoliklinikEntities currentUser = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser = new PoliklinikEntities()
                {
                    PoliklinikID = reader.GetInt32(0),
                    PoliklinikAdi = reader.GetString(1),
                    HastaneID=reader.GetInt32(2)
            
                };
                Poliklist.Add(currentUser);
            }
            reader.Close();
            return Poliklist;

        }
        public PoliklinikEntities PoliklinikIDyeGore(int PoliklinikID)
        {
            PoliklinikEntities currentUser = new PoliklinikEntities();
            cmd = new SqlCommand("Select * From Poliklinikler Where PoliklinilID = @id", conn);
            cmd.Parameters.AddWithValue("@id", PoliklinikID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentUser.PoliklinikID = reader.GetInt32(0);
            currentUser.PoliklinikAdi = reader.GetString(1);
            currentUser.HastaneID = reader.GetInt32(2);
            reader.Close();
            return currentUser;
        }
        public List<string> HastaneIDyeGore(int HastaneID)
        {
            List<string> currentUser = new List<string>();
            cmd = new SqlCommand("Select PoliklinikAdi From Poliklinikler Where HastaneID = @id", conn);
            cmd.Parameters.AddWithValue("@id", HastaneID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    currentUser.Add(reader["PoliklinikAdi"].ToString());
                }
            }
            reader.Close();
            return currentUser;
        }

        //public string PolAdiGoreHastaneAdi(string polAdi)
        //{
        //    cmd = new SqlCommand(@"select HastaneAdi
        //                        from Poliklinikler p join Hastaneler h
        //                        on p.HastaneID=h.HastaneID
        //                        where PoliklinikAdi=@padi", conn);
        //    cmd.Parameters.AddWithValue("@padi",polAdi);
        //    conn.Open();
        //    string HastaneAdi=(string)cmd.ExecuteScalar();
        //    conn.Close();
        //    return HastaneAdi;
        //}
    }
}
