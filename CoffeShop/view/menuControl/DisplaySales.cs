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
    public partial class DisplaySales : Form
    {
        public DisplaySales()
        {
            InitializeComponent();
           
        }

        private void GenerateGraph()
        {
            using (var _db = new CoffeeDbContext())
            {
                var query = from product in _db.TransactionItems
                    group product by product.Product.Description
                    into g
                    select new {ProductId = g.Key, TotalUnitsSold = g.Count()};

                chart1.DataSource = query;
                chart1.Series["Series1"].XValueMember = "ProductId";
                chart1.Series["Series1"].YValueMembers = "TotalUnitsSold";

                chart1.Series["Series1"].Name = "Products";

                chart1.DataBind();
                chart1.Show();
            }
        }
    }
}
