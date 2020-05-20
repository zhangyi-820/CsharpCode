using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
    public class Order{
        public static int Count = 0;
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string RecAddress { get; set; }
        [Required]
        public string RecPerson { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public double Sum { get; set; }
        
        public List<Product> Products { get; set; }
        /*public Order()
        {
            this.Products = new List<Product>();
            Count++;
        }

        public Order(string recPerson, string recAddress)
        {
            this.RecAddress = recAddress;
            this.RecPerson = recPerson;
            this.Time = DateTime.Now.ToString();
            this.OrderId = Count++;
            this.Products = new List<Product>();
            this.Sum = 0;
        }*/

    }
}