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
    public partial class rest : Form
    {
        OracleConnection Conn;
        public rest()
        {
            InitializeComponent();
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rest_Load(object sender, EventArgs e)
        {
            Conn = new OracleConnection(Helper.constr);
            Conn.Open();
            FolderBrowserDialog b = new FolderBrowserDialog();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from restaurant";
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            OracleDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                restItem x = new restItem(red[4].ToString(), red[0].ToString(), red[1].ToString(), Convert.ToInt32(red[2]), red[3].ToString());
                x.Margin = new Padding(0, 15, 0, 0);
                flowLayoutPanel1.Controls.Add(x);
            }
            red.Close();
        }
        public void letsShow(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cart r = new Cart();
            r.Show();
            this.Hide();
            r.FormClosing += letsShow;
        }

        private void rest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conn.Dispose();
        }
        #region Buttons Hovers
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.White);
        }
        #endregion
    }
}
