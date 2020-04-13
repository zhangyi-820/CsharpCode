using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWeekEight
{
    //主界面类
    public partial class mainForm : Form
    {
        Form createOrderForm;//创建新订单窗口
        Form addItemForm;//向订单中添加商品窗口
        OrderService orderService;//订单管理类

        public mainForm()
        {
            InitializeComponent();

            //创建订单管理对象，并且绑定数据
            orderService = new OrderService();
            this.orderBindingSource.DataSource = this.orderService.orderList;
            this.orderDataGridView.DataSource = orderBindingSource;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //创建新订单
        private void CreateButton_Click(object sender, EventArgs e)
        {
            createOrderForm = new addOrderForm(this.orderService,this.orderBindingSource);
            createOrderForm.Show();
        }

        //导入xml文件
        private void importButton_Click(object sender, EventArgs e)
        {
            List<Order> importOrder = new List<Order>();
            importOrder=(List<Order>)this.orderService.Import();
            orderService.AppendOrder(importOrder);
            this.orderBindingSource.ResetBindings(true);
        }

        //导出xml文件
        private void exportButton_Click(object sender, EventArgs e)
        {
            this.orderService.Export();
        }

        //根据查询条件查询订单
        private void inquireButton_Click(object sender, EventArgs e)
        {
            if(((string)this.conditionComboBox.SelectedItem=="收货人"||(string)this.conditionComboBox.SelectedItem=="商品名"
                ||(string)this.conditionComboBox.SelectedItem=="订单号")&&((string)this.conditionTextBox.Text != ""))
            {
                List<Order> result = new List<Order>();
                result=this.orderService.Seek(this.conditionTextBox.Text);
                this.orderBindingSource.DataSource = result;
                this.orderBindingSource.ResetBindings(true);
            }
            else if (((string)this.conditionComboBox.SelectedItem == "订单号") && ((string)this.conditionTextBox.Text != ""))
            {
                try
                {
                    int desID = Int32.Parse(this.conditionTextBox.Text);
                    this.orderService.Seek(desID);
                }catch(FormatException f)
                {
                    MessageBox.Show(f.Message, "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        //返回订单管理初始界面并且刷新信息
        private void backButton_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.DataSource = this.orderService.orderList;
            this.orderBindingSource.ResetBindings(true);
        }

        //点击显示订单的明细
        private void orderDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = this.orderDataGridView.CurrentRow.Index;
            this.orderItemBindingSource.DataSource = this.orderService.orderList[row].goodsList;
            this.orderItemBindingSource.ResetBindings(true);
        }

        //删除订单
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int row = this.orderDataGridView.CurrentRow.Index;
            this.orderService.orderList.Remove(this.orderService.orderList[row]);
            this.orderBindingSource.ResetBindings(true);
        }

        //
        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        //保存修改
        private void modifyButton_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.ResetBindings(true);
        }

        //向订单中添加商品
        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (this.orderDataGridView.CurrentRow != null)
            {

                //获取目标的order
                int row = this.orderDataGridView.CurrentRow.Index;
                Order des = this.orderService.orderList[row];

                addItemForm = new addItemForm(this.orderItemBindingSource, this.orderBindingSource, des);
                addItemForm.Show();
            }
            MessageBox.Show("请先选择订单", "ERROR", MessageBoxButtons.OK);
        }

        //删除订单中的某个商品
        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            int orderRow = this.orderDataGridView.CurrentRow.Index;
            int itemRow = this.orderItemDataGridView.CurrentRow.Index;
            this.orderService.orderList[orderRow].goodsList.Remove(this.orderService.orderList[orderRow].goodsList[itemRow]);
            this.orderBindingSource.ResetBindings(true);
            this.orderItemBindingSource.ResetBindings(true);
        }
    }
}
