using FragrantWorld.Context;
using FragrantWorldWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FragrantWorld.Windows
{
    public partial class ProductControll : UserControl
    {
        public Product Product { get; set; }
        private float Discount { get; set; }
        public ProductControll(Product product)
        {
            InitializeComponent();

            Product = product;

            using (var db = new FragrantWorldContext())
            {
                Discount = Product.CurrentDiscount;

                labelName.Text = Product.Name;
                labelDescription.Text = Product.Description;
                labelManufacturer.Text = "Производитель: " + db.Manufacturers.First(x => x.Id == product.ManufacturerId).Name;
                labelPrice.Text = "Цена: " + Product.Price;
                labelDiscount.Text = Discount.ToString() + "%";

            }

            if (product.ImageURL != null && product.ImageURL != string.Empty)
            {
                var img = Image.FromFile("Images\\" + product.ImageURL);
                pictureBox.Image = img;
            }

            ValidateDiscount();
        }

        public void ValidateDiscount()
        {
            switch (Discount)
            {
                case > 4:
                    this.BackColor = ColorTranslator.FromHtml("#7fff00");
                    break;
                default:
                    this.BackColor = Color.FromArgb(255, 204, 153);
                    break;
            }
        }

        private void ProductControll_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(204, 102, 0);
        }

        private void ProductControll_MouseLeave(object sender, EventArgs e)
        {
            ValidateDiscount();
        }
    }
}
