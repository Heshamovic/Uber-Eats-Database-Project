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
    public partial class resfood : Form
    {
        OracleConnection Conn;
        string img = "NoCamera_32px.png";
        string resn;
        public resfood(string id )
        {
            InitializeComponent();
            this.resn = id;
        }

        private void resfood_Load(object sender, EventArgs e)
        {
            Conn = new OracleConnection(Helper.constr);
            Conn.Open();
            FolderBrowserDialog b = new FolderBrowserDialog();
            string img = "NoCamera_32px.png";
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from food where food.restaurant_name =:resn";
            cmd.Parameters.Add("resn",resn);
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            OracleDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {

                if (red[8] != null)
                {
                    img = red[8].ToString();
                }
                resfooditem r = new resfooditem(name: red[0].ToString(), price: red[3].ToString(), discount: red[4].ToString(), 
                    rating: Convert.ToDouble(red[5]), ing: red[6].ToString(), top: red[7].ToString(), img:img,
                    resn:red[1].ToString(),resl:red[2].ToString());
                flowLayoutPanel1.Controls.Add(r);
            }
            red.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void resfood_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conn.Dispose();
        }
    }
}
