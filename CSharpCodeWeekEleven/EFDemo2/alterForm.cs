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
    public partial class alterForm : Form
    {
        private int orderId;
        string recPerson, recAddress;
        Form addProductForm;
        public alterForm(int orderId,string recPerson,string recAddress)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.RecPersonTextBox.Text =this.recPerson= recPerson;
            this.RecAddressTextBox.Text=this.recAddress = recAddress;

            //设置表格属性
            this.productBindingSource_1.DataSource = DBOperation.GetProductData(orderId);
            this.productDataGridView.DataSource = this.productBindingSource_1;
            this.productDataGridView.DataMember = "products";

            //除了商品数量列外均设置为只读
            this.productDataGridView.Columns[0].ReadOnly = true;
            this.productDataGridView.Columns[1].ReadOnly = true;
            this.productDataGridView.Columns[3].ReadOnly = true;
            this.productDataGridView.Columns[4].ReadOnly = true;
            this.productDataGridView.Columns[5].ReadOnly = true;
            
        }

        private void alterForm_Load(object sender, EventArgs e)
        {

        }

        //添加商品页面
        private void addProductButton_Click(object sender, EventArgs e)
        {
            addProductForm = new addProductForm(this.orderId,this.productDataGridView);
            addProductForm.Show();
        }

        //修改某个商品信息页面
        private void alterProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                //获取将要修改的商品信息
                int row = this.productDataGridView.CurrentRow.Index;
                int productId = Int32.Parse(
                    this.productDataGridView.Rows[row].Cells[0].Value.ToString()
                    );
                int amount = Int32.Parse(
                    this.productDataGridView.Rows[row].Cells[2].Value.ToString()
                    );
                int price = Int32.Parse(
                    this.productDataGridView.Rows[row].Cells[1].Value.ToString()
                    );

                //调用数据库操作
                DBOperation.UpdateProductAmount(this.orderId, productId, amount, price);

                //更新表格
                this.productDataGridView.DataSource = DBOperation.GetProductData(orderId);
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        //删除选中的商品
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                //获取选中的商品的信息
                int row = this.productDataGridView.CurrentRow.Index;
                int productId = Int32.Parse(
                    this.productDataGridView.Rows[row].Cells[0].Value.ToString()
                    );

                //调用数据库操作删除商品
                DBOperation.DeleteProduct(orderId, productId);

                //刷新表格
                this.productDataGridView.DataSource = DBOperation.GetProductData(this.orderId);
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        //修改订单的收货人以及收货地址
        private void alterButton_Click(object sender, EventArgs e)
        {
            //仅当发生变化时修改
            if (this.RecAddressTextBox.Text != recAddress)
            {
                DBOperation.UpdateOrderRecAddress(this.RecAddressTextBox.Text, this.orderId);

            }
            if(this.RecPersonTextBox.Text != recPerson)
            {
                DBOperation.UpdateOrderRecPerson(this.RecPersonTextBox.Text, this.orderId);
                return;
            }
            MessageBox.Show("未修改","",MessageBoxButtons.OK);
        }
    }
}
