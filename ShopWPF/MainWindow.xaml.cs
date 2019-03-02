using RemotingLibrary.Dao;
using System;
using System.Windows;
using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using RemotingLibrary.Models;
using System.Runtime.Remoting.Channels.Tcp;

namespace ShopWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbHost.Focus();
        }

        private void BtConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TcpClientChannel clientChannel = new TcpClientChannel();
                ChannelServices.RegisterChannel(clientChannel, false);
                IProductDao productDao = (IProductDao)Activator.GetObject(typeof(IProductDao), $"tcp://{tbHost.Text}:8090/Products");
                Console.WriteLine("Product Info : ");
                List<Product> products = productDao.GetAll();
                productsGrid.DataContext = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : \n{ex.Message}", "Connecting Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TbHost_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                BtConnect_Click(sender, e);
            }
        }
    }
}
