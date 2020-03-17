using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
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

            AddProductsToTabbedPanel();
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

        private void AddProductsToTabbedPanel()
        {


            using (var db = new CoffeeDbContext())
            {
                foreach (TabPage tp in tabControl1.TabPages)
                {
                    var flp = new FlowLayoutPanel { Dock = DockStyle.Fill };
                    
                    var products = db.Products.Where(p => p.ProductType.Id.ToString() == tp.Name).ToList();

                    foreach (var prod in products)
                    {
                        var b = new Button
                        {
                            Text = prod.Description,
                            Size = new Size(100, 100),
                            Tag = prod,
                        };
                        b.Click += new EventHandler(UpdateProductList);
                        flp.Controls.Add(b);
                    }

                    tp.Controls.Add(flp);
                }
            }
        }

        private void UpdateProductList(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var product = (Product) b.Tag;

            _products.Add(product);

            lstProductsChoosen.SelectedIndex = lstProductsChoosen.Items.Count - 1;

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
