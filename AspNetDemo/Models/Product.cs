using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Solde { get; set; }

        public Product() { }

        public Product(int id, string name, double price, string description, int quantity, int solde)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Quantity = quantity;
            Solde = solde;
        }

        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Price = {Price}";
        }
    }
}