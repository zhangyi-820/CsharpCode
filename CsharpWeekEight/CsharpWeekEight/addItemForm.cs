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
    public partial class addItemForm : Form
    {
        BindingSource orderItemBindingSource;
        BindingSource orderBindingSource;
        Order desOrder;

        //创建窗体
        public addItemForm(BindingSource itemSource, BindingSource orderSource,Order des)
        {
            this.orderItemBindingSource = itemSource;
            this.orderBindingSource = orderSource;
            this.desOrder = des;
            InitializeComponent();
        }

        //添加商品
        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.goodsNameTextBox.Text != "" && this.goodsIDTextBox.Text != ""
                && this.goodsPriceTextBox.Text != "" && this.goodsNameTextBox.Text != "")
            {
                try
                {
                    double price = Double.Parse(this.goodsPriceTextBox.Text);
                    int amount = Int32.Parse(this.goodsNumberTextBox.Text);
                    int ID = Int32.Parse(this.goodsIDTextBox.Text);
                    OrderItem orderItem = new OrderItem(this.goodsNameTextBox.Text, ID, price, amount);
                    if (this.desOrder.AppendGoods(orderItem))
                    {
                        MessageBox.Show("添加成功", "", MessageBoxButtons.OK);
                        this.orderItemBindingSource.ResetBindings(true);
                        this.orderBindingSource.ResetBindings(true);
                        this.Close();
                        return;

                    }
                    MessageBox.Show("请勿重复添加", "ERROR", MessageBoxButtons.OK);
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("请输入正确类型信息", "ERROR", MessageBoxButtons.OK);
                }
            }
        }
    }
}
