using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CoffeeShop.model;

namespace CoffeeShop.view
{
    public partial class AddProduct : Form
    {
        private readonly CoffeeDbContext _db;
        private byte[] byteBlobData;
        public AddProduct()
        {
            InitializeComponent();
            _db = new CoffeeDbContext();

            cboCategory.DataSource = _db.ProductsTypes.ToList();
            cboCategory.DisplayMember = "Description";
            cboCategory.ValueMember = "Id";
        }

        private void UploadImage_Click(object sender, System.EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK) return;

            var fsBlobFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byteBlobData = new byte[fsBlobFile.Length];
            fsBlobFile.Read(byteBlobData, 0, byteBlobData.Length);

            fsBlobFile.Close();

                
            var stmBlobData = new MemoryStream(byteBlobData);
            pbImage.Image = Image.FromStream(stmBlobData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
            var product = new Product
            {
                Description = txtDecription.Text,
                Image = byteBlobData,
                ProductTypeId = (int) cboCategory.SelectedValue,
                Price = decimal.Parse(txtPrice.Text, CultureInfo.InvariantCulture)
            };

            _db.Products.Add(product);
            _db.SaveChanges();
        }
    }
}
