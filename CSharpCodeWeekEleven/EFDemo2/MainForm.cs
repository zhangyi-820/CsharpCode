using MySql.Data.MySqlClient;
using OrderSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OrderGUISystem
{
    //主界面类
    public partial class MainForm : Form
    {
        Form createOrderForm;//创建新订单窗口
        Form alterForm;//修改订单信息窗口
       
        public MainForm()
        {
            InitializeComponent();

            //创建订单管理对象，并且绑定数据
            this.orderDataGridView.DataSource = DBOperation.GetOrderData();
            this.orderDataGridView.DataMember = "orders";
            
            //设置表格属性为只读，防止数据错误
            this.orderDataGridView.ReadOnly = true;
            this.productDataGridView.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //创建新订单
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            this.createOrderForm = new AddOrderForm(this.orderDataGridView);
            createOrderForm.Show();
        }

        //备份数据库
        private void exportButton_Click(object sender, EventArgs e)
        {
            //调用数据库操作
            DBOperation.ExportToSql();
        }

        //还原数据库
        private void importButton_Click(object sender, EventArgs e)
        {
            //调用数据库操作并更新表格
            DBOperation.ImportFromSql();
            this.orderDataGridView.DataSource = DBOperation.GetOrderData();
        }

        //根据选择的条件查询订单信息
        private void inquireButton_Click(object sender, EventArgs e)
        {
            try
            {
                //根据条件选择框的信息选择查询方式
                switch (conditionComboBox.SelectedIndex)
                {
                    //根据收货人查询
                    case 0:
                        this.orderDataGridView.DataSource =
                            DBOperation.QueryOrderByRecPerson(conditionTextBox.Text);
                        break;
                    //根据货物名查询
                    case 1:
                        this.orderDataGridView.DataSource =
                            DBOperation.QueryOrderByProductName(conditionTextBox.Text);
                        break;
                    //根据订单号查询
                    case 2:
                        this.orderDataGridView.DataSource =
                            DBOperation.QueryOrderByOrderId(
                                Int32.Parse(conditionTextBox.Text
                                ));
                        break;
                    default:
                        break;

                }
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        //查询结果后返回或者刷新表格
        private void backButton_Click(object sender, EventArgs e)
        {
            this.orderDataGridView.DataSource = DBOperation.GetOrderData();
        }

        //删除某个选中的订单项
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //获取选中的订单的订单号
                int row = this.orderDataGridView.CurrentRow.Index;
                int orderId = Int32.Parse(
                    this.orderDataGridView.Rows[row].Cells[0].Value.ToString()
                    );

                //调用数据库操作
                DBOperation.DeleteOrder(orderId);

                //刷新表格
                this.orderDataGridView.DataSource = DBOperation.GetOrderData();
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        //修改选中的订单信息
        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //获取选中的订单的订单号、收货人、收货地址信息
                int row = this.orderDataGridView.CurrentRow.Index;
                int orderId = Int32.Parse(
                    this.orderDataGridView.Rows[row].Cells[0].Value.ToString()
                    );
                string recP = this.orderDataGridView.Rows[row].Cells[2].Value.ToString();
                string recA = this.orderDataGridView.Rows[row].Cells[1].Value.ToString();

                //进入修改页面
                alterForm = new alterForm(orderId, recP, recA);
                alterForm.Show();
            }catch(FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
            
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //获取选中的订单的订单号
                int row = this.orderDataGridView.CurrentRow.Index;
                int orderId = Int32.Parse(
                    this.orderDataGridView.Rows[row].Cells[0].Value.ToString()
                    );

                //调用数据库操作
                this.productDataGridView.DataSource=DBOperation.GetProductData(orderId);
                this.productDataGridView.DataMember = "products";
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
