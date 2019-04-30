using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Uber_Eats_Database_Project
{
    public partial class resfooditem : UserControl
    {
        Entities ent = new Entities();
        public resfooditem( string name , string discount ,string price,double rating , string img,string top,string ing,string resn,string resl)
        { 
            InitializeComponent();
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
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).Count() > 0)
            {
                ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).First().NO_OF_ITEMS_PER_FOOD += this.numericUpDown1.Value;
                ent.SaveChanges();
            }
            else
            {
                ORDER_FOOD newItem = new ORDER_FOOD();
                newItem.RESTAURANT_NAME = resn.Text;
                newItem.RESTAURANT_LOCATION = resl.Text;
                newItem.FOOD_NAME = name.Text;
                newItem.NO_OF_ITEMS_PER_FOOD = numericUpDown1.Value;
                newItem.BOUGHT = "n";
                newItem.ORDER_ID = Helper.currentOrderId;
                ent.ORDER_FOOD.AddOrUpdate(newItem);
                ent.SaveChanges();
            }
        }

        private void foodimg_Click(object sender, EventArgs e)
        {
            /*OracleConnection con = new OracleConnection(Helper.constr);
            con.Open();
            OracleCommand cmd = new OracleCommand("insert into order_food values(:id, :resn, :resl, :foodn, :noi, 'N')", con);
            cmd.Parameters.Add("id", Helper.currentOrderId);
            cmd.Parameters.Add("resn", this.resn.Text);
            cmd.Parameters.Add("resl", this.resl.Text);
            cmd.Parameters.Add("foodn", this.name.Text);
            cmd.Parameters.Add("noi",this.numericUpDown1.Value );
            cmd.ExecuteNonQuery();
            con.Close();*/
        }
    }
}
