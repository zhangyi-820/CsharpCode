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
    
    public partial class addOrderForm : Form
    {
        private Order order;
        OrderService orderService;
        BindingSource source;

        public addOrderForm(OrderService  orderService,BindingSource source)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.source = source;
        }

        //创建订单
        private void createButton_Click(object sender, EventArgs e)
        {
            if (this.receivingAddressTextBox.Text != "" && this.receivingAddressTextBox.Text != "")
            {
                this.order = new Order(this.receivingAddressTextBox.Text, this.receivingPersonTextBox.Text);
                this.orderService.AppendOrder(this.order);
                return;
            }
            MessageBox.Show("请输入收货人和收货地址", "ERROR", MessageBoxButtons.OK);
        }

        //向生成后的订单中添加商品
        private void addButton_Click(object sender, EventArgs e)
        {
            this.createButton_Click(sender, e);
            if(this.goodsNameTextBox.Text!=""&&this.goodsIDTextBox.Text!=""
                && this.goodsPriceTextBox.Text != "" && this.goodsNameTextBox.Text != "") {
                try
                {
                    //获取目标商品信息
                    double price = Double.Parse(this.goodsPriceTextBox.Text);
                    int amount = Int32.Parse(this.goodsNumberTextBox.Text);
                    int ID = Int32.Parse(this.goodsIDTextBox.Text);
                    OrderItem orderItem = new OrderItem(this.goodsNameTextBox.Text, ID, price, amount);

                    //当添加成功后提示用户
                    if (this.order.AppendGoods(orderItem))
                    {
                        MessageBox.Show("添加成功", "", MessageBoxButtons.OK);
                        this.source.ResetBindings(true);
                        return;
                       
                    }
                    MessageBox.Show("请勿重复添加", "ERROR", MessageBoxButtons.OK);
                }
                //用户输入了不合规范的信息
                catch (FormatException exception){
                    MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
                }
              }
            //用户为输入完整信息
            MessageBox.Show("请输入完整信息", "ERROR", MessageBoxButtons.OK);
        }

        //返回主界面
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goodsNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
