using FragrantWorld.Context;
using FragrantWorld.Windows.Forms;
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
    public partial class OrderUpdateControl : UserControl
    {
        public OrderModel OrderModel { get; set; }
        public OrderUpdateControl(OrderModel orderModel)
        {
            OrderModel = orderModel;
            InitializeComponent();

            this.BackColor = Color.FromArgb(255, 204, 153);

            using (var db = new FragrantWorldContext())
            {
                labelName.Text = OrderModel!.Name;
                labelDescription.Text = OrderModel.Description;
                labelManufacturer.Text = "Производитель: " + db.Manufacturers.First(x => x.Id == OrderModel.ManufacturerId).Name;
                labelPrice.Text = "Цена: " + OrderModel.Price;
                labelDiscount.Text = OrderModel.CurrentDiscount.ToString() + "%";
                ButtonBaseEvents();
            }

            if (OrderModel.ImageURL != null && OrderModel.ImageURL != string.Empty)
            {
                var img = Image.FromFile("Images\\" + OrderModel.ImageURL);
                pictureBox.Image = img;
            }
        }

        private void ButtonBaseEvents()
        {
            using (var db = new FragrantWorldContext())
            {
                var order = db.Orders.Where(x => x.Number == OrderModel.Number && x.ProductArticleNumber == OrderModel.ArticleNumber).First();
                order.Amount = OrderModel.Amount;
                db.Orders.Update(order);
                db.SaveChanges();
            }

            labelAmount.Text = OrderModel.Amount.ToString();
            labelTotalPrice.Text = (OrderModel.Price * (100 - (decimal)OrderModel.CurrentDiscount) / 100 * OrderModel.Amount).ToString();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            OrderModel.Amount += 1;
            ButtonBaseEvents();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (OrderModel.Amount > 1)
            {
                OrderModel.Amount -= 1;
                ButtonBaseEvents();
            }
            else
            {
                if (MessageBox.Show("Вы дейтсвительно хотите удалить этот товар из корзины?", "Удаление товара из корзины!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    using (var db = new FragrantWorldContext())
                    {
                        db.Orders.Remove(db.Orders.Where(x => x.Number == OrderModel.Number && x.ProductArticleNumber == OrderModel.ArticleNumber).First());
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
