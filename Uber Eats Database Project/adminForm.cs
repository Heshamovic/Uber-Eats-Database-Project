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
    public partial class adminForm : Form
    {
        Entities ent = new Entities();
        public adminForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addResBtn_Click(object sender, EventArgs e)
        {
            Entities ent = new Entities();
            RESTAURANT r = new RESTAURANT();
            r.RESTAURANT_NAME = addRes.Text;
            r.RESTAURANT_LOCATION = resLoc.Text;
            r.RATING = int.Parse(ratingRest.Text);
            r.CUISINE_TYPE = cusineAdd.Text;
            ent.RESTAURANTs.Add(r);
            ent.SaveChanges();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            RestaurantsNamesUpdate.DataSource = ent.RESTAURANTs.Select(x => x.RESTAURANT_NAME).ToList();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ent.SaveChanges();
        }

        private void RestaurantsNamesUpdate_SelectedValueChanged(object sender, EventArgs e)
        {
            RESTAURANT r = ent.RESTAURANTs.Where(re => re.RESTAURANT_NAME == RestaurantsNamesUpdate.Text).First();
            decimal rating = r.RATING.Value;
            RestaurantRatingUpdate.Text = Convert.ToInt32(rating).ToString();
            RestaurantLocationUpdate.Text = r.RESTAURANT_LOCATION;
            CusineTypeUpdate.Text = r.CUISINE_TYPE;
        }
    }
}
