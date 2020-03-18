using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.model;
using CoffeeShop.view;
using CoffeeShop.view.menuControl;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        private readonly CoffeeDbContext _db; 
        public Form1()
        {
            InitializeComponent();

            _db = new CoffeeDbContext();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProduct();
            addProduct.Show();

        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            var viewProducts = new ViewProducts();
            viewProducts.Show();

        }

        private void btnOpenPOS_Click(object sender, EventArgs e)
        {
            var coffeeShopPOS = new CoffeeShopPOS();
            coffeeShopPOS.Show();
        }

        private void bthOpenGraph_Click(object sender, EventArgs e)
        {
            var displaySalesGraph = new DisplaySales();
            displaySalesGraph.Show();
        }
    }
}
