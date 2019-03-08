using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.WcfServiceProducts;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProducts service = new ServiceProductsClient();
            Product product = service.Get(1);

            Console.WriteLine($"Id = {product.Id}, Name = {product.Name}");

            Console.ReadKey(true);
        }
    }
}
