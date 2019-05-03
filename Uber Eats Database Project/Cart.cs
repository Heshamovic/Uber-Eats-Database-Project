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
           
            decimal totalprice = 0, totaldiscount = 0;
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
                Entities ent = new Entities();
                ORDER ord = ent.ORDERS.Where(h => h.ORDER_ID == Helper.currentOrderId).First();
                Helper.currentOrderId = Helper.getCartId();

                OracleCommand cmd6 = new OracleCommand();
                cmd6.Connection = con;
                cmd6.CommandText = "Count_GetPoints";
                cmd6.CommandType = CommandType.StoredProcedure;
                cmd6.Parameters.Add("username", Helper.currentUserName);
                cmd6.Parameters.Add("cnt", OracleDbType.Int32, ParameterDirection.Output);
                cmd6.ExecuteNonQuery();
                Helper.points = int.Parse(cmd6.Parameters["cnt"].Value.ToString());
                if (Helper.points > 20)
                {
                    
                    decimal tmp = Math.Min(50, Helper.points / 2);
                    if (CustomMsgBox.Show("You have a " + tmp.ToString() + "% voucher.\n Do you want to use it?", 2) == DialogResult.Yes)
                    {
                        OracleCommand cmd7 = new OracleCommand();
                        cmd7.Connection = con;
                        cmd7.CommandText = "UPDATE_ORDER_STATUS_TO_DV";
                        cmd7.CommandType = CommandType.StoredProcedure;
                        cmd7.Parameters.Add("un", Helper.currentUserName);
                        cmd7.ExecuteNonQuery();
                        totaldiscount = (tmp / 100) * totalprice;
                    }
                }
                ord.FOOD_PRICE = totalprice - totaldiscount;
                ent.SaveChanges();
                CustomMsgBox.Show("Order Confirmed");
            }
            this.Close();
           
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            int h = flowLayoutPanel1.Controls.Count;
            for (int i = 0; i < h; i++)
            {
                OracleCommand cmd33 = new OracleCommand();
                cmd33.Connection = con;
                cmd33.CommandText = "Update_Cart_Items";
                cmd33.CommandType = CommandType.StoredProcedure;
                cmd33.Parameters.Add("id", Helper.currentOrderId);
                cmd33.Parameters.Add("rest_name", cartItems[i].RestName.Text);
                cmd33.Parameters.Add("rest_loc", cartItems[i].RestLoc.Text);
                cmd33.Parameters.Add("food_name", cartItems[i].FoodName.Text);
                cmd33.Parameters.Add("no_of_items", cartItems[i].NoOfItems.Text);
                cmd33.ExecuteNonQuery();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

         
        }
    }
}
