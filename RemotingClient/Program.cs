using RemotingLibrary.Dao;
using RemotingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter host : ");
                string host = Console.ReadLine();
                Console.WriteLine($"Connecting to : {host} ...");
                TcpClientChannel clientChannel = new TcpClientChannel();
                ChannelServices.RegisterChannel(clientChannel, false);
                IProductDao productDao = (IProductDao)Activator.GetObject(typeof(IProductDao), $"tcp://{host}:8090/Products");
                Console.WriteLine("Product Info : ");
                List<Product> products = productDao.GetAll();
                foreach (Product product in products)
                    Console.WriteLine($"id = {product.Id}, label = {product.Label}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            Console.ReadKey(true);
        }
    }
}
