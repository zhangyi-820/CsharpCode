using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpWeekFive;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace CsharpCodeWeekSix_unitTest
{
    [TestClass]
    public class UnitTest1
    {
        OrderService orderService = new OrderService();
        OrderItem orderItem1, orderItem2, orderItem3, orderItem4;
        Order order1, order2;

        [TestInitialize]
        public void Initialize()
        {
            
            //创建商品信息
            orderItem1 = new OrderItem("袜子", 1, 10.0, 1);
            orderItem2 = new OrderItem("帽子", 2, 20, 2);
            orderItem3 = new OrderItem("裤子", 3, 100, 1);
            orderItem4 = new OrderItem("饮用水", 4, 2, 10);

            //创建订单
            order1 = new Order("武汉", "张三");
            Thread.Sleep(1000);
            order2 = new Order("重庆", "李四");

            //向订单中添加商品
            order1.AppendGoods(orderItem2);
            order1.AppendGoods(orderItem1);
            order2.AppendGoods(orderItem3);
            order2.AppendGoods(orderItem4);

           
        }

        [TestMethod]
        public void LINQTest()
        {
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);

            List<Order> res = orderService.LINQTest();
            Assert.AreEqual(res[0], order2);
        }

        [TestMethod]
        public void SeekTest1()
        {
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);

            List<Order> res = orderService.Seek(order1.OrderID);
            Assert.AreEqual(res[0], order1);
        }

        [TestMethod]
        public void SeekTest2()
        {
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);

            List<Order> res = orderService.Seek(0);
            Assert.AreEqual(res, null);
        }

        [TestMethod]
        public void SeekTest3()
        {
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);

            List<Order> res = orderService.Seek(order1.ReceivingPerson);
            Assert.AreEqual(res[0], order1);
        }

        [TestMethod]
        public void LambdaSortTest()
        {
            OrderService res = new OrderService();
            if (order1.TotalSum < order2.TotalSum)
            {
                res.AppendOrder(order1);
                res.AppendOrder(order2);
            }
            else
            {
                res.AppendOrder(order2);
                res.AppendOrder(order1);
            }
            
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);
           

            orderService.LambdaSortTest();
            Assert.AreEqual(res, orderService);

        }

        [TestMethod]
        public void OrderDeleteGoodsTest()
        {
            Order res = new Order("武汉","张三");
            res.AppendGoods(orderItem1);
            res.Time = order1.Time;
            res.OrderID = order1.OrderID;
            order1.DeleteGoods(2);
            Assert.AreEqual(res, order1);
        }

        [TestMethod]
        public void DeleteOrderTest()
        {
            OrderService res = new OrderService();
            res.AppendOrder(order1);
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);
            orderService.DeleteOrder(order2.OrderID);
            Assert.AreEqual(res, orderService);
        }

        [TestMethod]
        public void ModifyPriceTest()
        {
            OrderItem neworderItem1 = new OrderItem("袜子", 1, 20.0, 1);
            OrderItem neworderItem2 = new OrderItem("帽子", 2, 40, 2);
            Order res = new Order("武汉", "张三");
            res.OrderID = order1.OrderID;
            res.Time = order1.Time;
            res.AppendGoods(neworderItem1);
            res.AppendGoods(neworderItem2);
            order1.ModifyPrice();
            System.Console.WriteLine(order1.TotalSum+" "+res.TotalSum);
            Assert.AreEqual(res, order1);
        }

        [TestMethod]
        public void ExportAndImportTest()
        {
            orderService.AppendOrder(order1);
            orderService.AppendOrder(order2);
            orderService.Export();
            List<Order> res = (List<Order>)orderService.Import();
            OrderService newOrderService = new OrderService(res);
            Assert.AreEqual(newOrderService, orderService);
        }

    }
}
