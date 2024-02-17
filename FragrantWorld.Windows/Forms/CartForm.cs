using FragrantWorld.Context.Models;
using FragrantWorld.Context;
using FragrantWorld.Windows.UserControlls;
using System.Data;
using FragrantWorld.Windows.UserControlls.Models;

namespace FragrantWorld.Windows.Forms
{
    public partial class CartForm : Form
    {
        public User CurrentUser { get; set; }
        public decimal TotalSum = 0;
        public CartForm(User user)
        {
            CurrentUser = user;
            InitializeComponent();

            comboBoxPickUpPoint.Items.Add("Не выбрано");
            using (var db = new FragrantWorldContext())
            {
                foreach (var pickUpPoint in db.PickUpPoints.ToList())
                {
                    comboBoxPickUpPoint.Items.Add(pickUpPoint);
                }
            }
            comboBoxPickUpPoint.SelectedIndex = 0;

            labelFullName.Text = CurrentUser.Surname + " " +
            CurrentUser.Name + " " +
            CurrentUser.Patronomyc;

            ShowCartItems();
        }

        public void ShowCartItems()
        {
            flowLayoutPanel.Controls.Clear();
            TotalSum = 0;

            ContextMenuStrip cartContextMenu = new ContextMenuStrip();
            cartContextMenu.Items.Add("Удалить");
            cartContextMenu.Items[0].Click += CartDeleteProduct_Click;

            using (var db = new FragrantWorldContext())
            {
                var carts = db.Carts.Where(x => x.ClientId == CurrentUser.Id).ToList();
                if (carts.Count() > 0 && comboBoxPickUpPoint.SelectedIndex != 0)
                {
                    buttonMakeOrder.Enabled = true;
                }
                else
                {
                    buttonMakeOrder.Enabled = false;
                }
                List<Product> products = new List<Product>();
                List<CartModel> cartModels = new List<CartModel>();
                foreach (var cart in carts)
                {
                    var product = db.Products.Where(x => x.ArticleNumber == cart.ProductArticleNumber).First();

                    cartModels.Add(new CartModel
                    {
                        Id = cart.Id,
                        Amount = cart.Amount,
                        ArticleNumber = product.ArticleNumber,
                        CurrentDiscount = product.CurrentDiscount,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        ManufacturerId = product.ManufacturerId,
                        Name = product.Name,
                        Price = product.Price,
                        StorageAmount = product.StorageAmount,
                    });
                    TotalSum += product.Price * (100 - (decimal)product.CurrentDiscount) / 100 * cart.Amount;
                }

                toolStripStatusLabelTotalSum.Text = "Итого: " + TotalSum.ToString() + " руб.";

                foreach (var cartModel in cartModels)
                {
                    var cartControl = new CartControl(cartModel);
                    cartControl.ContextMenuStrip = cartContextMenu;
                    flowLayoutPanel.Controls.Add(cartControl);
                }
            }
        }

        private void CartDeleteProduct_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить товар из корзины?", "Удаление!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CartControl cartControl = ((sender as ToolStripItem).Owner as ContextMenuStrip).SourceControl as CartControl;

                using (var db = new FragrantWorldContext())
                {
                    db.Carts.Remove(db.Carts.Where(x => x.Id == cartControl.CartModel.Id).First());
                    db.SaveChanges();
                }
                ShowCartItems();
            }
        }
        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            var code = new Random().Next(111, 999);
            using (var db = new FragrantWorldContext())
            {
                var number = db.Orders.OrderBy(x => x.Number).Last().Number + 1;
                var pickUpPoint = db.PickUpPoints.Where(x => x == comboBoxPickUpPoint.SelectedItem).First();
                foreach (CartControl cartControl in flowLayoutPanel.Controls)
                {
                    var cart = db.Carts.Where(x => x.Id == cartControl.CartModel.Id).First();
                    var order = new Order()
                    {
                        Amount = cartControl.CartModel.Amount,
                        ClientId = cart.ClientId,
                        ProductArticleNumber = cart.ProductArticleNumber,
                        Number = number,
                        PickUpPoint = pickUpPoint,
                        OrderDate = DateTimeOffset.Now,
                        Code = code,
                        DeliveryDate = DateTimeOffset.Now.AddDays(3),
                        IsActive = true,
                    };
                    db.Orders.Add(order);
                    db.Carts.Remove(cart);
                }
                db.SaveChanges();
                MessageBox.Show("Ваш заказ с номером " + number + " оформлен." +
                    "Код для получения: " + code, "Оформление заказа");
            }

            ShowCartItems();
        }

        private void CartForm_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabelTotalSum.Text = "Итого: " + TotalSum.ToString() + " руб.";
        }

        private void comboBoxPickUpPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new FragrantWorldContext())
            {
                var carts = db.Carts.Where(x => x.ClientId == CurrentUser.Id).ToList();
                if (carts.Count() > 0 && comboBoxPickUpPoint.SelectedIndex != 0)
                {
                    buttonMakeOrder.Enabled = true;
                }
                else
                {
                    buttonMakeOrder.Enabled = false;
                }
            }
        }
    }
}
