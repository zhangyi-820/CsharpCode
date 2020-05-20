using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
    public class Product{
        [Key]
        public int ProductId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public double Sum { get; set; }
        [Required]
        public string Name { get; set; }
        [Key]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        /*public Product(int goodId, double price, int amount, string name, Order order)
        {
            this.ProductId = goodId;
            this.Price = price;
            this.Amount = amount;
            this.Sum = amount * price;
            this.Name = name;
            this.Order = order;
            this.OrderId = order.OrderId;
        }*/

    }
}