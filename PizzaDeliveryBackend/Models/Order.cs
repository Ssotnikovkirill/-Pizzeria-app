using System;
using System.Collections.Generic;

namespace PizzaDeliveryBackend.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public List<Pizza> Pizzas { get; set; } = new();
    }
}
