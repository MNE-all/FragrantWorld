using FragrantWorld.Context;
using FragrantWorld.Context.Models;
using FragrantWorld.Windows.UserControlls;
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
    public partial class OrdersForm : Form
    {
        public User Staff { get; set; }
        public OrdersForm(User user)
        {
            Staff = user;
            InitializeComponent();
            ShowOrders();
            
        }

        public void ShowOrders()
        {
            ContextMenuStrip orderContextMenu = new ContextMenuStrip();
            orderContextMenu.Items.Add("Редактировать");
            orderContextMenu.Items[0].Click += OrderUpdate_Click;

            using (var db = new FragrantWorldContext())
            {
                var orderNumbers = db.Orders.Where(x => x.ClientId == Staff.Id).GroupBy(x => x.Number).Select(x => x.Key);

                foreach (var order in orderNumbers)
                {
                    var orderControl = new OrderControl(order);
                    orderControl.ContextMenuStrip = orderContextMenu;
                    flowLayoutPanel.Controls.Add(orderControl);

                }
            }
        }

        private void OrderUpdate_Click(object? sender, EventArgs e)
        {
            OrderControl orderControl = ((sender as ToolStripItem).Owner as ContextMenuStrip).SourceControl as OrderControl;
            var form = new OrderUpdateForm(orderControl.Orders, orderControl.Products);
            form.ShowDialog();
        }
    }
}
