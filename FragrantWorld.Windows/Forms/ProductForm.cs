using FragrantWorld.Context;
using FragrantWorld.Context.Models;
using FragrantWorld.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace FragrantWorld.Windows
{
    public partial class ProductForm : Form
    {
        public User CurrentUser { get; set; }

        public List<Product> Products = new List<Product>();
        public ProductForm()
        {
            CustomInit();

            using (var db = new FragrantWorldContext())
            {
                var userId = db.Users.OrderBy(u => u.Id).Last().Id + 1;
                CurrentUser = new User
                {
                    Name = "Guest" + userId,
                    Surname = "",
                    Login = "Guest" + userId,
                    Password = new Random().Next(100).ToString() + "Guest" + userId,
                    Role = db.Roles.OrderBy(x => x.Id).First(),
                };

                CurrentUser = db.Users.Add(CurrentUser).Entity;
                db.SaveChanges();
            }

            labelEnterAs.Visible = false;
            labelFullName.Visible = false;
        }
        public ProductForm(User user)
        {
            CurrentUser = user;
            CustomInit();
            ValidateCart();
            labelSignIn.Text = "Выйти";

            labelFullName.Text = CurrentUser.Surname + " " +
                CurrentUser.Name + " " +
                CurrentUser.Patronomyc;
        }

        private void CustomInit()
        {
            InitializeComponent();
            using (var db = new FragrantWorldContext())
            {
                Products = db.Products.ToList();
            }
            ShowProducts();



            comboBoxDisountFilter.Items.Add("Все диапозоны");
            comboBoxDisountFilter.Items.Add("0-9,99%");
            comboBoxDisountFilter.Items.Add("10-14,99%");
            comboBoxDisountFilter.Items.Add("15% и более");
            comboBoxDisountFilter.SelectedIndex = 0;

        }

        private void ShowProducts()
        {
            flowLayoutPanel.Controls.Clear();

            ContextMenuStrip productContextMenu = new ContextMenuStrip();
            productContextMenu.Items.Add("Добавить к заказу");
            productContextMenu.Items[0].Click += ProductAdd_Click;


            foreach (var product in Products)
            {
                var productControl = new ProductControll(product);
                productControl.Width = flowLayoutPanel.Width;
                productControl.ContextMenuStrip = productContextMenu;

                flowLayoutPanel.Controls.Add(productControl);
            }

        }

        private void ProductAdd_Click(object? sender, EventArgs e)
        {
            ProductControll productControl = ((sender as ToolStripItem).Owner as ContextMenuStrip).SourceControl as ProductControll;
            var product = productControl.Product;

            using (var db = new FragrantWorldContext())
            {
                int? clientId = CurrentUser == null ? null : CurrentUser.Id;
                var cart = new Cart
                {
                    ClientId = clientId,
                    ProductArticleNumber = product.ArticleNumber,
                    Amount = 1,
                };
                db.Carts.Add(cart);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show(product.Description);
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException.Message.Contains("Повторяющееся значение ключа"))
                    {
                        MessageBox.Show("Товар уже в корзине", "Ошибка добавления в корзину");
                    }
                    else
                    {
                        MessageBox.Show(ex.InnerException.Message);
                    }

                }
            }

            ValidateCart();
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            foreach (ProductControll control in flowLayoutPanel.Controls)
            {
                control.Width = flowLayoutPanel.Width;
            }
        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            var from = new AuthForm();
            Hide();
            from.Show(this);
        }

        private void labelSignIn_MouseEnter(object sender, EventArgs e)
        {
            labelSignIn.ForeColor = Color.FromArgb(204, 102, 0);
        }

        private void labelSignIn_MouseLeave(object sender, EventArgs e)
        {
            labelSignIn.ForeColor = Color.FromKnownColor(KnownColor.HotTrack);

        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                using (var db = new FragrantWorldContext())
                {
                    if (db.Carts.Where(x => x.ClientId == CurrentUser.Id).Count() == 0 &&
                        db.Orders.Where(x => x.ClientId == CurrentUser.Id).Count() == 0 &&
                        CurrentUser.Name.Equals(CurrentUser.Login) && CurrentUser.Password.Contains(CurrentUser.Name))
                    {
                        db.Users.Remove(db.Users.First(x => x == CurrentUser));
                        db.SaveChanges();
                    }
                }
            }

            Application.Exit();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            var cartForm = new CartForm(CurrentUser);
            cartForm.ShowDialog();
            ValidateCart();
        }

        private void ValidateCart()
        {
            using (var db = new FragrantWorldContext())
            {
                if (db.Carts.Where(x => x.ClientId == CurrentUser.Id).Count() > 0)
                {
                    buttonCart.Visible = true;
                }
                else
                {
                    buttonCart.Visible = false;
                }
            }
        }

        private void comboBoxDisountFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilerProducts();
        }

        private void textBoxNameFind_TextChanged(object sender, EventArgs e)
        {
            FilerProducts();
        }

        private void FilerProducts()
        {
            using (var db = new FragrantWorldContext())
            {
                switch (comboBoxDisountFilter.SelectedItem)
                {
                    case "Все диапозоны":
                        Products = db.Products.ToList();
                        break;
                    case "0-9,99%":
                        Products = db.Products.Where(x => x.CurrentDiscount >= 0 && x.CurrentDiscount <= 9.99F).ToList();
                        break;
                    case "10-14,99%":
                        Products = db.Products.Where(x => x.CurrentDiscount >= 10 && x.CurrentDiscount <= 14.99F).ToList();

                        break;
                    case "15% и более":
                        Products = db.Products.Where(x => x.CurrentDiscount >= 15).ToList();
                        break;
                }
            }
            if (textBoxNameFind.Text != string.Empty)
            {
                Products = Products.Where(x => x.Name.Contains(textBoxNameFind.Text)).ToList();
            }
            ShowProducts();
        }
    }
}