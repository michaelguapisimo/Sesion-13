using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.models;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = tbProduct.Text;
            product.price = double.Parse(tbProduct.Text);
            products.Add(product);
            ShowProduct();
        }
        private void ShowProduct()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }
    }
}
