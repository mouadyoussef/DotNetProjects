using RemotingServer.Dao;
using System;
using System.Collections;
using System.Net;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingServer
{
    class Program
    {
        static void Main()
        {
            try
            {
                //select channel to communicate
                TcpChannel channel = new TcpChannel(8090);
                ChannelServices.RegisterChannel(channel, false);
                //register channel
                //register remote object
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(ProductDao), // ProductDao.class
                    "Products", // Url
                    WellKnownObjectMode.SingleCall
                );
                //inform console
                Console.WriteLine("Server Activated ...");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
