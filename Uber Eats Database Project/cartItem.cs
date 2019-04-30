using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Diagnostics;

namespace Uber_Eats_Database_Project
{
    public partial class cartItem : UserControl
    {
        OracleConnection con;
        public int cart_id;
        public cartItem()
        {
            InitializeComponent();
        }

        private void cartItem_Load(object sender, EventArgs e)
        {
            RestLoc.Visible = false;
        }
        
        private void Remove_Click(object sender, EventArgs e)
        {
            if (CustomMsgBox.Show("Are you sure to delete this item", 2) == DialogResult.Yes)
            {
                con = new OracleConnection(Helper.constr);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update_Order_food_price";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("OrderID", Helper.currentOrderId);
                decimal price = NoOfItems.Value * Convert.ToDecimal(Price.Text);
                cmd.Parameters.Add("Food_p", price);
                cmd.ExecuteNonQuery();

                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = con;
                cmd3.CommandText = "Delete_Cart_Item";
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add("id", Helper.currentOrderId);
                cmd3.Parameters.Add("rest_name", RestName.Text);
                cmd3.Parameters.Add("rest_loc", RestLoc.Text);
                cmd3.Parameters.Add("food_name", FoodName.Text);
                cmd3.ExecuteNonQuery();
                con.Close();
                this.Parent.Controls.Remove(this);

            }
        }
    }
}
