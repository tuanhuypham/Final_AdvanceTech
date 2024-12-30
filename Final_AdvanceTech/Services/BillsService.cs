using Final_AdvanceTech.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Services
{
    public class BillsService
    {
        private string connectionString = "Data Source=LAPTOP-HK44U3IK;Initial Catalog=Resaurant_system;Integrated Security=True;TrustServerCertificate=True;";

        public int CreateBills(Bills bills)
        {
            int billid = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"INSERT INTO Bills(OrderID, TotalAmount,PaymentMethod,PaymentTime) VALUES(@OrderID, @TotalAmount,@PaymentMethod,@PaymentTime); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", bills.OrderID);
                        command.Parameters.AddWithValue("@TotalAmount", bills.TotalAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", bills.PaymentMethod);
                        command.Parameters.AddWithValue("@PaymentTime", bills.PaymentTime);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            billid = Convert.ToInt32(result);
                        }

                        Console.WriteLine($"Order created with ID: {billid}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return billid;
        }

        public List<Bills> GetBills()
        {
            var bills = new List<Bills>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Bills";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var menuItem = new Bills();
                                menuItem.BillId = Convert.ToInt32(dataReader["BillId"]);
                                menuItem.OrderID = Convert.ToInt32(dataReader["OrderID"]);
                                menuItem.TotalAmount = Convert.ToInt32(dataReader["TotalAmount"]);
                                menuItem.PaymentMethod = Convert.ToString(dataReader["PaymentMethod"]);
                                menuItem.PaymentTime = Convert.ToDateTime(dataReader["PaymentTime"]);
                                bills.Add(menuItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return bills;
        }

        public List<Bills> GetBillById(int orderid)
        {
            var bills = new List<Bills>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Bills where OrderID = "+ orderid;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var menuItem = new Bills();
                                menuItem.BillId = Convert.ToInt32(dataReader["BillId"]);
                                menuItem.OrderID = Convert.ToInt32(dataReader["OrderID"]);
                                menuItem.TotalAmount = Convert.ToInt32(dataReader["TotalAmount"]);
                                menuItem.PaymentMethod = Convert.ToString(dataReader["PaymentMethod"]);
                                menuItem.PaymentTime = Convert.ToDateTime(dataReader["PaymentTime"]);
                                bills.Add(menuItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return bills;
        }
    }
}
