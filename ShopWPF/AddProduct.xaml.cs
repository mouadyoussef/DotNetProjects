using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ShopWPF
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Label", tbLabel.Text);
            data.Add("Price", tbPrice.Text);
            data.Add("Description", tbDescription.Text);
            data.Add("Quantity", tbQuantity.Text);
            //Data.Sql.Insert("Products", data);
            this.Close();
            MessageBox.Show("Product inserted ");
        }
    }
}
