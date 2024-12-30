using Final_AdvanceTech.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_AdvanceTech.Services
{
    public class MenuService
    {
        private string connectionString = "Data Source=LAPTOP-95AQ4INV\\SQLEXPRESS;Initial Catalog=Resaurant_system;Integrated Security=True;";
        public List<Menus> GetMenus()
        {   
            var menu = new List<Menus>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Menu";
                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var menuItem = new Menus();
                                menuItem.MenuItemID = Convert.ToInt32(dataReader["MenuItemID"]);
                                menuItem.ItemName = Convert.ToString(dataReader["ItemName"]);
                                menuItem.Price = Convert.ToDecimal(dataReader["Price"]);
                                menuItem.Category = Convert.ToString(dataReader["Category"]);
                                menu.Add(menuItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return menu;
        }

        public Menus GetMenuById(int menuItemID)
        {
            var menu = new Menus();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Menu WHERE MenuItemID = "+ menuItemID;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                menu.MenuItemID = Convert.ToInt32(dataReader["MenuItemID"]);
                                menu.ItemName = Convert.ToString(dataReader["ItemName"]);
                                menu.Price = Convert.ToDecimal(dataReader["Price"]);
                                menu.Category = Convert.ToString(dataReader["Category"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return menu;
        }
    }
}
