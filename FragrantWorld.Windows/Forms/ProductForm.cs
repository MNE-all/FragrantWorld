using FragrantWorld.Context;
using FragrantWorld.Context.Models;
using FragrantWorldWinFormsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FragrantWorld.Windows
{
    public partial class ProductForm : Form
    {
        public User CurrentUser { get; set; }
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

                db.Users.Add(CurrentUser);
                db.SaveChanges();
            }

            labelEnterAs.Visible = false;
            labelFullName.Visible = false;
        }
        public ProductForm(User user)
        {
            CustomInit();
            labelSignIn.Text = "�����";

            CurrentUser = user;

            labelFullName.Text = CurrentUser.Surname + " " +
                CurrentUser.Name + " " +
                CurrentUser.Patronomyc;
        }

        private void CustomInit()
        {
            InitializeComponent();

            ContextMenuStrip productContextMenu = new ContextMenuStrip();
            var i = productContextMenu.Items.Add("�������� � ������");
            productContextMenu.Items[0].Click += ProductAdd_Click;

            using (var db = new FragrantWorldContext())
            {
                var products = db.Products.ToList();
                foreach (var product in products)
                {
                    var productControl = new ProductControll(product);
                    productControl.Width = flowLayoutPanel.Width;
                    productControl.ContextMenuStrip = productContextMenu;

                    flowLayoutPanel.Controls.Add(productControl);
                }
            }

            comboBoxDisountFilter.Items.Add("��� ���������");
            comboBoxDisountFilter.Items.Add("0-9,99%");
            comboBoxDisountFilter.Items.Add("10-14,99%");
            comboBoxDisountFilter.Items.Add("15% � �����");

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
                    if (ex.InnerException.Message.Contains("������������� �������� �����"))
                    {
                        MessageBox.Show("����� ��� � �������", "������ ���������� � �������");
                    }
                    else
                    {
                        MessageBox.Show(ex.InnerException.Message);
                    }

                }
            }
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}