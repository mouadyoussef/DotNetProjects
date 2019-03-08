using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WcfServiceApp
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Quantity { get; set; }

        public Product() { }

        public Product(int id, string name, double price, string description, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Quantity = quantity;
        }
        
        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Price = {Price}";
        }
    }
}