using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
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
            if (ent.RESTAURANTs.Where(x => x.RESTAURANT_NAME == RestaurantsNamesAdd.Text && x.RESTAURANT_LOCATION == RestaurantLocationAdd.Text).Count() > 0)
            {
                CustomMsgBox.Show("This restaurant already exists");
                return;
            }
            RESTAURANT r = new RESTAURANT();
            r.RESTAURANT_NAME = RestaurantsNamesAdd.Text;
            r.RESTAURANT_LOCATION = RestaurantLocationAdd.Text;
            r.RATING = int.Parse(ratingRest.Text);
            r.CUISINE_TYPE = CusineTypeAdd.Text;
            ent.RESTAURANTs.Add(r);
            ent.SaveChanges();
            CustomMsgBox.Show("Restaurant added");
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            List<string> l = ent.RESTAURANTs.Select(x => x.RESTAURANT_NAME).ToList();
            RestaurantsNamesUpdate.DataSource = l;
            RestNameRpt.DataSource = l;
        }
        
        private void RestaurantsNamesUpdate_SelectedValueChanged(object sender, EventArgs e)
        {
            RESTAURANT r = ent.RESTAURANTs.Where(re => re.RESTAURANT_NAME == RestaurantsNamesUpdate.Text).First();
            RestaurantRatingUpdate.Text = Convert.ToInt32(r.RATING.Value).ToString();
            RestaurantLocationUpdate.Text = r.RESTAURANT_LOCATION;
            CusineTypeUpdate.Text = r.CUISINE_TYPE;
        }

        private void updateRatingBtn_Click(object sender, EventArgs e)
        {
            RESTAURANT r = ent.RESTAURANTs.Where(x => x.RESTAURANT_NAME == RestaurantsNamesUpdate.Text && x.RESTAURANT_LOCATION == RestaurantLocationUpdate.Text).First();
            r.RATING = Convert.ToDecimal(RestaurantRatingUpdate.Text);
            r.CUISINE_TYPE = CusineTypeUpdate.Text;
            ent.SaveChanges();
            CustomMsgBox.Show("Restaurant Updated");
        }
        #region Buttons Hovers
        private void addResBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void addResBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void updateRatingBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void updateRatingBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }
        #endregion
        #region Text boxes enter and leave
        private void RestaurantsNamesAdd_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Restaurant Name");
        }

        private void RestaurantLocationAdd_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Location");
        }

        private void CusineTypeAdd_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Cusine Type");
        }

        private void RestaurantsNamesAdd_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Restaurant Name");
        }

        private void RestaurantLocationAdd_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Location");
        }

        private void CusineTypeAdd_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Cusine Type");
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm(FromDatePicker.Value, ToDatePicker.Value, RestNameRpt.Text);
            rf.Show();
            this.Hide();
            rf.FormClosing += letsShow;
        }
        public void letsShow(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
