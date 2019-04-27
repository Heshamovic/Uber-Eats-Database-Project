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

namespace Uber_Eats_Database_Project
{
    public partial class resfooditem : UserControl
    { 
        public resfooditem( string name , string discount ,string price,double rating , string img,string top,string ing,string resn,string resl)
        { //// name  discount  
            /// 0  3 4 5  6 7 8
            InitializeComponent();

            //this.foodimg.Image = Image.FromFile(img);

            this.name.Text = name;

            this.discount.Text = discount;
            this.price.Text = price;
            if (top != "True")
            {
                topdish.Hide();
            }

            double x = Math.Round(rating);

            this.bunifuRating1.Value = Convert.ToInt32(x);
            this.resn.Text = resn;
            this.resl.Text = resl;
            this.resl.Hide();
            this.resn.Hide();
            this.ing.Text = ing;
        }

        private void resfooditem_Load(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(Helper.constr);
            con.Open();
            OracleCommand cmd = new OracleCommand("insert into order_food values(:id, :resn, :resl, :foodn, :noi, 'N')", con);
            cmd.Parameters.Add("id", Helper.currentOrderId);
            cmd.Parameters.Add("resn", this.resn.Text);
            cmd.Parameters.Add("resl", this.resl.Text);
            cmd.Parameters.Add("foodn", this.name.Text);
            cmd.Parameters.Add("noi",this.numericUpDown1.Value );
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
