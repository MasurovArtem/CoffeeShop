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

        private void button1_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProduct();
            addProduct.Show();

        }
    }
}
