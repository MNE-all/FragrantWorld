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
        public CartForm(User user)
        {
            CurrentUser = user;
            InitializeComponent();

            using (var db = new FragrantWorldContext())
            {
                foreach (var pickUpPoint in db.PickUpPoints.ToList())
                {
                    comboBoxPickUpPoint.Items.Add(pickUpPoint);
                }
            }

            labelFullName.Text = CurrentUser.Surname + " " +
            CurrentUser.Name + " " +
            CurrentUser.Patronomyc;

            ShowCartItems();
        }

        private void ShowCartItems()
        {
            flowLayoutPanel.Controls.Clear();

            ContextMenuStrip cartContextMenu = new ContextMenuStrip();
            cartContextMenu.Items.Add("Удалить");
            cartContextMenu.Items[0].Click += CartDeleteProduct_Click;

            using (var db = new FragrantWorldContext())
            {
                var carts = db.Carts.Where(x => x.ClientId == CurrentUser.Id).ToList();
                if(carts.Count() > 0)
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
                        UnitOfMeasurement = product.UnitOfMeasurement,
                    });
                }

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

        private void CartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
