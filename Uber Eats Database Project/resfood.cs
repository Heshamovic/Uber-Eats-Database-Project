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
        string img, resn;
        public resfood(string id )
        {
            InitializeComponent();
            this.resn = id;
        }

        private void resfood_Load(object sender, EventArgs e)
        {
            OracleDataAdapter oda = new OracleDataAdapter(
                "select * from food where food.restaurant_name = :resn", Helper.constr);
            OracleCommandBuilder ocb = new OracleCommandBuilder(oda);
            DataSet ds = new DataSet();
            oda.SelectCommand.Parameters.Add("resn", resn);
            oda.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][8] != null)
                    img = ds.Tables[0].Rows[i][8].ToString();
                else
                    img = "NoCamera_32px.png";
                resfooditem r = new resfooditem(ds.Tables[0].Rows[i][0].ToString(),
                    ds.Tables[0].Rows[i][4].ToString(),
                    ds.Tables[0].Rows[i][3].ToString(),
                    Convert.ToInt32(ds.Tables[0].Rows[i][5]),
                    img,
                    ds.Tables[0].Rows[i][7].ToString(),
                    ds.Tables[0].Rows[i][6].ToString(),
                    ds.Tables[0].Rows[i][1].ToString(),
                    ds.Tables[0].Rows[i][2].ToString());
                flowLayoutPanel1.Controls.Add(r);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void letsShow(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart r = new Cart();
            r.Show();
            this.Hide();
            r.FormClosing += letsShow;
        }
    }
}
