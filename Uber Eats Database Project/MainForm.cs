using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;

namespace Uber_Eats_Database_Project
{
    public partial class MainForm : Form
    {
        private int oid = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToggleUser();
        }
        private void ToggleUser()
        {
            UsernameLabel.Text = "Welcome, " + Helper.currentUserName;
            bool UserEnable = true; // User unless
            if (Helper.currentUserRole == 2) // Delivery Partner
                UserEnable = false;
            oid = 0;
            //Enable Partner Controls
            Entities ent = new Entities();
            oid = (from o in ent.ORDERS
                   join t in ent.TRIPs on o.ORDER_ID equals t.ORDER_ID
                   where t.DELIVERYPARTNER_USERNAME == Helper.currentUserName
                   && o.STATUS == "pd"
                   select o.ORDER_ID).Count();
            PendingOrdersBtn.Enabled = !UserEnable;
            PendingOrdersBtn.Visible = !UserEnable;
            DeliveredOrdersBtn.Enabled = !UserEnable;
            DeliveredOrdersBtn.Visible = !UserEnable;
            DAccountBtn.Enabled = !UserEnable;
            DAccountBtn.Visible = !UserEnable;
            CurrentOrderBtn.Enabled = !UserEnable & (oid != 0);
            CurrentOrderBtn.Visible = !UserEnable & (oid != 0);
            //Disable Customer Controls
            OrdersBtn.Enabled = UserEnable;
            OrdersBtn.Visible = UserEnable;
            AccountBtn.Enabled = UserEnable;
            AccountBtn.Visible = UserEnable;
            CartBtn.Enabled = UserEnable;
            CartBtn.Visible = UserEnable;
            MenusBtn.Enabled = UserEnable;
            MenusBtn.Visible = UserEnable;
        }
        
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenusBtn_Click(object sender, EventArgs e)
        {
            Helper.currentOrderId = Helper.getCartId();
            rest r = new rest();
            r.Show();
            this.Hide();
            r.FormClosing += letsShow;
        }

        private void DAccountBtn_Click(object sender, EventArgs e)
        {
            PartnerAccount acc = new PartnerAccount();
            acc.Show();
            this.Hide();
            acc.FormClosing += letsShow;
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            CustomerAccount ac = new CustomerAccount();
            ac.Show();
            this.Hide();
            ac.FormClosing += letsShow;
        }

        private void DeliveredOrdersBtn_Click(object sender, EventArgs e)
        {
            OrdersDeliveryPartner d = new OrdersDeliveryPartner(2);
            d.Show();
            this.Hide();
            d.FormClosing += letsShow;
        }

        private void PendingOrdersBtn_Click(object sender, EventArgs e)
        {
            if (oid == 0)
            {
                OrdersDeliveryPartner p = new OrdersDeliveryPartner(1);
                p.Show();
                this.Hide();
                p.FormClosing += letsShow;
            }
            else
                CustomMsgBox.Show("Please Finish your Current Order before you take any other order.");
        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            Cart c = new Cart();
            Helper.currentOrderId = Helper.getCartId();
            c.Show();
            this.Hide();
            c.FormClosing += letsShow;
        }

        private void CurrentOrderBtn_Click(object sender, EventArgs e)
        {
            PendingDelivering pd = new PendingDelivering();
            pd.Show();
            this.Hide();
            pd.FormClosing += letsShow;
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            UserOrders o = new UserOrders();
            o.Show();
            this.Hide();
            o.FormClosing += letsShow;
        }

        public void letsShow(object sender, FormClosingEventArgs e)
        {
            ToggleUser();
            this.Show();
        }
    
        #region Buttons Hovers
        private void DAccountBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void DAccountBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void MenusBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void AccountBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void DeliveredOrdersBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void PendingOrdersBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void CartBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void OrdersBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void AccountBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void MenusBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void PendingOrdersBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void CartBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void OrdersBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void DeliveredOrdersBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }
        private void CurrentOrderBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void CurrentOrderBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        #endregion
    }
}
