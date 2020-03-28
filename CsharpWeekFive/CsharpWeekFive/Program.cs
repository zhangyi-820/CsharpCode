using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CsharpWeekFive
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //创建商品信息
            OrderItem orderItem1 = new OrderItem("袜子", 1, 10.0, 1);
            OrderItem orderItem2 = new OrderItem("帽子", 2, 20, 2);
            OrderItem orderItem3 = new OrderItem("裤子", 3, 100, 1);
            OrderItem orderItem4 = new OrderItem("饮用水", 4, 2, 10);

            //创建订单
            Order order1 = new Order("武汉", "张三");
            Thread.Sleep(1000);
            Order order2 = new Order("重庆", "李四");

            //向订单中添加商品
            order1.AppendGoods(orderItem2);
            order1.AppendGoods(orderItem1);
            order2.AppendGoods(orderItem3);
            order2.AppendGoods(orderItem4);

            //向订单系统中添加订单
            OrderService orderService = new OrderService();
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);

            //输出当前系统中存在的订单信息
            Console.WriteLine(orderService.ToString() + "\n");

            //LINQ语言查询，查询条件为订单号大于系统中第一个订单的所有订单
            Console.WriteLine("LINQ语言查询，查询条件为订单号大于系统中第一个订单的所有订单");
            List<Order> LINQTest = orderService.LINQTest();
            foreach(Order o in LINQTest)
            {
                Console.WriteLine(o.ToString());
            }


            //普通查询测试,查询条件分别第一个订单的订单号和收货人为张三的订单
            Console.WriteLine("\n普通查询测试,查询条件分别第一个订单的订单号和收货人为张三的订单");
            List<Order> SeekTest = new List<Order>();
            SeekTest = orderService.Seek(order1.OrderID);
            foreach(Order o in SeekTest)
            {
                Console.WriteLine(o.ToString());
            }
            SeekTest = orderService.Seek("张三");
            foreach (Order o in SeekTest)
            {
                Console.WriteLine(o.ToString());
            }

            //lambda语句排序,lambda条件为安装订单金额排序
            Console.WriteLine("\nlambda语句排序,lambda条件为安装订单金额排序");
            orderService.LambdaSortTest();
            Console.WriteLine(orderService.ToString());

            //删除某个订单中的某个商品
            Console.WriteLine("删除某个订单中的某个商品,这里删除1号订单的1号商品");
            order1.DeleteGoods(1);
            Console.WriteLine(orderService.ToString()+"\n");

            //删除系统中的第一个订单
            Console.WriteLine("删除系统中的第一个订单");
            orderService.DeleteOrder(order1.OrderID);
            Console.WriteLine(orderService.ToString()+"\n");

            //修改订单信息，将订单中的商品价格翻倍
            Console.WriteLine("修改订单信息，将订单中的商品价格翻倍");
            orderService.orderList[0].ModifyPrice();
            Console.WriteLine(orderService.ToString()+"\n");

            orderService.Export();
            List<Order> importTest = (List<Order>)orderService.Import();
            foreach(Order ord in importTest)
            {
                Console.WriteLine(ord.ToString());
            }
        }
    }
}
