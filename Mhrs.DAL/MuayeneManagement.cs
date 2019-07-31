using Mhrs.DTO;
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
    public class MuayeneManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public MuayeneManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }

        public int Add(MuayeneEntities muayene)
        {
            cmd = new SqlCommand("INSERT INTO Muayeneler VALUES (@randevuID,@teshisID,@tahlilID,@not)", conn);
            AddParametersToCommand(muayene);
            return ExecuteCommand();
        }

        public List<MuayeneEntities> TumMuayeneleriGetir()
        {
            List<MuayeneEntities> MuayeneList = new List<MuayeneEntities>();
            cmd = new SqlCommand("Select * From Muayeneler", conn);
            MuayeneEntities currentUser = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser = new MuayeneEntities()
                {
                    MuayeneID = reader.GetInt32(0),
                    RandevuID = reader.GetInt32(1),
                    TeshisID = reader.GetInt32(2),
                    TahlilID = reader.GetInt32(3),
                    Not = reader.GetString(4)
                };
                MuayeneList.Add(currentUser);
            }
            reader.Close();
            return MuayeneList;
        }

        public List<HastaMuaneleriDTO> GetMuayeneByHasta(int hastaID, int drID)
        {
            List<HastaMuaneleriDTO> MuayeneList = new List<HastaMuaneleriDTO>();
            cmd = new SqlCommand(@"select m.MuayeneID,r.RandevuID,r.RandevuTarihi from Muayeneler m join Randevular r on m.RandevuID=r.RandevuID join Hastalar h on h.HastaID=r.HastaID where r.HastaID=@hastaID and r.DoktorID=@drID order by RandevuTarihi", conn);
            cmd.Parameters.AddWithValue("@hastaID", hastaID);
            cmd.Parameters.AddWithValue("@drID", drID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                MuayeneList.Add(new HastaMuaneleriDTO
                {
                    muaneID = reader.GetInt32(0),
                    randevuID = reader.GetInt32(1),
                    tarih = reader.GetDateTime(2)
                });
            }
            reader.Close();
            return MuayeneList;
        }

        public MuayeneEntities GetMuayeneByID(int ID)
        {
            MuayeneEntities muayene = new MuayeneEntities();
            cmd = new SqlCommand("select * from Muayeneler where MuayeneID=@id", conn);
            cmd.Parameters.AddWithValue("@id", ID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            muayene.MuayeneID = reader.GetInt32(0);
            muayene.RandevuID = reader.GetInt32(1);
            muayene.TeshisID = reader.GetInt32(2);
            muayene.TahlilID = reader.GetInt32(3);
            muayene.Not = reader.GetString(4);
            reader.Close();
            return muayene;
        }

        void AddParametersToCommand(MuayeneEntities muayene)
        {
            cmd.Parameters.AddWithValue("@randevuID", muayene.RandevuID);
            cmd.Parameters.AddWithValue("@teshisID", muayene.TeshisID);
            cmd.Parameters.AddWithValue("@tahlilID", muayene.TahlilID);
            cmd.Parameters.AddWithValue("@not", muayene.Not);
        }

        int ExecuteCommand()
        {
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
