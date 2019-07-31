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
    public class RandevuManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public RandevuManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }

        public RandevuEntities GetRandevu(int randevuID)
        {
            cmd = new SqlCommand("select * from Randevular where RandevuID=@id", conn);
            cmd.Parameters.AddWithValue("@id", randevuID);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            RandevuEntities randevu = new RandevuEntities();
            if (read.Read())
            {
                randevu.RandevuID = read.GetInt32(0);
                randevu.HastaID = read.GetInt32(1);
                randevu.DoktorID = read.GetInt32(2);
                randevu.PoliklinikID = read.GetInt32(3);
                randevu.RandevuTarihi = read.GetDateTime(4);
                randevu.Durum = read.GetBoolean(5);
            }

            conn.Close();
            return randevu;
        }

        public List<RandevuDTO> RandevulariGetir()//Birçok tablodan veri döndereceğin zaman DTO(DATA TRANSFER OBJECT(Bilgi Transfer nesne)) class oluştur ortak olan kolon isimlerini yaz.RandevuDTO class'ı gibi.SQL deki View gibi düşün.MVC'deki adi partial View'mış
        {
            List<RandevuDTO> randevular = new List<RandevuDTO>();
            cmd = new SqlCommand(@"select  h.HastaID,h.Adi,d.Adi,p.PoliklinikAdi,dep.DepartmanAdi,RandevuTarihi
                        from Randevular r join Hastalar h
                        on r.HastaID=h.HastaID
                        join Doktorlar d
                        on r.DoktorID=d.DoktorID
                        join Poliklinikler p
                        on r.PoliklinikID=p.PoliklinikID
                        join Departmanlar dep
                        on dep.DepartmanID=d.DepartmanID", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rd.Read())
            {
                randevular.Add(new RandevuDTO
                {
                    HastaID = (int)rd["HastaID"],
                    HastaAdi = rd["h.Adi"].ToString(),
                    DoktorAdi = rd["d.Adi"].ToString(),
                    DepartmanAdi = rd["DepartmanAdi"].ToString(),
                    PoliklinikAdi = rd["PoliklinikAdi"].ToString(),
                    RandevuTarihi = (DateTime)rd["RandevuTarihi"]
                });
            }
            rd.Close();
            return randevular;
        }

        public DepRandevuDTO DoktorHastanesiPoliklinigi(int drID, DateTime tarih)
        {
            DepRandevuDTO hastpol = new DepRandevuDTO();
            cmd = new SqlCommand(@"select PoliklinikAdi, HastaneAdi 
                                    from DoktorCalismaTakvimi dct join Poliklinikler p
                                    on dct.PoliklinikID=p.PoliklinikID
                                    join PoliklinikDepartmanlari pd
                                    on dct.PoliklinikID=p.PoliklinikID
                                    join Hastaneler h
                                    on h.HastaneID=p.HastaneID
                                    where dct.DoktorID=@did and Gun=@tarih and Durum=0
                                    group by PoliklinikAdi, HastaneAdi", conn);//Bu sorguya "Durum=0" sonradan ekledim istenilen tarihde durum kısmı 0 olan varsa hastane adı ve pol adi getirecek null gelirse dr'nin boş randevusu yoktur demek
            cmd.Parameters.AddWithValue("@did", drID);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (rd.HasRows)
            {
                rd.Read();
                hastpol.HastaneAdi = rd["HastaneAdi"].ToString();
                hastpol.PoliklinikAdi = rd["PoliklinikAdi"].ToString();
            }
            rd.Close();
            return hastpol;
        }

        public List<RandevuHastaDTO> GetAllRandevular(int drID, string tarih)
        {
            List<RandevuHastaDTO> randevus = new List<RandevuHastaDTO>();
            cmd = new SqlCommand(@"select RandevuID,Hastalar.Adi+' '+Hastalar.Soyadi as FullAd,convert(varchar,RandevuTarihi, 24) as Seans,Durum from Randevular join Hastalar on Randevular.HastaID=Hastalar.HastaID where DoktorID=@drID and CONVERT(nvarchar(20),RandevuTarihi,23)=@tarih order by Seans", conn);

            cmd.Parameters.AddWithValue("@drID", drID);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (read.Read())
            {
                randevus.Add(new RandevuHastaDTO
                {
                    RandevuID = read.GetInt32(0),
                    HastaFullAd = read.GetString(1),
                    Seans = read.GetString(2),
                    Durum = read.GetBoolean(3)
                });
            }
            read.Close();
            return randevus;
        }

        public bool RandevuEkle(DCTDTO randevu, int hastaID)
        {
            cmd = new SqlCommand("insert into Randevular values(@hid,@did,@pid,@rtarihi,@durum)", conn);
            cmd.Parameters.AddWithValue("@hid", hastaID);
            cmd.Parameters.AddWithValue("@did", randevu.DoktorID);
            cmd.Parameters.AddWithValue("@pid", randevu.PoliklinikID);
            cmd.Parameters.AddWithValue("@rtarihi", randevu.Gun);
            cmd.Parameters.AddWithValue("@durum", randevu.Durum);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool RandevuEkle(RandevuEntities randevu)
        {
            cmd = new SqlCommand("insert into Randevular values(@hid,@did,@pid,@rtarihi,@durum)", conn);
            cmd.Parameters.AddWithValue("@hid", randevu.HastaID);
            cmd.Parameters.AddWithValue("@did", randevu.DoktorID);
            cmd.Parameters.AddWithValue("@pid", randevu.PoliklinikID);
            cmd.Parameters.AddWithValue("@rtarihi", randevu.RandevuTarihi);
            cmd.Parameters.AddWithValue("@durum", randevu.Durum);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool RandevuSil(int randevuID)
        {
            cmd = new SqlCommand("Delete From Randevular Where RandevuID=@rid", conn);
            cmd.Parameters.AddWithValue("@rid", randevuID);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool RandevuGuncelle(int randevuID)
        {
            cmd = new SqlCommand("update Randevular SET Durum=0 where RandevuID=@id", conn);
            cmd.Parameters.AddWithValue("@id", randevuID);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public List<RandevuDTO> GuncelRandevular(bool durum)
        {
            List<RandevuDTO> randevular = new List<RandevuDTO>();
            cmd = new SqlCommand(@"select hn.HastaneAdi,p.PoliklinikAdi,dep.DepartmanAdi,d.Adi,RandevuTarihi,r.RandevuID
                        from Randevular r join Hastalar h
                        on r.HastaID=h.HastaID
                        join Doktorlar d
                        on r.DoktorID=d.DoktorID
                        join Poliklinikler p
                        on r.PoliklinikID=p.PoliklinikID
                        join Departmanlar dep
                        on dep.DepartmanID=d.DepartmanID 
                        join Hastaneler hn
                        on hn.HastaneID=p.HastaneID
                        where r.Durum=@durum and r.RandevuTarihi>GETDATE()", conn);
            cmd.Parameters.AddWithValue("@durum", durum);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rd.Read())
            {
                randevular.Add(new RandevuDTO
                {

                    //HastaAdi = rd.GetString(0),
                    HastaneAdi = rd.GetString(0),
                    PoliklinikAdi = rd.GetString(1),
                    DepartmanAdi = rd.GetString(2),
                    DoktorAdi = rd.GetString(3),
                    RandevuTarihi = rd.GetDateTime(4),
                    RandevuID = rd.GetInt32(5)
                });
            }
            rd.Close();
            return randevular;
        }

        public List<RandevuDTO> GecmisRandevular()
        {
            List<RandevuDTO> randevular = new List<RandevuDTO>();
            cmd = new SqlCommand(@"select hn.HastaneAdi,p.PoliklinikAdi,dep.DepartmanAdi,d.Adi,RandevuTarihi,r.RandevuID
                        from Randevular r join Hastalar h
                        on r.HastaID=h.HastaID
                        join Doktorlar d
                        on r.DoktorID=d.DoktorID
                        join Poliklinikler p
                        on r.PoliklinikID=p.PoliklinikID
                        join Departmanlar dep
                        on dep.DepartmanID=d.DepartmanID 
                        join Hastaneler hn
                        on hn.HastaneID=p.HastaneID
                        where r.RandevuTarihi<GETDATE()", conn);

            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rd.Read())
            {
                randevular.Add(new RandevuDTO
                {

                    //HastaAdi = rd.GetString(0),
                    HastaneAdi = rd.GetString(0),
                    PoliklinikAdi = rd.GetString(1),
                    DepartmanAdi = rd.GetString(2),
                    DoktorAdi = rd.GetString(3),
                    RandevuTarihi = rd.GetDateTime(4),
                    RandevuID = rd.GetInt32(5)
                });
            }
            rd.Close();
            return randevular;
        }
    }
}
