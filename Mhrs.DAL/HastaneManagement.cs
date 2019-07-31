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
    public class HastaneManagement
    {
        SqlConnection conn;
        SqlCommand cmd;

        public HastaneManagement()
        {
            conn = new SqlConnection(Properties.Settings.Default.mhrs);
        }

        public int Add(HastanelerEntities hastane)
        {
            cmd = new SqlCommand("INSERT INTO Hastaneler VALUES (@hAd)", conn);
            cmd.Parameters.AddWithValue("@hAd", hastane.HastaneAdi);
            return ExecuteCommand();
        }

        public int Update(HastanelerEntities hastane)
        {
            cmd = new SqlCommand("update Hastaneler SET HastaneAdi=@hAd where HastaneID=@hastaneID", conn);
            cmd.Parameters.AddWithValue("@hAd", hastane.HastaneAdi);
            cmd.Parameters.AddWithValue("@hastaneID", hastane.HastaneID);
            return ExecuteCommand();
        }

        public int Delete(int hastaneID)
        {
            cmd = new SqlCommand("DELETE FROM Hastaneler WHERE HastaneID=@id", conn);
            cmd.Parameters.AddWithValue("@id", hastaneID);
            return ExecuteCommand();
        }

        public List<HastanelerEntities> GetAllHastane()
        {
            List<HastanelerEntities> hastaneList = new List<HastanelerEntities>();
            cmd = new SqlCommand("Select * From Hastaneler", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                hastaneList.Add(new HastanelerEntities()
                {
                    HastaneID = reader.GetInt32(0),
                    HastaneAdi = reader.GetString(1)
                });
            }
            reader.Close();
            return hastaneList;
        }

        public HastanelerEntities GetHastaneById(int hastaneID)
        {
            HastanelerEntities currentHastane = new HastanelerEntities();
            cmd = new SqlCommand("Select * From Hastaneler Where hastaneID = @id", conn);
            cmd.Parameters.AddWithValue("@id", hastaneID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            reader.Read();
            currentHastane.HastaneID = reader.GetInt32(0);
            currentHastane.HastaneAdi = reader.GetString(1);
            reader.Close();
            return currentHastane;
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
