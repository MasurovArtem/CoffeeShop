using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CoffeeShop.model;

namespace CoffeeShop.view.menuControl
{
    public partial class CoffeeShopPOS : Form
    {
        private readonly BindingList<Product> _products = new BindingList<Product>();

        private decimal transactionTotal;
        public decimal TransactionTotal
        {
            get => transactionTotal;
            set
            {
                transactionTotal = value;
                txtTotal.Text = $@"{transactionTotal:C}";
            }
        }

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
            UpdateCustomerInformationPanel(product);

            TransactionTotal += product.Price;
            lstProductsChoosen.SelectedIndex = lstProductsChoosen.Items.Count - 1;

        }

        private void UpdateCustomerInformationPanel(Product product)
        {
            var currentDescription = product.Description;
            var currentPrice = $"{product.Price:c}";
            var currentDescriptionPadded = currentDescription.PadRight(38);

            txtInfopanel.Text = currentDescriptionPadded + currentPrice;
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
            var currentDescriptionPadded = currentDescription.PadRight(29);

            e.Value = currentDescriptionPadded + currentPrice;
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            var productSelected = (Product) lstProductsChoosen.SelectedItem;

            if (productSelected == null) return;

            _products.Remove(productSelected);
            TransactionTotal -= productSelected.Price;

        }

        private void Payment(object sender, EventArgs e)
        {
            var payment = new Payment();
            payment.PaymentMade += PaymentSuccess;
            payment.PaymentAmount = TransactionTotal;
            
            var res = payment.ShowDialog();
            if (res == DialogResult.OK)
            {
                PrintReceipt();
            }
        }

        private void PrintReceipt()
        {
            var printDialog = new PrintDialog();
            var printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += PrintDocument_PrintPage;

            var result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var graphics = e.Graphics;
            var font = new Font("Courier New", 12);
            var fontHeight = font.GetHeight();

            var startX = 10;
            var startY = 10;
            var offset = 40;

            graphics.DrawString
            (
                "Wellcome to the coffee shop",
                new Font("Courier New", 18),
                new SolidBrush(Color.Black),
                startX,
                startY
            );

            foreach (Product product in _products)
            {
                string productDecription = product.Description.PadRight(30);
                string productTotal = $@"{product.Price:C}";
                string productLine = productDecription + productTotal;

                graphics.DrawString
                (
                    productLine,
                    font,
                    new SolidBrush(Color.Black),
                    startX,
                    startY + offset
                );

                offset += (int) fontHeight + 5;
            }

            offset += 20;
            graphics.DrawString
                (
                    "Total to pay".PadRight(30) + $@"{transactionTotal:C}",
                    font,
                    new SolidBrush(Color.Black),
                    startX,
                    startY + offset
                );
        }

        private void PaymentSuccess(object sender, Payment.PaymentMadeEventArgs e)
        {
            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                TransactionItem = new List<TransactionItem>()
            };
            foreach (var product in _products)
            {
                var tItem = new TransactionItem {ProductId = product.Id};
                transaction.TransactionItem.Add(tItem);
            }

            using (var _db = new CoffeeDbContext())
            {
                _db.Transactions.Add(transaction);
                _db.SaveChanges();
            }
        }
    }
}
