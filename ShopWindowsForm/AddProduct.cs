using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWindowsForm
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Label", tb_Label.Text);
            data.Add("Price", tb_Price.Text);
            data.Add("Description", tb_Description.Text);
            data.Add("Quantity", tb_Quantity.Text);
            Data.Sql.Insert("Products", data);
            this.Close();
            MessageBox.Show("Product inserted ");
        }
    }
}
