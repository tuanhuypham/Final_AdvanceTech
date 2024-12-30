using Final_AdvanceTech.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Services
{
    public class TablesService
    {
        private string connectionString = "Data Source=LAPTOP-HK44U3IK;Initial Catalog=Resaurant_system;Integrated Security=True;TrustServerCertificate=True;";

        public Tables GetTableByTableNumber(int tablenumber)
        {
            var table = new Tables();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Tables where TableNumber = " + tablenumber;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                table.TableID = Convert.ToInt32(dataReader["TableID"]);
                                table.TableNumber = Convert.ToInt32(dataReader["TableNumber"]);
                                table.TableStatus = Convert.ToString(dataReader["Status"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return table;
        }

        public void updateTableStatus(int tablenumber,string status)
        {
            var table = new Tables();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Tables SET Status = @NewStatus WHERE TableNumber = " + tablenumber;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", status);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) updated. table status");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
