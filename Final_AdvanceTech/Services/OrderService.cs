using Final_AdvanceTech.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_AdvanceTech.Services
{
    public class OrderService
    {
        private string connectionString = "Data Source=LAPTOP-HK44U3IK;Initial Catalog=Resaurant_system;Integrated Security=True;TrustServerCertificate=True;";
        public int CreateOrder(Orders order)
        {
            int orderId = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"INSERT INTO Orders(TableID, OrderTime, Status) VALUES(@TableID, @OrderTime, @Status); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TableID", order.TableID);
                        command.Parameters.AddWithValue("@OrderTime", order.OrderTime);
                        command.Parameters.AddWithValue("@Status", order.Status);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            orderId = Convert.ToInt32(result);
                        }

                        Console.WriteLine($"Order created with ID: {orderId}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return orderId;
        }
        public Orders GetOrderByTableId(int tableid)
        {
            var order = new Orders();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"SELECT * FROM Orders where TableID = @TableID and Status != N'Đã thanh toán'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@TableID", tableid);
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {   
                            while (dataReader.Read())
                            {
                                order.OrderID = Convert.ToInt32(dataReader["OrderID"]);
                                order.TableID = Convert.ToInt32(dataReader["TableID"]);
                                order.OrderTime = Convert.ToDateTime(dataReader["OrderTime"]);
                                order.Status = Convert.ToString(dataReader["Status"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return order;
        }
        public Orders GetOrderById(int orderid)
        {
            var order = new Orders();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Orders where OrderID = " + orderid;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                order.OrderID = Convert.ToInt32(dataReader["OrderID"]);
                                order.TableID = Convert.ToInt32(dataReader["TableID"]);
                                order.OrderTime = Convert.ToDateTime(dataReader["OrderTime"]);
                                order.Status = Convert.ToString(dataReader["Status"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return order;
        }
        public List<Orders> GetOrders()
        {
            var orders = new List<Orders>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Orders";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var order = new Orders();
                                order.OrderID = Convert.ToInt32(dataReader["OrderID"]);
                                order.TableID = Convert.ToInt32(dataReader["TableID"]);
                                order.OrderTime = Convert.ToDateTime(dataReader["OrderTime"]);
                                order.Status = Convert.ToString(dataReader["Status"]);
                                orders.Add(order);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return orders;
        }

        public void updateOrderStatus(int Orderid, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Orders SET Status = @NewStatus WHERE OrderID = " + Orderid;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", status);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) updated. Orders status");
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
