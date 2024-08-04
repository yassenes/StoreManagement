using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreManagement
{
    public class SqlHandle
    {
        private string _sqlConnectionString;

        public SqlHandle(string connectionString)
        {
            _sqlConnectionString = connectionString;
        }

        public void Add(string name, string price, string quantity)
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO _Items VALUES (@Name, @Price, @Quantity, GETDATE()); INSERT INTO _History VALUES (@Name, @Price, @Quantity, 'اضافة', GETDATE())", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    command.ExecuteNonQuery();

                    LoadItems();
                    LoadHistory();
                    ItemCount();
                }
            }
        }

        public void RemoveItem(string no , string name, string price, string quantity)
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM _Items WHERE No = @No;	INSERT INTO _History VALUES (@Name, @Price, @Quantity, 'مسح', GETDATE())", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@No", no);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);


                    command.ExecuteNonQuery();

                    LoadItems();
                    LoadHistory();

                    MessageBox.Show("تم مسح الايتم بنجاح: [" + no + "]", "اعلام", MessageBoxButtons.OK);
                }
            }
        }

        public int ChangeQuantity(string no, string name, string price, string quantity)
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE _Items SET Quantity = @Quantity WHERE No = @No; INSERT INTO _History VALUES (@Name, @Price, @Quantity, 'كمية', GETDATE())", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@No", no);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    command.ExecuteNonQuery();

                    LoadItems();
                    LoadHistory();
                    ItemCount();

                    return 1;
                }
            }
        }

        public int UpdateName(string no, string name, string price, string quantity)
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE _Items SET Name = @Name WHERE No = @No; INSERT INTO _History VALUES (@Name, @Price, @Quantity, 'الاسم', GETDATE())", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@No", no);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    command.ExecuteNonQuery();

                    LoadItems();
                    LoadHistory();
                    ItemCount();

                    return 1;
                }
            }
        }

        public int UpdatePrice(string no, string name, string price, string quantity)
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE _Items SET Price = @Price WHERE No = @No; INSERT INTO _History VALUES (@Name, @Price, @Quantity, 'سعر', GETDATE())", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@No", no);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    command.ExecuteNonQuery();

                    LoadItems();
                    LoadHistory();
                    ItemCount();

                    return 1;
                }
            }
        }

        public void LoadItems()
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT No, Name, Price, Quantity, EventTime FROM _Items", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    Main.listView1.Items.Clear();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string no = Convert.ToString(sqlDataReader["No"]);
                            string name = Convert.ToString(sqlDataReader["Name"]);
                            string price = Convert.ToString(sqlDataReader["Price"]);
                            string quantity = Convert.ToString(sqlDataReader["Quantity"]);
                            string date = Convert.ToString(sqlDataReader["EventTime"]);

                            string[] row = { name, price, quantity,date };

                            Main.listView1.Items.Add(no).SubItems.AddRange(row);
                        }
                    }
                }
            }
        }

        public void LoadHistory()
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Type, Name, Price, Quantity, EventTime FROM _History ORDER BY EventTime ASC", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    Main.listView2.Items.Clear();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string no = Convert.ToString(sqlDataReader["Type"]);
                            string name = Convert.ToString(sqlDataReader["Name"]);
                            string price = Convert.ToString(sqlDataReader["Price"]);
                            string quantity = Convert.ToString(sqlDataReader["Quantity"]);
                            string date = Convert.ToString(sqlDataReader["EventTime"]);

                            string[] row = { name, price, quantity, date };

                            Main.listView2.Items.Add(no).SubItems.AddRange(row);
                        }
                    }
                }
            }
        }

        public void ItemCount()
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT ISNULL(SUM(Quantity), 0) as ItemsCount FROM _Items", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string no = Convert.ToString(sqlDataReader["ItemsCount"]);

                            Main.label2.Text = no;
                        }
                    }
                }
            }
        }

        public void SoldCount()
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT ISNULL(SUM(Quantity), 0) as ItemsCount, ISNULL(SUM(Price),0) as SoldCount FROM _Sold", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string no = Convert.ToString(sqlDataReader["ItemsCount"]);
                            string nosd = Convert.ToString(sqlDataReader["SoldCount"]);

                            Main.label4.Text = no;
                            Main.label6.Text = nosd;
                        }
                    }
                }
            }
        }

        public void LoadSold()
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT No, Name, Price, Quantity, EventTime FROM _Sold  ORDER BY EventTime ASC", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    Main.lVSold.Items.Clear();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            string no = Convert.ToString(sqlDataReader["No"]);
                            string name = Convert.ToString(sqlDataReader["Name"]);
                            string price = Convert.ToString(sqlDataReader["Price"]);
                            string quantity = Convert.ToString(sqlDataReader["Quantity"]);
                            string date = Convert.ToString(sqlDataReader["EventTime"]);

                            string[] row = { name, price, quantity, date };


                            Main.lVSold.Items.Add(no).SubItems.AddRange(row);
                        }
                    }
                }
            }
        }

        public int ItemSold(string no, string name, string price, string quantity, string oprice)
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("EXEC _Item_Sold @No, @Name, @Price, @Quantity", connection)
                {
                    CommandType = CommandType.Text
                })
                {
                    command.Parameters.AddWithValue("@No", no);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        if (sqlDataReader.Read())
                        {
                            string error = Convert.ToString(sqlDataReader["Error"]);
                            if (error == "1")
                                MessageBox.Show("الكمية اكبر من الموجود حاليا! برجاء تصحيح الكمية او زيدتها اولا", "بيع ايتم", MessageBoxButtons.OK);
                            else
                            {
                                LoadItems();
                                LoadSold();
                                LoadHistory();
                                ItemCount();
                                SoldCount();
                                return 1;
                            }
                        }
                    }
                    return 0;
                }
            }
        }
    }
}
