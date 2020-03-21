﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpWeekFive
{
    class OrderService
    {
        //订单List,存储系统中订单信息
        public List<Order> orderList = new List<Order>();

        //构造函数，对系统中的订单默认排序
        public OrderService()
        {
            Console.WriteLine("Welcome!");
            this.DefaultSort();
        }

        //构造函数，根据OrderList初始化对象
        public OrderService(List<Order> order)
        {
            Console.WriteLine("Welcome!");
            this.orderList = order;
            this.DefaultSort();
        }

        //向系统中添加订单，需检查重复
        public bool AppendOrder(Order order)
        {
            foreach (Order o in orderList)
            {
                if (o.Equals(order))
                    return false;
            }
            orderList.Add(order);
            return true;
        }

        //根据订单号删除系统的对应订单
        public bool DeleteOrder(int desID)
        {
            for (int i = 0; i < this.orderList.Count; i++)
            {
                if (this.orderList[i].OrderID == desID)
                {
                    this.orderList.Remove(orderList[i]);
                    return true;
                }
            }
            return false;
        }

        //两个重载函数，根据订单号、收货人、商品名查询订单
        //返回订单list
        public List<Order> Seek(int desID)
        {
            List<Order> res = new List<Order>();
            for (int i = 0; i < this.orderList.Count; i++)
            {
                if (this.orderList[i].OrderID == desID)
                {
                    res.Add(orderList[i]);
                }
            }
            return res;
        }
        public List<Order> Seek(string des)
        {
            List<Order> res = new List<Order>();
            for (int i = 0; i < this.orderList.Count; i++)
            {
                Order temp = this.orderList[i];

                //根据订单收货人查找
                if (this.orderList[i].ReceivingPerson == des)
                {
                    res.Add(temp);
                }

                //根据订单中的商品名查找
                for (int j = 0; j < temp.goodsList.Count; j++)
                {
                    if (des == temp.goodsList[i].Name)
                    {
                        res.Add(temp);
                    }
                }
            }

            return res;
        }

        //默认排序，根据订单号排序
        public bool DefaultSort()
        {
            if (this.orderList == null)
                return false;
            orderList.Sort();
            return true;
        }

        //通过lambda语句实现排序，此处根据订单的总金额排序
        public bool LambdaSortTest()
        {
            if (this.orderList == null)
                return false;
            orderList.Sort((x, y) => { return x.TotalSum.CompareTo(y.TotalSum); });
            return true;
        }

        //LINQ语言查询
        public List<Order> LINQTest()
        {
            //当orderList不为空进行查询，否则返回空值
            if (this.orderList.Count != 0)
            {
                var temp = from n in this.orderList
                           where n.OrderID > this.orderList[0].OrderID
                           orderby n.TotalSum
                           select n;

                List<Order> res = new List<Order>();
                foreach (Order o in temp)
                    res.Add(o);
                return res;
            }
            return null;
        }

        //重写ToString函数，返回系统中当前的订单信息
        public override string ToString()
        {
            string res = "";
            foreach (Order o in this.orderList)
            {
                res += o.ToString();
                res += "\n";
            }
            return res;
        }

    }
}