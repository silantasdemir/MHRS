using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mhrs.DTO;
using Mhrs.Entities;

namespace Mhrs.DAL
{
    public class HastaManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public HastaManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }

        public int Add(HastaEntities hasta)
        {
            cmd = new SqlCommand("INSERT INTO Hastalar VALUES (@ad,@soyad,@cinsiyet,@mail,@sifre)", conn);
            AddParametersToCommand(hasta);
            return ExecuteCommand();
        }

        public int Update(HastaEntities hasta)
        {
            cmd = new SqlCommand("update Hastalar SET Adi=@ad,Soyadi=@soyad,Cinsiyet=@cinsiyet,Mail=@mail,Sifre=@sifre where HastaID=@hastaID", conn);
            AddParametersToCommand(hasta);
            cmd.Parameters.AddWithValue("@hastaID", hasta.HastaID);
            return ExecuteCommand();
        }

        public int Delete(int hastaID)
        {
            cmd = new SqlCommand("DELETE FROM Hastalar WHERE HastaID=@id", conn);
            cmd.Parameters.AddWithValue("@id", hastaID);
            return ExecuteCommand();
        }

        public List<HastaEntities> GetAllHasta()
        {
            List<HastaEntities> hastaList = new List<HastaEntities>();
            cmd = new SqlCommand("Select * From Hastalar", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                hastaList.Add(new HastaEntities()
                {
                    HastaID = reader.GetInt32(0),
                    Adi = reader.GetString(1),
                    Soyadi = reader.GetString(2),
                    Cinsiyet = reader.GetBoolean(3),
                    KullaniciAdi = reader.GetString(4),
                    Sifre = reader.GetString(5)
                });
            }
            reader.Close();
            return hastaList;
        }

        public HastaEntities GetHastaById(int hastaID)
        {
            HastaEntities currentHasta = new HastaEntities();
            cmd = new SqlCommand("Select * From Hastalar Where hastaID = @id", conn);
            cmd.Parameters.AddWithValue("@id", hastaID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                currentHasta.HastaID = reader.GetInt32(0);
                currentHasta.Adi = reader.GetString(1);
                currentHasta.Soyadi = reader.GetString(2);
                currentHasta.Cinsiyet = reader.GetBoolean(3);
                currentHasta.KullaniciAdi = reader.GetString(4);
                currentHasta.Sifre = reader.GetString(5);
            }
            reader.Close();
            return currentHasta;
        }

        void AddParametersToCommand(HastaEntities hasta)
        {
            cmd.Parameters.AddWithValue("@ad", hasta.Adi);
            cmd.Parameters.AddWithValue("@soyad", hasta.Soyadi);
            cmd.Parameters.AddWithValue("@cinsiyet", hasta.Cinsiyet);
            cmd.Parameters.AddWithValue("@mail", hasta.KullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", hasta.Sifre);
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
