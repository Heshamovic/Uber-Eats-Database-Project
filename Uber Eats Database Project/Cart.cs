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
namespace Uber_Eats_Database_Project
{ 
    public partial class Cart : Form
    {
        public int x;
        public cartItem[] cartItems;
        OracleConnection con;

        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(Helper.constr);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "Count_GetCartItems";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", Helper.currentOrderId);
            cmd.Parameters.Add("cnt", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            x = int.Parse(cmd.Parameters["cnt"].Value.ToString());
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "GetCartItems";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("id", Helper.currentOrderId);
            cmd2.Parameters.Add("rows", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd2.ExecuteReader();
            cartItems = new cartItem[x];
            int i = 0;
            while (dr.Read())
            {
                cartItems[i] = new cartItem();
                cartItems[i].FoodName.Text = dr[0].ToString();
                cartItems[i].RestName.Text = dr[1].ToString();
                cartItems[i].RestLoc.Text = dr[2].ToString();
                cartItems[i].Price.Text = dr[3].ToString();
                cartItems[i].Discount.Text = (dr[4]).ToString();
                cartItems[i].NoOfItems.Text = (dr[5]).ToString();
                cartItems[i].cart_id = i;
                flowLayoutPanel1.Controls.Add(cartItems[i]);
                i++;
            }
            dr.Close();
            if(x == 0)
            {
                Confirm.Enabled = false;
            }
        }
        

        private void Confirm_Click(object sender, EventArgs e)
        {
            int z = flowLayoutPanel1.Controls.Count;
            for(int i = 0; i < z; i++)
            {
                OracleCommand cmd4 = new OracleCommand();
                cmd4.Connection = con;
                cmd4.CommandText = "Update_Cart_Items";
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.Add("id", Helper.currentOrderId);
                cmd4.Parameters.Add("rest_name", cartItems[i].RestName.Text);
                cmd4.Parameters.Add("rest_loc", cartItems[i].RestLoc.Text);
                cmd4.Parameters.Add("food_name", cartItems[i].FoodName.Text);
                cmd4.Parameters.Add("no_of_items", cartItems[i].NoOfItems.Text);
                cmd4.ExecuteNonQuery();
            }
            decimal totalprice = 0;
            OracleCommand cmd8 = new OracleCommand();
            cmd8.Connection = con;
            cmd8.CommandText = "Order_Total_Price";
            cmd8.CommandType = CommandType.StoredProcedure;
            cmd8.Parameters.Add("orderno", Helper.currentOrderId);
            cmd8.Parameters.Add("r", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr1 = cmd8.ExecuteReader();
            while (dr1.Read())
            {
                totalprice += (Convert.ToDecimal(dr1[1]) * Convert.ToDecimal(dr1[2]));
            }
            Entities ent = new Entities();
            ORDER ord = ent.ORDERS.Where(h => h.ORDER_ID == Helper.currentOrderId).First();
            ord.FOOD_PRICE = totalprice;
            ent.SaveChanges();

            if (z > 0)
            {
               
                OracleCommand cmd5 = new OracleCommand();
                cmd5.Connection = con;
                cmd5.CommandText = "Update_Order_Status_nc_to_pp";
                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.Parameters.Add("id", Helper.currentOrderId);
                cmd5.ExecuteNonQuery();
                OracleCommand cmd = new OracleCommand("Create_Cart", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("un", Helper.currentUserName);
                cmd.ExecuteNonQuery();
                CustomMsgBox.Show("Order Confirmed");
                Helper.currentOrderId = Helper.getCartId();

            }
            this.Close();
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

        #region buttons hovers
        private void Confirm_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void Confirm_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }
    

        private void Cart_MouseMove(object sender, MouseEventArgs e)
        { 
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                Confirm.Enabled = false;
            }
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                Confirm.Enabled = false;
            }
        }
        #endregion

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
