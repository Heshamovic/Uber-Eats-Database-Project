using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
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
        string ingrediants = "Secret Ingrediants", type = "";
        public resfooditem(string name, string discount, string price, int rating, string img, string top, string ing, string resn, string resl, string typ)
        { 
            InitializeComponent();
            this.type = typ;
            this.name.Text = name;
            this.discount.Text = discount;
            this.price.Text = price;
            if (top != "True")
            {
                topdish.Hide();
            }
            bunifuRating1.Value = rating;
            this.resn.Text = resn;
            this.resl.Text = resl;
            if (ing != "")
                ingrediants = ing;
            img = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "resources\\") + img;
            try
            {
                this.foodimg.Image = Image.FromFile(img);
            }
            catch
            {
                img = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "resources\\NO Image Available.jpg");
                this.foodimg.Image = Image.FromFile(img);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Entities ent = new Entities();
            ORDER_FOOD ordf = new ORDER_FOOD();
            ordf.BOUGHT = "n";
            ordf.FOOD_NAME = name.Text;
            ordf.NO_OF_ITEMS_PER_FOOD = Convert.ToInt32(numericUpDown1.Value);
            ordf.ORDER_ID = Helper.currentOrderId;
            ordf.RESTAURANT_LOCATION = resl.Text;
            ordf.RESTAURANT_NAME = resn.Text;
            if (ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).Count() > 0)
            {
                ordf.NO_OF_ITEMS_PER_FOOD += ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).First().NO_OF_ITEMS_PER_FOOD;
            }
            ent.ORDER_FOOD.AddOrUpdate(ordf);
            ent.SaveChanges();
        }
        #region Buttons Hovers
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.White);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }
        #endregion

        private void foodimg_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomMsgBox.Show("Type: " + type + "\nIngerdiants: " + ingrediants);
        }
        
    }
}
