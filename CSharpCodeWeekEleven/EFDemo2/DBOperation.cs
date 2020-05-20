using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderGUISystem
{
    //数据库操作
    public static class DBOperation
    {
        private static int orderCount;
        public static int OrderCount
        {
            get
            {
                return orderCount;
            }
            set
            {
                orderCount = value;
            }
        }
        //创建订单操作
        public static void CreateOrder(string recPerson,string recAddress)
        {
            using(MySqlConnection conn = GetConnection())
            {
                using(MySqlCommand cmd=new MySqlCommand("INSERT INTO orders " +
                    "VALUES(@OrderId,@RecPerson,@RecAddress,@Time,@Sum)",conn))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@OrderId", orderCount);                 
                    cmd.Parameters.AddWithValue("@RecPerson", recPerson);
                    cmd.Parameters.AddWithValue("@RecAddress", recAddress);
                    DateTime date = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Time", date.ToString());
                    cmd.Parameters.AddWithValue("@Sum", 0);
                    cmd.ExecuteNonQuery();
                }
                
            }
        }

        //添加商品操作
        public static void CreateProduct(int productId,double price,int amount,string name,int orderId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO products " +
                    "VALUES(@ProductId,@Price,@Amount,@Sum,@Name,@OrderId)", conn))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ProductId", productId);                  
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Sum", price * amount);
                    DateTime date = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Name",name );
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.ExecuteNonQuery();
                }
                string sql = "UPDATE orders SET Sum = " +
                    "(SELECT SUM(Sum) FROM products WHERE OrderId =" + orderId + ") " +
                    "WHERE OrderId=" + orderId + ";";
                using (MySqlCommand cmd =new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
        }

        //获取数据库连接
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "datasource=localhost;username=root;" +
                "password=0002;database=orderdb;charset=utf8");
            connection.Open();
            return connection;
        }

        //获得数据库中的orders表信息
        public static BindingSource GetOrderData()
        {
            BindingSource bs = new BindingSource();
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM orders order by OrderId asc;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "orders");
                    bs.DataSource = ds;
                    return bs;
                }
            }
        }

        //获得数据库中products表的信息
        public static BindingSource GetProductData(int orderId)
        {
            BindingSource bs = new BindingSource();
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM products WHERE OrderId=" + orderId + ";";
                using(MySqlCommand cmd=new MySqlCommand(sql, conn))
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "products");
                    bs.DataSource = ds;
                    return bs;
                }
            }
        }

        //添加商品操作
        public static void AddProduct(int productId,double price,int amount,string name,int orderId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO products(ProductId,Price,Amount,Sum,Name,OrderId)" +
                            " VALUES  (@ProductId,@Price,@Amount,@Sum,@Name,@OrderId);", conn);
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Sum", price * amount);
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.ExecuteNonQuery();
                }
                catch(MySqlException exception)
                {
                    MessageBox.Show(exception.Message, "错误", MessageBoxButtons.OK);
                }
            }
        }

        //根据订单号查询
        public static BindingSource QueryOrderByOrderId(int orderId)
        {
            BindingSource bs = new BindingSource();
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM orders WHERE OrderId=" + orderId + ";";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "orders");
                    bs.DataSource = ds;
                    return bs;
                }
            }
        }

        //根据收货人姓名查询
        public static  BindingSource QueryOrderByRecPerson(string RecPerson)
        {
            BindingSource bs = new BindingSource();
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM orders WHERE RecPerson='" + RecPerson + "';";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "orders");
                    bs.DataSource = ds;
                    return bs;
                }
            }
        }

        //根据商品名查询
        public static BindingSource QueryOrderByProductName(string name)
        {
            BindingSource bs = new BindingSource();
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM orders WHERE OrderId in " +
                    "(SELECT OrderId FROM products WHERE Name='" + name + "');";
                //string sql = "SELECT OrderId FROM products WHERE Name=" + name + ";";
                using(MySqlCommand cmd=new MySqlCommand(sql,conn))
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "orders");
                    bs.DataSource = ds;
                    return bs;
                }
            }
        }

        //删除订单操作
        public static void DeleteOrder(int orderId)
        {
            using (MySqlConnection conn=GetConnection())
            {
                string orderSql = "DELETE FROM orders WHERE OrderId=" + orderId + ";";
                string productSql = "DELETE FROM products WHERE OrderId=" + orderId + ";";
                MySqlCommand cmd = new MySqlCommand(orderSql, conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand(productSql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //删除商品操作
        public static void DeleteProduct(int orderId,int productId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "DELETE FROM products WHERE OrderId=" + orderId + 
                    " AND ProductId="+productId+";";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                    string sql_1 = "UPDATE orders SET Sum=(SELECT SUM(Sum) FROM products WHERE ProductId="+productId+")" +
                        "WHERE OrderId=" + orderId + ";";
                    using (MySqlCommand com = new MySqlCommand(sql_1, conn))
                    {
                        com.ExecuteNonQuery();
                    }
                }
                   
            }
        }

        //修改商品数量操作
        public static void UpdateProductAmount(int orderId,int productId,int amount,int price)
        {
            using(MySqlConnection conn = GetConnection())
            {

                string sql = "UPDATE products SET Amount=" + amount + ",Sum=" + amount * price + " WHERE ProductId="
                    + productId + " AND OrderId=" + orderId + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sql_1 = "UPDATE orders SET Sum=(SELECT SUM(Sum) " +
                    "FROM products WHERE OrderId=" + orderId + ")WHERE OrderId=" + orderId + ";";
                cmd = new MySqlCommand(sql_1, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //修改订单收货人姓名操作
        public static void UpdateOrderRecPerson(string recPerson,int orderId)
        {
            using(MySqlConnection conn=GetConnection())
            {
                string sql = "UPDATE orders SET RecPerson='" +
                    recPerson + "' WHERE OrderId=" + orderId + ";";
                MySqlCommand cmd=new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //修改订单收货地址操作
        public static void UpdateOrderRecAddress(string recAddress,int orderId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string sql = "UPDATE orders SET RecAddress='" +
                    recAddress + "' WHERE OrderId=" + orderId + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }

        //导出为本地sql文件操作
        public static void ExportToSql()
        {
            //调用mysqldump备份mysql数据库的语句
            string backupsql = string.Format("mysqldump --host={0}" +
                " --default-character-set=utf8 --lock-tables  --routines --force --port=3306 " +
                "--user={1} --password={2} --quick  ", "localhost", "root", "0002");
            //mysqldump的路径
            string mysqldump = @"C:\Program Files\MySQL\MySQL Server 8.0\bin";
            //需要备份的数据库名称
            string strDB = "orderdb";
            //备份数据库的路径
            //string strDBpath = @"C:\";

            //判断备份的数据库路径是否存在

            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            
            //备份数据库
            if (!string.IsNullOrEmpty(strDB))
            {
                string temp = path.SelectedPath;
                temp=temp.Replace("\\", "/");
                DateTime dateTime = DateTime.Now;
                string filePath = temp+dateTime.Year+dateTime.Month+dateTime.Day+dateTime.Hour+dateTime.Minute+strDB+".sql";
                string cmd = backupsql + strDB + " >" + filePath;
                string result = RunCmd(mysqldump, cmd);

                MessageBox.Show("数据库备份成功！", "提示");

            }
        }

        //根据本地sql文件恢复数据库操作
        public static void ImportFromSql()
        {
            //调用系统打开窗口控件选择文件路径
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //调用mysqldump备份mysql数据库的语句
                string backupsql = string.Format("mysql --host={0} --default-character-set=utf8  --port=3306 --user={1} --password={2} ",
                    "localhost", "root", "0002");
                //mysql的路径
                string mysqldump = @"C:\Program Files\MySQL\MySQL Server 8.0\bin";
                //需要备份的数据库名称
                string strDB = "orderdb";

                string filePath = ofd.FileName;
                MessageBox.Show(filePath, "当前选择的路径1");

                string cmd = backupsql + strDB + " < \"" + filePath + "\"";
                string result = RunCmd(mysqldump, cmd);

                MessageBox.Show("数据库恢复成功!", "MySQL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //执行批处理程序
        private static string RunCmd(string mysqldumPath, string strCmd)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = mysqldumPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(strCmd);
            p.StandardInput.WriteLine("exit");
            return p.StandardError.ReadToEnd();
        }

       
        /*
        private static void BakReductSql(string cmdText, bool isBak)
        {
            MySqlCommand cmdBakRst = new MySqlCommand();
            using(MySqlConnection conn = GetConnection())
            {
                try
                {
                    cmdBakRst.Connection = conn;
                    //cmdBakRst.Connection = conn;
                    cmdBakRst.CommandType = CommandType.Text;
                    if (!isBak)     //如果是恢复操作
                    {
                        string setOffline = "Alter database GroupMessage Set Offline With rollback immediate ";
                        string setOnline = " Alter database GroupMessage Set Online With Rollback immediate";
                        cmdBakRst.CommandText = setOffline + cmdText + setOnline;
                    }
                    else
                    {
                        cmdBakRst.CommandText = cmdText;
                    }
                    cmdBakRst.ExecuteNonQuery();
                    if (!isBak)
                    {
                        MessageBox.Show("恭喜你，数据成功恢复为所选文档的状态！", "系统消息");
                    }
                    else
                    {
                        MessageBox.Show("恭喜，你已经成功备份当前数据！", "系统消息");
                    }
                }
                catch (SqlException sexc)
                {
                    MessageBox.Show("失败，可能是对数据库操作失败，原因：" + sexc, "数据库错误消息");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("对不起，操作失败，可能原因：" + ex, "系统消息");
                }
                finally
                {
                    cmdBakRst.Dispose();
                    conn.Dispose();
                }
            }
            
        }*/
    }
}
