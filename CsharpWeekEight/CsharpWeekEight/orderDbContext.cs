using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CsharpWeekEight
{
    class orderDbContext:DbContext
    {
        public orderDbContext():base("OrderDataBase")
        {
            Database.SetInitializer(
       new DropCreateDatabaseIfModelChanges<orderDbContext>());
        }

        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
    }
}
