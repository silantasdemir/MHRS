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
    public class DoktorCalismaTakvimiManagement
    {
        SqlConnection conn;
        public DoktorCalismaTakvimiManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }
        SqlCommand cmd;
        public List<DCTDTO> CalismaTakvimiGetir(int drID)
        {
            List<DCTDTO> calismaTakvim = new List<DCTDTO>();
            cmd = new SqlCommand(@"select d.DoktorID,d.Adi,p.PoliklinikID,p.PoliklinikAdi,Gun,Durum,Saat
                from DoktorCalismaTakvimi dct join Doktorlar d
                on dct.DoktorID=d.DoktorID
                join Poliklinikler p
                on dct.PoliklinikID=p.PoliklinikID
				where dct.DoktorID=@did", conn);
            cmd.Parameters.AddWithValue("@did", drID);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (rd.Read())
            {
                calismaTakvim.Add(new DCTDTO
                {
                    DoktorID = (int)rd["DoktorID"],
                    DoktorAdi = rd["Adi"].ToString(),
                    PoliklinikID = (int)rd["PoliklinikID"],
                    PoliklinikAdi = rd["PoliklinikAdi"].ToString(),
                    Durum = rd["Durum"].ToString(),
                    Gun = rd["Gun"].ToString(),
                    Saat = rd["Saat"].ToString()
                });
            }
            rd.Close();
            return calismaTakvim;
        }

        public List<DCTEntities> CalismaTakvimiGetir(RandevuEntities randevu, string tarih)
        {
            List<DCTEntities> calismaTakvim = new List<DCTEntities>();
            cmd = new SqlCommand(@"select * from DoktorCalismaTakvimi where DoktorID=@drID and PoliklinikID=@PolID and Durum=0 and CONVERT(nvarchar(20),Gun,23)=@tarih order by Saat", conn);

            cmd.Parameters.AddWithValue("@drID", randevu.DoktorID);
            cmd.Parameters.AddWithValue("@PolID", randevu.PoliklinikID);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (read.Read())
            {
                calismaTakvim.Add(new DCTEntities
                {
                    DoktorID = read.GetInt32(0),
                    PoliklinikID = read.GetInt32(1),
                    Gun = read.GetDateTime(2),
                    Durum = read.GetBoolean(3),
                    Saat = read.GetString(4)
                });
            }
            read.Close();
            return calismaTakvim;
        }

        public bool SeansAl(DCTDTO dCTDTO)//Bu tabloya ID eklensin
        {
            cmd = new SqlCommand("update DoktorCalismaTakvimi SET Durum=@durum where DoktorID=@did and Saat=@saat and Gun=@gun ", conn);
            cmd.Parameters.AddWithValue("@durum", dCTDTO.Durum);
            cmd.Parameters.AddWithValue("@did", dCTDTO.DoktorID);
            cmd.Parameters.AddWithValue("@saat", dCTDTO.Saat);
            cmd.Parameters.AddWithValue("@gun", dCTDTO.Gun);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool CalismaTakvimiGuncelle(DCTEntities dct)
        {
            cmd = new SqlCommand("update DoktorCalismaTakvimi SET Durum=1 where DoktorID=@did and PoliklinikID=@pID and Gun=@gun and Saat=@saat", conn);
            cmd.Parameters.AddWithValue("@durum", dct.Durum);
            cmd.Parameters.AddWithValue("@did", dct.DoktorID);
            cmd.Parameters.AddWithValue("@pID", dct.PoliklinikID);
            cmd.Parameters.AddWithValue("@saat", dct.Saat);
            cmd.Parameters.AddWithValue("@gun", dct.Gun);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public void DCTSeansGuncelle(string doktorAdi, string saat)
        {
            cmd = new SqlCommand("update DoktorCalismaTakvimi set Durum=0 where DoktorID=(select DoktorID from Doktorlar where Adi=@doktorAdi) and Saat=@saat", conn);
            cmd.Parameters.AddWithValue("@doktorAdi", doktorAdi);
            cmd.Parameters.AddWithValue("@saat", saat);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
