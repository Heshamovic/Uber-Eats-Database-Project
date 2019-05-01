﻿using System;
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
            Entities ent = new Entities();
            ORDER_FOOD ordf = new ORDER_FOOD();
            ordf.BOUGHT = "n";
            ordf.FOOD_NAME = name.Text;
            ordf.NO_OF_ITEMS_PER_FOOD = Convert.ToInt32(numericUpDown1.Value);
            ordf.ORDER_ID = Helper.currentOrderId;
            ordf.RESTAURANT_LOCATION = resl.Text;
            ordf.RESTAURANT_NAME = resn.Text;
            int c = 0;
            if (ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).Count() > 0)
            {
                ordf.NO_OF_ITEMS_PER_FOOD += ent.ORDER_FOOD.Where(x => x.ORDER_ID == Helper.currentOrderId && x.RESTAURANT_NAME == resn.Text &&
                x.RESTAURANT_LOCATION == resl.Text && x.FOOD_NAME == this.name.Text).First().NO_OF_ITEMS_PER_FOOD;
            }
            ent.ORDER_FOOD.AddOrUpdate(ordf);
            ent.SaveChanges();
        }

        private void foodimg_Click(object sender, EventArgs e)
        {
            
        }
    }
}
