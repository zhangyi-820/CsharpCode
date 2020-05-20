using OrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderGUISystem
{
    public partial class AddOrderForm : Form
    {

        private Order order;
        private DataGridView data;//首页的订单表

        public AddOrderForm(DataGridView data)
        {
            InitializeComponent();
            this.data = data;
        }

        //返回主界面
        private void backButton_Click(object sender, EventArgs e)
        {
            data.DataSource = DBOperation.GetOrderData();
            this.Close();
        }

        //创建订单
        private void createButton_Click(object sender, EventArgs e)
        {
            //调用数据库操作
            DBOperation.CreateOrder(this.recAddressTextBox.Text, this.recPersonTextBox.Text);
            DBOperation.OrderCount++;
            data.DataSource = DBOperation.GetOrderData();
        }

        //添加商品
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //调用数据库操作，添加商品
                DBOperation.AddProduct(
                    Int32.Parse(this.productIdTextBox.Text),
                    Double.Parse(this.productPriceTextBox.Text),
                    Int32.Parse(this.productAmountTextBox.Text),
                    this.productNameTextBox.Text,
                    DBOperation.OrderCount-1
                    );               
            }
            catch(FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
