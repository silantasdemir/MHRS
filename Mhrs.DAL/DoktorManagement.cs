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
    public class DoktorManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        public DoktorManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }
        public int EkleDoktor(DoktorEntities doktor)
        {
          
            cmd = new SqlCommand("INSERT INTO Doktorlar VALUES(@Adi, @Soyadi, @Cinsiyet,@HastaneID,@DepartmanID,@Kullaniciadi,@Sifre)", conn);
            AddParametersToCommand(doktor);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        void AddParametersToCommand(DoktorEntities doktor)
        {
            //cmd.Parameters.AddWithValue("@DoktorID", doktor.DoktorID);
            cmd.Parameters.AddWithValue("@Adi", doktor.Adi);
            cmd.Parameters.AddWithValue("@Soyadi", doktor.Soyadi);
            cmd.Parameters.AddWithValue("@Cinsiyet", doktor.Cinsiyet);
            cmd.Parameters.AddWithValue("@HastaneID", doktor.HastaneID);
            cmd.Parameters.AddWithValue("@DepartmanID", doktor.DepartmanID);
            cmd.Parameters.AddWithValue("@Kullaniciadi", doktor.KullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", doktor.Sifre);
        }
        public int Guncelle(DoktorEntities doktor)
        {
           
            cmd = new SqlCommand("Update Doktorlar set adi=@adi,soyadi=@soyadi where DoktorID=@did)", conn);
            AddParametersToCommand(doktor);
            cmd.Parameters.AddWithValue("@did", doktor.DoktorID);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public List<DoktorEntities> TumDoktorlariGetir()
        {
            List<DoktorEntities> DoktorList = new List<DoktorEntities>();
            cmd = new SqlCommand("Select * From Doktorlar", conn);
            DoktorEntities currentUser = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser = new DoktorEntities()
                {
                    DoktorID = reader.GetInt32(0),
                    Adi = reader.GetString(1),
                    Soyadi = reader.GetString(2),
                    Cinsiyet = reader.GetBoolean(3),
                    HastaneID=reader.GetInt32(4),
                    DepartmanID=reader.GetInt32(5),
                    KullaniciAdi=reader.GetString(6),
                    Sifre=reader.GetString(7)
                     
                };
                DoktorList.Add(currentUser);
            }
            reader.Close();
            return DoktorList;

        }
        public DoktorEntities DoktorIDyeGore(int doktorID)
        {
            DoktorEntities currentUser = new DoktorEntities();
            cmd = new SqlCommand("Select * From Doktorlar Where DoktorID = @id", conn);
            cmd.Parameters.AddWithValue("@id", doktorID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentUser.DoktorID = reader.GetInt32(0);
            currentUser.Adi = reader.GetString(1);
            currentUser.Soyadi = reader.GetString(2);
            currentUser.Cinsiyet = reader.GetBoolean(3);
            currentUser.HastaneID = reader.GetInt32(4);
            currentUser.DepartmanID = reader.GetInt32(5);
            currentUser.KullaniciAdi = reader.GetString(6);
            currentUser.Sifre = reader.GetString(7);

            reader.Close();
            return currentUser;

        }
        public List<DoktorEntities> HastaneIDyeGore(int hastaneID)
        {
            List<DoktorEntities> currentUser = new List<DoktorEntities>();
            cmd = new SqlCommand("Select * From Doktorlar Where HastaneID = @id", conn);
            cmd.Parameters.AddWithValue("@id", hastaneID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser.Add(new DoktorEntities { 
                DoktorID = reader.GetInt32(0),
                Adi = reader.GetString(1),
                Soyadi = reader.GetString(2),
                Cinsiyet = reader.GetBoolean(3),
                HastaneID = reader.GetInt32(4),
                DepartmanID = reader.GetInt32(5),
                KullaniciAdi = reader.GetString(6),
                Sifre = reader.GetString(7),
            });
            }
            reader.Close();
            return currentUser;

        }
        public List<DoktorEntities> DepartmanIDyeGore(int departmanID)
        {
            List<DoktorEntities> currentUser = new List<DoktorEntities>();
            cmd = new SqlCommand("Select * From Doktorlar Where DepartmanID = @id", conn);
            cmd.Parameters.AddWithValue("@id", departmanID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser.Add(new DoktorEntities
                {
                    DoktorID = reader.GetInt32(0),
                    Adi = reader.GetString(1),
                    Soyadi = reader.GetString(2),
                    Cinsiyet = reader.GetBoolean(3),
                    HastaneID = reader.GetInt32(4),
                    DepartmanID = reader.GetInt32(5),
                    KullaniciAdi = reader.GetString(6),
                    Sifre = reader.GetString(7),
                });
            }

            reader.Close();
            return currentUser;

        }

    }
}
