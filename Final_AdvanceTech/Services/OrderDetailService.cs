using Final_AdvanceTech.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Services
{
    public class OrderDetailService
    {
        private string connectionString = "Data Source=LAPTOP-HK44U3IK;Initial Catalog=Resaurant_system;Integrated Security=True;TrustServerCertificate=True;";

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderid)
        {
            var orders = new List<OrderDetail>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"SELECT d.* FROM OrderDetails d,Orders o where d.OrderID = @Orderid and o.OrderID = @Orderid and o.Status != N'Đã thanh toán'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Orderid", orderid);
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var orderdetail = new OrderDetail();
                                orderdetail.OrderDetailID = Convert.ToInt32(dataReader["OrderDetailID"]);
                                orderdetail.OrderID = Convert.ToInt32(dataReader["OrderID"]);
                                orderdetail.MenuItemID = Convert.ToInt32(dataReader["MenuItemID"]);
                                orderdetail.quantity = Convert.ToInt32(dataReader["quantity"]);
                                orderdetail.note = Convert.ToString(dataReader["note"]);
                                orders.Add(orderdetail);
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
        public void addOrderDetails(List<OrderDetail> orderDetails)
        {   
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"INSERT INTO OrderDetails(OrderID, MenuItemID, quantity,note) VALUES(@OrderID, @MenuItemID, @quantity,@note);";
                    foreach (var item in orderDetails)
                    {
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@OrderID", item.OrderID);
                            command.Parameters.AddWithValue("@MenuItemID", item.MenuItemID);
                            command.Parameters.AddWithValue("@quantity", item.quantity);
                            command.Parameters.AddWithValue("@note", item.note);

                            command.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("add Order Details");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
