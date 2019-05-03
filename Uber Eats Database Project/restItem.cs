using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_Eats_Database_Project
{
    public partial class restItem : UserControl
    {
        public restItem(string img, string name, string loc, int rating, string type)
        {
            InitializeComponent();
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
            this.name.Text = name;
            this.location.Text = loc;
            this.type.Text = type;
            this.bunifuRating1.Value = rating;
        }
        public void letsShow(object sender, FormClosingEventArgs e)
        {
            this.Parent.Parent.Parent.Parent.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            resfood r = new resfood(name.Text, location.Text);
            r.Show();
            this.Parent.Parent.Parent.Parent.Hide();
            r.FormClosing += letsShow;
        }
    }
}
