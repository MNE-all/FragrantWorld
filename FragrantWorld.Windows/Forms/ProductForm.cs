using FragrantWorld.Context;

namespace FragrantWorld.Windows
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            using (var db = new FragrantWorldContext())
            {
                var products = db.Products.ToList();
                foreach (var product in products)
                {
                    var productControl = new ProductControll(product);
                    productControl.Width = flowLayoutPanel.Width;

                    flowLayoutPanel.Controls.Add(productControl);
                }
            }
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}