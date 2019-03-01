using Org.Mql.Ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            Data.Sql = new SqlDataBase(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = Data.Sql.Select("Products");
            productsGrid.DataContext = dataTable.DefaultView;
        }

        private void BtnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete these items ?",
                                        "Confirm Delete!!",
                                        MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                if (productsGrid.SelectedItems.Count > 0)
                {
                    foreach (DataRowView item in productsGrid.SelectedItems)
                    {
                        Data.Sql.Delete("Products", "ID", item[0].ToString());
                    }
                    DataTable dataTable = Data.Sql.Select("Products");
                    productsGrid.DataContext = dataTable.DefaultView;
                }
            }
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct window = new AddProduct();
            window.ShowDialog();
            DataTable dataTable = Data.Sql.Select("Products");
            productsGrid.DataContext = dataTable.DefaultView;
        }
    }
}
