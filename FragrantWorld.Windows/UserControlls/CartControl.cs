using FragrantWorld.Context;
using FragrantWorld.Context.Models;
using FragrantWorld.Windows.UserControlls.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FragrantWorld.Windows.UserControlls
{
    public partial class CartControl : UserControl
    {
        public CartModel CartModel { get; set; }
        public CartControl(CartModel cartModel)
        {
            CartModel = cartModel;

            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 204, 153);

            using (var db = new FragrantWorldContext())
            {
                labelName.Text = CartModel!.Name;
                labelDescription.Text = CartModel.Description;
                labelManufacturer.Text = "Производитель: " + db.Manufacturers.First(x => x.Id == cartModel.ManufacturerId).Name;
                labelPrice.Text = "Цена: " + CartModel.Price;
                labelDiscount.Text = CartModel.CurrentDiscount.ToString() + "%";
                ButtonBaseEvents();
            }

            if (cartModel.ImageURL != null && cartModel.ImageURL != string.Empty)
            {
                var img = Image.FromFile("Images\\" + cartModel.ImageURL);
                pictureBox.Image = img;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            CartModel.Amount += 1;
            ButtonBaseEvents();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CartModel.Amount > 1)
            {
                CartModel.Amount -= 1;
            }
            ButtonBaseEvents();
        }

        private void ButtonBaseEvents()
        {
            using(var db = new FragrantWorldContext())
            {
                var cart = db.Carts.Where(x => x.Id == CartModel.Id).First();
                cart.Amount = CartModel.Amount;
                db.Carts.Update(cart);
                db.SaveChanges();
            }

            labelAmount.Text = CartModel.Amount.ToString();
            labelTotalPrice.Text = (CartModel.Price * CartModel.Amount).ToString();
        }

        private void CartControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(204, 102, 0);
        }

        private void CartControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 204, 153);
        }
    }
}
