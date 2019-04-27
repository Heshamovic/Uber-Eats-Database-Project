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

            this.foodimg.Image = Image.FromFile(img);

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
            
            Entities ent = new Entities();
            if (ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).Count() > 0)
            {
                ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).First().NO_OF_ITEMS_PER_FOOD += this.numericUpDown1.Value;

            }
            else {
                ORDER_FOOD x = new ORDER_FOOD();
                x.ORDER_ID = Helper.currentOrderId;
                x.RESTAURANT_NAME = resn.Text;
                x.RESTAURANT_LOCATION = resl.Text;
                x.FOOD_NAME = this.name.Text;
                x.NO_OF_ITEMS_PER_FOOD = this.numericUpDown1.Value;
                x.BOUGHT = "n";
                ent.ORDER_FOOD.Add(x);

            }
            ent.SaveChanges();
        }

        private void foodimg_Click(object sender, EventArgs e)
        {

        }
    }
}
