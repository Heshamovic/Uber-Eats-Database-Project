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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //Remove.Text = "Removed";
            //Hidden.Text = cart_id.ToString();
            if (MessageBox.Show("Are you sure to delete this item", "delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con = new OracleConnection(Helper.constr);
                con.Open();
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = con;
                cmd3.CommandText = "Delete_Cart_Item";
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add("id", Helper.currentOrderId);
                cmd3.Parameters.Add("rest_name", RestName.Text);
                cmd3.Parameters.Add("rest_loc", RestLoc.Text);
                cmd3.Parameters.Add("food_name", FoodName.Text);
                cmd3.ExecuteNonQuery();

                // MessageBox.Show(x.ToString());

                con.Close();
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
