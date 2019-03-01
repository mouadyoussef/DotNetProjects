using RemotingLibrary.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServer
{
    class Program
    {
        static void Main()
        {
            try
            {
                //select channel to communicate
                TcpChannel chan = new TcpChannel(8090);
                ChannelServices.RegisterChannel(chan, false);
                //register channel
                //register remote object
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(ProductDao),
                    "Products",
                    WellKnownObjectMode.SingleCall
                );
                //inform console
                Console.WriteLine("Server Activated ...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}
