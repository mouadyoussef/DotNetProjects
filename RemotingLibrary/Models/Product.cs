using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLibrary.Models
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Product() { }
    }
}
