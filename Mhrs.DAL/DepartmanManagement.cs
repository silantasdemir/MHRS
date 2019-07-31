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
    public class DepartmanManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public DepartmanManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }


        public int Add(DepartmanEntities departman)
        {
            cmd = new SqlCommand("INSERT INTO Departmanlar VALUES (@dAd)", conn);
            cmd.Parameters.AddWithValue("@dAd", departman.DepartmanAdi);
            return ExecuteCommand();
        }

        public int Update(DepartmanEntities departman)
        {
            cmd = new SqlCommand("update Departmanlar SET IlacAdi=@dAd where DepartmanID=@departmanID", conn);
            cmd.Parameters.AddWithValue("@dAd", departman.DepartmanAdi);
            cmd.Parameters.AddWithValue("@departmanID", departman.DepartmanID);
            return ExecuteCommand();
        }

        public int Delete(int departmanID)
        {
            cmd = new SqlCommand("DELETE FROM Departmanlar WHERE DepartmanID=@id", conn);
            cmd.Parameters.AddWithValue("@id", departmanID);
            return ExecuteCommand();
        }

        public List<DepartmanEntities> GetAllDepartman()
        {
            List<DepartmanEntities> departmanList = new List<DepartmanEntities>();
            cmd = new SqlCommand("Select * From Departmanlar", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                departmanList.Add(new DepartmanEntities()
                {
                    DepartmanID = reader.GetInt32(0),
                    DepartmanAdi = reader.GetString(1)
                });
            }
            reader.Close();
            return departmanList;
        }

        public DepartmanEntities GetDepartmanById(int departmanID)
        {
            DepartmanEntities currentDepartman = new DepartmanEntities();
            cmd = new SqlCommand("Select * From Departmanlar Where DepartmanID = @id", conn);
            cmd.Parameters.AddWithValue("@id", departmanID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentDepartman.DepartmanID = reader.GetInt32(0);
            currentDepartman.DepartmanAdi = reader.GetString(1);
            reader.Close();
            return currentDepartman;
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
