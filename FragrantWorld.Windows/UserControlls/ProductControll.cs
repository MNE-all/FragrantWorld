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
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public ProductControll(Product product)
        {
            InitializeComponent();

            using (var db = new FragrantWorldContext())
            {
                Manufacturer = db.Manufacturers.FirstOrDefault(x => x.Id == product.ManufacturerId).Name;
            }
            Name = product.Name;
            Description = product.Description;
            Price = product.Price;
            Discount = product.CurrentDiscount;

            labelName.Text = Name;
            labelDescription.Text = Description;
            labelManufacturer.Text = "Производитель: " + Manufacturer;
            labelPrice.Text = "Цена: " + Price;
            labelDiscount.Text = Discount.ToString();

            if (product.ImageURL != null && product.ImageURL != string.Empty)
            {
                var img = Image.FromFile("Images\\" + product.ImageURL);
                pictureBox.Image = img;
            }
        }
    }
}
