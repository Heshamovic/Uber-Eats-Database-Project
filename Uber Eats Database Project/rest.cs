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
           string str= Helper.constr;

        public rest()
        {
            InitializeComponent();
        }

        private void restItem1_Load(object sender, EventArgs e)
        {  
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rest_Load(object sender, EventArgs e)
        {
            FolderBrowserDialog b = new FolderBrowserDialog();
            string img = "NoCamera_32px.png";
            OracleConnection Conn = new OracleConnection(str);
            Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from restaurant";
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            OracleDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                //if (red[4] != null)
                //{
                //    img = red[4].ToString();
                //}
                restItem x = new restItem(img, red[0].ToString(), Convert.ToDouble(red[2].ToString()), red[3].ToString());
                x.Margin = new Padding(0, 15, 0, 0);
                flowLayoutPanel1.Controls.Add(x);
            }
            red.Close();
            Conn.Close();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
