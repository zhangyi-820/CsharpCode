using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpWeekFive
{
    class OrderItem
    {
        //商品名称
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //商品编号
        private int goodsID;
        public int GoodsID
        {
            get
            {
                return goodsID;
            }
            set
            {
                goodsID = value;
            }
        }
        
        //商品价格
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        //商品数量
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        //单项商品金额合计
        private double totalPrice;
        public double TotalPrice
        {
            get
            {
                return price*amount;
            }
            set
            {
                totalPrice = amount * price;
            }
        }

        //OrderItem的构造函数，默认商品数量为1，自动计算总价
        public OrderItem(string name, int goodsID, double price, int amount = 1)
        {
            this.name = name;
            this.goodsID = goodsID;
            this.price = price;
            this.amount = amount;
            this.totalPrice = amount * price;
        }

        //重写ToString方法，返回该条目的信息
        public override string ToString()
        {
            string res = "商品编号：" + this.goodsID + " 商品名称：" + this.name + " 商品价格：" + this.price
                + " 商品数量：" + this.amount + " 总金额:" + this.totalPrice;
            return res;
        }

        //重写Equals方法，检查重复项
        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            if ((this.name == item.name) && (this.goodsID == item.goodsID) && (this.price == item.price)
                && (this.amount == item.amount) && (this.totalPrice == item.totalPrice))
            {
                return true;
            }
            return false;
        }

        public void ModifyTest()
        {
            this.Price *= 2;
            this.TotalPrice = this.Price * this.Amount;
        }
    }
}
