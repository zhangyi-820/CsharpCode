using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderGUISystem
{
    public partial class addProductForm : Form
    {
        int orderId;
        DataGridView data;
        public addProductForm(int orderId,DataGridView data)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.data = data;
        }

        //添加商品
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                //根据输入的信息添加商品
                string name = this.productNameTextBox.Text;
                double price = Double.Parse(
                    this.priceTextBox.Text);
                int amount = Int32.Parse(
                    this.amountTextBox.Text);
                int productId = Int32.Parse(
                    this.productIdtextBox.Text);

                //调用数据库操作
                DBOperation.AddProduct(productId, price, amount, name, this.orderId);

                //刷新表格
                data.DataSource = DBOperation.GetProductData(this.orderId);
            }catch(FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
