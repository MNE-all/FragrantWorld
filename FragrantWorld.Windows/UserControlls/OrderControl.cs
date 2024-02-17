using FragrantWorld.Context;
using FragrantWorld.Context.Models;

namespace FragrantWorld.Windows.UserControlls
{
    public partial class OrderControl : UserControl
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products = new List<Product>();
        public decimal Price { get; set; } = 0;
        public OrderControl(int orderNumber)
        {
            InitializeComponent();
            labelOrderNumber.Text = orderNumber.ToString();

            using (var db = new FragrantWorldContext())
            {
                Orders = db.Orders.Where(x => x.Number == orderNumber).ToList();

                foreach (var order in Orders)
                {
                    var product = db.Products.First(x => x.ArticleNumber == order.ProductArticleNumber);
                    Products.Add(product);

                    Price += product.Price * (100 - (decimal)product.CurrentDiscount) / 100 * order.Amount;

                    listBoxProducts.Items.Add(product);
                    listBoxAmount.Items.Add(order.Amount);
                }
                labelTotalSum.Text = Price.ToString();
            }
        }
    }
}
