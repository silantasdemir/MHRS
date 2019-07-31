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
    public class ReceteManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ReceteManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }

        public int Add(ReceteEntities recete)
        {
            cmd = new SqlCommand("INSERT INTO Receteler VALUES (@ilacID,@randevuID)", conn);
            AddParametersToCommand(recete);
            return ExecuteCommand();
        }

        public List<ReceteEntities> TumReceteleriGetir()
        {

            List<ReceteEntities> ReceteList = new List<ReceteEntities>();
            cmd = new SqlCommand("Select * From Receteler", conn);
            ReceteEntities currentUser = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser = new ReceteEntities()
                {
                    ReceteID = reader.GetInt32(0),
                    IlacID = reader.GetInt32(1),
                    RandevuID = reader.GetInt32(2)
                };
                ReceteList.Add(currentUser);
            }
            reader.Close();
            return ReceteList;
        }
        public List<HastayaGoreReceteDTO> HastaIDyeGore(int hastaID)
        {
            List<HastayaGoreReceteDTO> hastaReceteleri = new List<HastayaGoreReceteDTO>();
            cmd = new SqlCommand("select h.Adi,h.Soyadi,re.ReceteID,i.IlacAdi from Randevular ra join Receteler re on ra.RandevuID = re.RandevuID join İlaclar i on i.IlacID = re.İlacID join Hastalar h on h.HastaID = ra.HastaID where h.HastaID =@id", conn);
            cmd.Parameters.AddWithValue("@id", hastaID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                hastaReceteleri.Add(new HastayaGoreReceteDTO
                {
                    HastaAdi = reader.GetString(0),
                    HastaSoyadi = reader.GetString(1),
                    ReceteID = reader.GetInt32(2),
                    IlacAdi = reader.GetString(3),
                });
            }

            reader.Close();
            return hastaReceteleri;
        }
        public ReceteEntities RandevuIdyeGore(int RandevuID)
        {
            ReceteEntities currentUser = new ReceteEntities();
            cmd = new SqlCommand("Select * From receteler Where RandevuID = @id", conn);
            cmd.Parameters.AddWithValue("@id", RandevuID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentUser.ReceteID = reader.GetInt32(0);
            currentUser.IlacID = reader.GetInt32(1);
            currentUser.RandevuID = reader.GetInt32(2);
            reader.Close();
            return currentUser;
        }

        public List<ReceteIlaclariDTO> ReceteIlaclari(int receteID)
        {
            List<ReceteIlaclariDTO> receteIlaclari = new List<ReceteIlaclariDTO>();
            cmd = new SqlCommand("select re.ReceteID,i.IlacID,i.IlacAdi from İlaclar i join Receteler re on i.IlacID = re.İlacID where re.ReceteID =@id", conn);
            cmd.Parameters.AddWithValue("@id", receteID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                receteIlaclari.Add(new ReceteIlaclariDTO
                {
                    ReceteID = reader.GetInt32(0),
                    IlacID = reader.GetInt32(1),
                    IlacAdi = reader.GetString(2)
                });
            }

            reader.Close();
            return receteIlaclari;
        }

        void AddParametersToCommand(ReceteEntities recete)
        {
            cmd.Parameters.AddWithValue("@ilacID", recete.IlacID);
            cmd.Parameters.AddWithValue("@randevuID", recete.RandevuID);
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
