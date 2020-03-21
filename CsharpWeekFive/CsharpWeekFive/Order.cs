using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpWeekFive
{
    internal class Order : IComparable<Order>
    {
        //订单编号
        private int orderID;
        public int OrderID
        {
            get
            {
                return orderID;
            }
        }

        //订单总金额
        private double totalSum;
        public double TotalSum
        {
            get
            {
                double temp=0;
                foreach(OrderItem od in this.goodsList)
                {
                    temp += od.TotalPrice;   
                }
                return temp;
            }
        }

        //订单生成时间
        private string time;
        public string Time
        {
            get
            {
                return time;
            }
        }

        //订单的收货地址
        private string receivingAddress;
        public string ReceivingAddress
        {
            get
            {
                return receivingAddress;
            }
            set
            {
                receivingAddress = value;
            }
        }

        //订单的收货人
        private string receivingPerson;
        public string ReceivingPerson
        {
            get
            {
                return receivingPerson;
            }
            set
            {
                receivingPerson = value;
            }
        }

        //该订单中的商品list
        public List<OrderItem> goodsList = new List<OrderItem>();

        //Order类的构造函数
        //创建订单时必须提供收货人和收货地址，订单号和订单时间自动生成
        public Order(string receivingAddress, string recevingPerson)
        {
            this.receivingAddress = receivingAddress;
            this.receivingPerson = recevingPerson;
            DateTime d = DateTime.Now;
            this.time = d.ToString();
            string temp = d.Day.ToString() + d.Hour.ToString() + d.Minute.ToString() + d.Second.ToString();
            orderID = int.Parse(temp);
        }

        public void ModifyPrice()
        {
            for(int i = 0; i < this.goodsList.Count; i++)
            {
                this.goodsList[i].ModifyTest();
            }
        }

        //向订单中添加商品
        public bool AppendGoods(OrderItem item)
        {
            foreach (OrderItem oi in goodsList)
            {
                if (oi.Equals(item))
                    return false;
            }
            this.goodsList.Add(item);
            this.totalSum += item.TotalPrice;
            this.goodsList.Sort((x, y) => { return x.GoodsID.CompareTo(y.GoodsID); });
            return true;
        }

        //根据商品编号删除订单中商品，同时完成订单金额的变化
        public bool DeleteGoods(int goodsID)
        {
            for (int i = 0; i < goodsList.Count; i++)
            {
                if (this.goodsList[i].GoodsID == goodsID)
                {
                    this.totalSum -= goodsList[i].TotalPrice;
                    goodsList.Remove(goodsList[i]);
                    return true;
                }
            }
            return false;
        }

        //重写Equals方法，实现订单类之间的比较
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            if ((this.orderID == order.orderID) && (this.receivingAddress == order.receivingAddress) && (this.receivingPerson == order.receivingPerson)
                && (this.goodsList == order.goodsList) && (this.totalSum == order.totalSum))
            {
                return true;
            }
            return false;
        }

        //重写ToString 方法，返回订单的信息
        public override string ToString()
        {
            string res = "订单号：" + this.OrderID + " 订单生成时间：" + this.Time + " 订单金额：" + this.TotalSum +
                " 收货人：" + this.ReceivingPerson + " 收货地址：" + this.ReceivingAddress;
            foreach (OrderItem i in goodsList)
            {
                res += "\n" + i.ToString();
            }
            return res;
        }

        //实现IComparable接口的CompareTo方法，实现订单类之间的排序
        public int CompareTo(Order o)
        {
            Order ord = o as Order;
            if (this.orderID < ord.orderID)
            {
                return -1;
            }
            if (this.orderID == ord.orderID)
                return 0;
            return 1;
        }
    }
}
