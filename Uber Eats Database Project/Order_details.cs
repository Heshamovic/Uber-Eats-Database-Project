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
    public partial class Order_details : Form
    {
        public int c_order;
        int z = 0;
       
        public OrderDetails_Item[] orderDetails_Items;
        OracleConnection con;

        public Order_details()
        {
            InitializeComponent();
        }

        private void Order_details_Load(object sender, EventArgs e)
        {
            MessageBox.Show(c_order.ToString());
            con = new OracleConnection(Helper.constr);
            con.Open();
            OracleCommand cmd9 = new OracleCommand();
            cmd9.Connection = con;
            cmd9.CommandText = "Count_GetCartItems";
            cmd9.CommandType = CommandType.StoredProcedure;
            cmd9.Parameters.Add("id", c_order);
            cmd9.Parameters.Add("cnt", OracleDbType.Int32, ParameterDirection.Output);
            cmd9.ExecuteNonQuery();
            z = int.Parse(cmd9.Parameters["cnt"].Value.ToString());
            con.Close();

            con = new OracleConnection(Helper.constr);
            con.Open();
            OracleCommand cmd10 = new OracleCommand();
            cmd10.Connection = con;
            cmd10.CommandText = "GetCartItems";
            cmd10.CommandType = CommandType.StoredProcedure;
            cmd10.Parameters.Add("id", c_order);
            cmd10.Parameters.Add("rows", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd10.ExecuteReader();
            orderDetails_Items = new OrderDetails_Item[z];

            int i = 0;
            while (dr.Read())
            {
                orderDetails_Items[i] = new OrderDetails_Item();
                orderDetails_Items[i].Food_Name1.Text = dr[0].ToString();
                orderDetails_Items[i].RestName1.Text = dr[1].ToString();
                orderDetails_Items[i].RestLoc1.Text = dr[2].ToString();
                orderDetails_Items[i].Price1.Text = dr[3].ToString();
                orderDetails_Items[i].Discount1.Text = dr[4].ToString();
                orderDetails_Items[i].No_of_items1.Text = dr[5].ToString();
                Order_Details_Panel.Controls.Add(orderDetails_Items[i]);
                i++;
            }
            dr.Close();
            con.Close();
        }

        private void Order_detail_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
