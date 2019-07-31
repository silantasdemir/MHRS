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
    public class EczaciManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public EczaciManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }


        public int Add(EczaciEntities eczaci)
        {
            cmd = new SqlCommand("INSERT INTO Eczacilar VALUES (@ad,@soyad,@kAdi,@sifre)", conn);
            AddParametersToCommand(eczaci);
            return ExecuteCommand();
        }

        public int Update(EczaciEntities eczaci)
        {
            cmd = new SqlCommand("update Eczacilar SET Adi=@ad,Soyadi=@soyad,,KullaniciAdi=@kAdi,Sifre=@sifre where EczaciID=@eczaciID", conn);
            AddParametersToCommand(eczaci);
            cmd.Parameters.AddWithValue("@eczaciID", eczaci.EczaciID);
            return ExecuteCommand();
        }

        public int Delete(int eczaciID)
        {
            cmd = new SqlCommand("DELETE FROM Eczacilar WHERE EczaciID=@id", conn);
            cmd.Parameters.AddWithValue("@id", eczaciID);
            return ExecuteCommand();
        }

        public List<EczaciEntities> GetAllEczaci()
        {
            List<EczaciEntities> eczaciList = new List<EczaciEntities>();
            cmd = new SqlCommand("Select * From Eczacilar", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                eczaciList.Add(new EczaciEntities()
                {
                    EczaciID = reader.GetInt32(0),
                    Adi = reader.GetString(1),
                    Soyadi = reader.GetString(2),
                    KullaniciAdi = reader.GetString(3),
                    Sifre = reader.GetString(4)
                });
            }
            reader.Close();
            return eczaciList;
        }

        public EczaciEntities GetEczaciById(int eczaciID)
        {
            EczaciEntities currentEczaci = new EczaciEntities();
            cmd = new SqlCommand("Select * From Eczacilar Where EczaciID = @id", conn);
            cmd.Parameters.AddWithValue("@id", eczaciID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentEczaci.EczaciID = reader.GetInt32(0);
            currentEczaci.Adi = reader.GetString(1);
            currentEczaci.Soyadi = reader.GetString(2);
            currentEczaci.KullaniciAdi = reader.GetString(3);
            currentEczaci.Sifre = reader.GetString(4);
            reader.Close();
            return currentEczaci;
        }




        void AddParametersToCommand(EczaciEntities  eczaci)
        {
            cmd.Parameters.AddWithValue("@ad", eczaci.Adi);
            cmd.Parameters.AddWithValue("@soyad", eczaci.Soyadi);
            cmd.Parameters.AddWithValue("@kAdi", eczaci.KullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", eczaci.Sifre);
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
