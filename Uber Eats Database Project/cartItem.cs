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
        
        private void Remove_Click(object sender, EventArgs e)
        {
            if (CustomMsgBox.Show("Are you sure to delete this item", 2) == DialogResult.Yes)
            {
                con = new OracleConnection(Helper.constr);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "Delete_Cart_Item";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", Helper.currentOrderId);
                cmd.Parameters.Add("rest_name", RestName.Text);
                cmd.Parameters.Add("rest_loc", RestLoc.Text);
                cmd.Parameters.Add("food_name", FoodName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
