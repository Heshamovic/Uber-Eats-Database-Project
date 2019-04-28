using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_Eats_Database_Project
{
    public partial class restItem : UserControl
    {
        public restItem(string img, string name, double rating, string type)
        {
            InitializeComponent();
           
            //this.foodimg.Image = Image.FromFile(img);
           
            this.name.Text = name;
           
            this.type.Text = type;

            double x = Math.Round(rating);
            
            this.bunifuRating1.Value =  Convert.ToInt32(x);
        }
        public void letsShow(object sender, FormClosingEventArgs e)
        {
            this.Parent.Parent.Parent.Parent.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            resfood r = new resfood(this.name.Text);
            r.Show();
            this.Parent.Parent.Parent.Parent.Hide();
            r.FormClosing += letsShow;
        }
    }
}
