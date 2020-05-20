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
    public class ProductController : ControllerBase
    {

        private readonly OrderContext OrderWebdb;

        //构造函数把TodoContext 作为参数，Asp.net core 框架可以自动注入TodoContext对象
        public ProductController(OrderContext context)
        {
            this.OrderWebdb = context;
        }

        //api/product/productQuery?orderId= &&productId=
        //根据订单号和产品号进行查询
        [HttpGet("productQuery")]
        public ActionResult<Product> GetProduct(long orderId,long productId)
        {
            var product = from n in OrderWebdb.Products
                              where n.OrderId == orderId&&n.ProductId==productId
                              select n;
            return product.FirstOrDefault();
        }

        //api/product/productQuery?name=
        //根据产品名进行查询
        [HttpGet("productQuery")]
        public ActionResult<List<Product>>QueryProduct(string name)
        {
            IQueryable<Product> products = from p in OrderWebdb.Products
                                           where p.Name == name
                                           select p;
            return products.ToList();
        }


        //添加产品
        // POST:api/product
        [HttpPost]
        public ActionResult<Product> PostOrder(Product product)
        {
            try
            {
                OrderWebdb.Products.Add(product);
                OrderWebdb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return product;
        }

        //修改产品
        // PUT: api/product/put?orderId= &&productId=
        [HttpPut("put")]
        public ActionResult<Product> PutOrder(long orderId, long productId,Product product)
        {
            if (orderId != product.OrderId||productId!=product.ProductId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                OrderWebdb.Entry(product).State = EntityState.Modified;
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

        //删除产品
        // DELETE: api/product/delete?orderId=  &&productId=
        [HttpDelete("delete")]
        public ActionResult DeleteOrder(long orderId,long productId)
        {
            try
            {
                var product = OrderWebdb.Products.FirstOrDefault(
                    t => t.OrderId == orderId&&t.ProductId==productId);
                if (product != null)
                {
                    OrderWebdb.Remove(product);
                    OrderWebdb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}