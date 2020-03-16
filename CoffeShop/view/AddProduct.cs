using System.Linq;
using System.Windows.Forms;
using CoffeeShop.model;

namespace CoffeeShop.view
{
    public partial class AddProduct : Form
    {
        private readonly CoffeeDbContext _db;
        public AddProduct()
        {
            InitializeComponent();
            _db = new CoffeeDbContext();

            cboCategory.DataSource = _db.ProductsTypes.ToList();
            cboCategory.DisplayMember = "Description";
            cboCategory.ValueMember = "Id";
        }
    }
}
