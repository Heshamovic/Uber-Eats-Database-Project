﻿using System;
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
            con.Close();

            con = new OracleConnection(Helper.constr);
            con.Open();
            OracleCommand cmd7 = new OracleCommand();
            cmd7.Connection = con;
            cmd7.CommandText = "GetAllOrders";
            cmd7.CommandType = CommandType.StoredProcedure;
            cmd7.Parameters.Add("username", Helper.currentUserName);
            cmd7.Parameters.Add("rows", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd7.ExecuteReader();
            
            userOrderItems = new UserOrderItem[userorders_count];

            int i = 0;
            int totalprice = 0;
            while (dr.Read())
            {
                userOrderItems[i] = new UserOrderItem();
                userOrderItems[i].Order_Number.Text = ("Order Number: "+dr[0].ToString());
                userOrderItems[i].Order_Time.Text = ("Order Date: " + dr[1].ToString());
                userOrderItems[i].Order_Status.Text = ("Order Status: " + dr[2].ToString());
                userOrderItems[i].cur_order = Convert.ToInt32(dr[0]);

                OracleCommand cmd8 = new OracleCommand();
                cmd8.Connection = con;
                cmd8.CommandText = "Order_Total_Price";
                cmd8.CommandType = CommandType.StoredProcedure;
                cmd8.Parameters.Add("orderno", Convert.ToInt32(dr[0]));
                cmd8.Parameters.Add("r", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader dr1 = cmd8.ExecuteReader();
                while(dr1.Read())
                {
                    totalprice += (Convert.ToInt32(dr1[1]) * Convert.ToInt32(dr1[2]));
                }

                userOrderItems[i].Price_integer.Text = ( totalprice.ToString()+ "LE");
                totalprice = 0;

                //userOrderItems[i].RestName.Text = dr[1].ToString();
                //cartItems[i].RestLoc.Text = dr[2].ToString();
                //cartItems[i].Price.Text = dr[3].ToString();
                //cartItems[i].Discount.Text = (dr[4]).ToString();
                //cartItems[i].NoOfItems.Text = (dr[5]).ToString();
                //cartItems[i].cart_id = i;
          
                User_Order_Panel.Controls.Add(userOrderItems[i]);
                i++;

            }
            dr.Close();

            con.Close();
        }
    }
}