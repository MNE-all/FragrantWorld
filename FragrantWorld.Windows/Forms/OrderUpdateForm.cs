using FragrantWorld.Context.Models;
using FragrantWorld.Windows.UserControlls;
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

namespace FragrantWorld.Windows.Forms
{
    public partial class OrderUpdateForm : Form
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public OrderUpdateForm(List<Order> orders, List<Product> products)
        {
            Orders = orders;
            Products = products;

            InitializeComponent();

            ShowOrders();
        }

        public void ShowOrders()
        {
            foreach (Order order in Orders)
            {
                var product = Products.First(x => x.ArticleNumber == order.ProductArticleNumber);
                var orderModel = new OrderModel
                {
                    Number = order.Number,
                    Amount = order.Amount,
                    ArticleNumber = product.ArticleNumber,
                    StorageAmount = product.StorageAmount,
                    Description = product.Description,
                    CurrentDiscount = product.CurrentDiscount,
                    ImageURL = product.ImageURL,
                    ManufacturerId = product.ManufacturerId,
                    Name = product.Name,
                    Price = product.Price,
                };
                var orderControl = new OrderUpdateControl(orderModel);
                flowLayoutPanel.Controls.Add(orderControl);
            }
        }
    }
}
