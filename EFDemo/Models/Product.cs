using System;

namespace EFDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(int id, string label, double price, 
            string description, int quantity)
        {
            Id = id;
            Label = label;
            Price = price;
            Description = description;
            Quantity = quantity;
        }
    }
}
