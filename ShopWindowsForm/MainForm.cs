using Org.Mql.Ado;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Data.Sql = new SqlDataBase(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial 
                    Catalog=Shop;Integrated Security=True;");
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = Data.Sql.Select("Products");
            productsGrid.DataSource = dataTable;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct form = new AddProduct();
            form.ShowDialog();
            DataTable dataTable = Data.Sql.Select("Products");
            productsGrid.DataSource = dataTable;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete these items ?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (productsGrid.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in productsGrid.SelectedRows)
                    {
                        Data.Sql.Delete("Products", "ID", row.Cells[0].Value);
                    }
                    DataTable dataTable = Data.Sql.Select("Products");
                    productsGrid.DataSource = dataTable;
                }
            }
        }
    }
}
