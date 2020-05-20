using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderApi.Models;
using OrderApi;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderContext OrderWebdb;

        //构造函数把TodoContext 作为参数，Asp.net core 框架可以自动注入TodoContext对象
        public OrderController(OrderContext context)
        {
            this.OrderWebdb = context;
        }

        //根据订单号查询订单
        // GET: api/order/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long orderId)
        {
            var order = OrderWebdb.Orders.FirstOrDefault(t => t.OrderId == orderId);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        //根据收货人查询订单
        // GET: api/order/orderQueryByName?recPerson=
        [HttpGet("orderQueryByName")]
        public ActionResult<List<Order>> QueryOrderByName(string recPerson)
        {
            IQueryable<Order> orders = from o in OrderWebdb.Orders
                                       where o.RecPerson == recPerson
                                       select o;
            if (orders == null)
            {
                return NoContent();
            }
            return orders.ToList();
        }

        //根据收货地址查询订单
        [HttpGet("orderQueryByAddress")]
        public ActionResult<List<Order>> QueryOrderByAddress(string recAddress)
        {
            IQueryable<Order> orders = from o in OrderWebdb.Orders
                                       where o.RecAddress == recAddress
                                       select o;
            if (orders == null)
            {
                return NoContent();
            }
            return orders.ToList();
        }

        //添加订单
        // POST: api/product
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                OrderWebdb.Orders.Add(order);
                OrderWebdb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        //修改订单
        // PUT: api/order/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(long id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                OrderWebdb.Entry(order).State = EntityState.Modified;
                OrderWebdb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        //删除订单
        // DELETE: api/todo/{id}
        [HttpDelete("{orderId}")]
        public ActionResult DeleteOrder(long orderId)
        {
            try
            {
                var order = OrderWebdb.Orders.FirstOrDefault(t => t.OrderId == orderId);
                if (order != null)
                {
                    OrderWebdb.Remove(order);
                    OrderWebdb.SaveChanges();
                }
                var product = from p in OrderWebdb.Products
                              where p.OrderId == orderId
                              select p;
                foreach( Product p in product)
                {
                    OrderWebdb.Products.Remove(p);
                }
                OrderWebdb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}