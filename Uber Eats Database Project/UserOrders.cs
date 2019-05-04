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
    public partial class UserOrders : Form
    {
        public int userorders_count;
        public UserOrderItem[] userOrderItems;
        OracleConnection con;
        public UserOrders()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserOrders_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(Helper.constr);
            con.Open();
            OracleCommand cmd6 = new OracleCommand();
            cmd6.Connection = con;
            cmd6.CommandText = "Count_GetAllOrders";
            cmd6.CommandType = CommandType.StoredProcedure;
            cmd6.Parameters.Add("username", Helper.currentUserName);
            cmd6.Parameters.Add("cnt", OracleDbType.Int32, ParameterDirection.Output);
            cmd6.ExecuteNonQuery();
            userorders_count = int.Parse(cmd6.Parameters["cnt"].Value.ToString());

            OracleCommand cmd7 = new OracleCommand();
            cmd7.Connection = con;
            cmd7.CommandText = "GetAllOrders";
            cmd7.CommandType = CommandType.StoredProcedure;
            cmd7.Parameters.Add("username", Helper.currentUserName);
            cmd7.Parameters.Add("rows", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd7.ExecuteReader();
            
            userOrderItems = new UserOrderItem[userorders_count];
            int i = 0;
            while (dr.Read())
            {
                userOrderItems[i] = new UserOrderItem();
                userOrderItems[i].cur_order = Convert.ToInt32(dr[0]);
                userOrderItems[i].Order_Number.Text = ("Order Number: " + dr[0].ToString());
                userOrderItems[i].Order_Time.Text = ("Order Date: " + dr[1].ToString());
                userOrderItems[i].Order_Status.Text = ("Order Status: " + dr[2].ToString());
                userOrderItems[i].Price_integer.Text = (dr[3].ToString() + "LE");
                User_Order_Panel.Controls.Add(userOrderItems[i++]);
            }
            dr.Close();
        }

        private void UserOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }
    }
}
