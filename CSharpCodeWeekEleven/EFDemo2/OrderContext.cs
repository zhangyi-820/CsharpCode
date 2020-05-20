using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using OrderGUISystem;

namespace OrderSystem
{
    public class OrderContext:DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
                new CreateDatabaseIfNotExists<OrderContext>());
        //new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
