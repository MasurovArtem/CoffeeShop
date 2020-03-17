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

namespace CoffeeShop.view.menuControl
{
    public partial class CoffeeShopPOS : Form
    {
        private readonly BindingList<Product> _products = new BindingList<Product>();
        public CoffeeShopPOS()
        {
            InitializeComponent();

            

            lstProductsChoosen.DataSource = _products;
            lstProductsChoosen.DisplayMember = "Description";

            CreateTabbedPanel();
        }

        private void CreateTabbedPanel()
        {
            using (var db = new CoffeeDbContext())
            {
                foreach (var type in db.ProductsTypes)
                {
                    tabControl1.TabPages.Add(type.Id.ToString(), type.Description);
                }
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Description = "Product A",
                Price = 1.99m,
            };
            _products.Add(product);
        }

        private void FormatListItem(object sender, ListControlConvertEventArgs e)
        {
            var currentDescription = ((Product) e.ListItem).Description;
            //var currentPrice = string.Format("{0:c}",((Product)e.ListItem).Price);
            var currentPrice = $"{((Product) e.ListItem).Price:c}";
            var currentDescriptionPadded = currentDescription.PadRight(30);

            e.Value = currentDescriptionPadded + currentPrice;
        }
    }
}
