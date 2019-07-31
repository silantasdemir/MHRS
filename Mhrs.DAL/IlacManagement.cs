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
    public class IlacManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public IlacManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }


        public int Add(IlacEntities ilac)
        {
            cmd = new SqlCommand("INSERT INTO İlaclar VALUES (@iAd)", conn);
            cmd.Parameters.AddWithValue("@iAd", ilac.IlacAdi);
            return ExecuteCommand();
        }

        public int Update(IlacEntities ilac)
        {
            cmd = new SqlCommand("update İlaclar SET IlacAdi=@iAd where IlacID=@ilacID", conn);
            cmd.Parameters.AddWithValue("@iAd", ilac.IlacAdi);
            cmd.Parameters.AddWithValue("@ilacID", ilac.IlacID);
            return ExecuteCommand();
        }

        public int Delete(int ilacID)
        {
            cmd = new SqlCommand("DELETE FROM İlaclar WHERE IlacID=@id", conn);
            cmd.Parameters.AddWithValue("@id", ilacID);
            return ExecuteCommand();
        }

        public List<IlacEntities> GetIlaclar()
        {
            List<IlacEntities> ilacList = new List<IlacEntities>();
            cmd = new SqlCommand("Select * From İlaclar", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                ilacList.Add(new IlacEntities()
                {
                    IlacID = reader.GetInt32(0),
                    IlacAdi = reader.GetString(1)
                });
            }
            reader.Close();
            return ilacList;
        }

        public IlacEntities GetIlacById(int ilacID)
        {
            IlacEntities currentIlac = new IlacEntities();
            cmd = new SqlCommand("Select * From İlaclar Where IlacID = @id", conn);
            cmd.Parameters.AddWithValue("@id", ilacID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentIlac.IlacID = reader.GetInt32(0);
            currentIlac.IlacAdi = reader.GetString(1);
            reader.Close();
            return currentIlac;
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
