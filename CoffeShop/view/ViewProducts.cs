using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;
using CoffeeShop.model;

namespace CoffeeShop.view
{
    public partial class ViewProducts : Form
    {
        private readonly CoffeeDbContext _db;
        public ViewProducts()
        {
            InitializeComponent();

            _db = new CoffeeDbContext();

            dataGridView1.DataSource = _db.Products.ToList();

            dataGridView1.Columns["ProductType"].Visible = false;
            dataGridView1.Columns["ProductTypeId"].Visible = false;

            cboFilter.DataSource = _db.ProductsTypes.ToList();
            cboFilter.DisplayMember = "Description";
            cboFilter.ValueMember = "Id";
        }

        private void FilterList(object sender, EventArgs e)
        {

            var sortableId = (int)cboFilter.SelectedValue;

            var filterProducts = _db.Products.Where(p => p.ProductTypeId == sortableId).ToList();

            dataGridView1.DataSource = filterProducts;

        }
    }
}
