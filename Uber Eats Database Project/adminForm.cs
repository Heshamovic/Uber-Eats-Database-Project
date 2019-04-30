using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class adminForm : Form
    {
        Entities ent = new Entities();
        string foodimgadd = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "resources\\") + "NO Image Available.jpg";
        string foodimgupdate = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "resources\\") + "NO Image Available.jpg";
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
            if (CustomMsgBox.Show("Are you sure you want to add this restaurant?", 2) == DialogResult.Yes)
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
                updateRest();
            }
        }

        private void updateRest()
        {
            RestaurantsNamesUpdate.DataSource = ent.RESTAURANTs.Select(x => x.RESTAURANT_NAME).Distinct().ToList();
            RestNameRpt.DataSource = ent.RESTAURANTs.Select(x => x.RESTAURANT_NAME).Distinct().ToList();
            FoodRestNameAdd.DataSource = ent.RESTAURANTs.Select(x => x.RESTAURANT_NAME).Distinct().ToList();
            FoodRestNameUpdate.DataSource = ent.RESTAURANTs.Select(x => x.RESTAURANT_NAME).Distinct().ToList();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            updateRest();
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
            if (CustomMsgBox.Show("Are you sure you want to update this restaurant?", 2) == DialogResult.Yes)
            {
                RESTAURANT r = ent.RESTAURANTs.Where(x => x.RESTAURANT_NAME == RestaurantsNamesUpdate.Text && x.RESTAURANT_LOCATION == RestaurantLocationUpdate.Text).First();
                r.RATING = Convert.ToDecimal(RestaurantRatingUpdate.Text);
                r.CUISINE_TYPE = CusineTypeUpdate.Text;
                ent.SaveChanges();
                CustomMsgBox.Show("Restaurant Updated");
                updateRest();
            }
        }

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
        private void FoodRestNameAdd_SelectedValueChanged(object sender, EventArgs e)
        {
            FoodRestLocAdd.DataSource = ent.RESTAURANTs.Where(re => re.RESTAURANT_NAME == FoodRestNameAdd.Text).Select(x => x.RESTAURANT_LOCATION).ToList();
        }

        private void FoodAddBtn_Click(object sender, EventArgs e)
        {
            if (CustomMsgBox.Show("Are you sure You want to add this food to " + FoodRestNameAdd.Text + " located at " + FoodRestLocAdd.Text + "?", 2) == DialogResult.Yes)
            {
                FOOD f = new FOOD();
                f.DISCOUNT = Convert.ToDecimal(FoodDiscountAdd.Text);
                f.FOODIMAGE = Helper.getFileName(foodimgadd);
                f.FOODTYPE = FoodTypeAdd.Text;
                f.FOOD_NAME = FoodNameAdd.Text;
                f.INGREDIANTS = FoodIngAdd.Text;
                f.PRICE = Convert.ToDecimal(FoodPriceAdd.Text);
                f.RATING = FoodRatingAdd.Value;
                f.RESTAURANT_LOCATION = FoodRestLocAdd.Text;
                f.RESTAURANT_NAME = FoodRestNameAdd.Text;
                f.TOP_DISH = (FoodTopDishAdd.Checked ? "y" : "n");
                ent.FOODs.Add(f);
                ent.SaveChanges();
                CustomMsgBox.Show(FoodNameAdd.Text + " Added");
            }
        }

        private void FoodRestLocUpdate_SelectedValueChanged(object sender, EventArgs e)
        {
            FoodNameUpdate.DataSource = (from f in ent.FOODs
                                         where f.RESTAURANT_NAME == FoodRestNameUpdate.Text && f.RESTAURANT_LOCATION == FoodRestLocUpdate.Text
                                         select f.FOOD_NAME).ToList();
        }

        private void FoodRestNameUpdate_SelectedValueChanged(object sender, EventArgs e)
        {
            FoodRestLocUpdate.DataSource = ent.RESTAURANTs.Where(re => re.RESTAURANT_NAME == FoodRestNameUpdate.Text).Select(x => x.RESTAURANT_LOCATION).ToList();
            FoodRestLocUpdate.Refresh();
        }

        private void FoodImageUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Add Image";
            of.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
                FoodImgUpdate.Image = Image.FromFile(Helper.placeFileinResources(of.FileName));
                foodimgupdate = Helper.placeFileinResources(of.FileName);
            }
            of.Dispose();
        }

        private void FoodImageAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Add Image";
            of.Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
                FoodImgAdd.Image = Image.FromFile(Helper.placeFileinResources(of.FileName));
                foodimgadd = Helper.placeFileinResources(of.FileName);
            }
            of.Dispose();
        }

        private void FoodUpdateBtn_Click(object sender, EventArgs e)
        {
            if (CustomMsgBox.Show("Are you sure You want to Update this food to " + FoodRestNameUpdate.Text + " located at " + FoodRestLocUpdate.Text + "?", 2) == DialogResult.Yes)
            {
                FOOD f = new FOOD();
                f.DISCOUNT = Convert.ToDecimal(FoodDiscountUpdate.Text);
                f.FOODIMAGE = Helper.getFileName(foodimgupdate);
                f.FOODTYPE = FoodTypeUpdate.Text;
                f.FOOD_NAME = FoodNameUpdate.Text;
                f.INGREDIANTS = FoodIngUpdate.Text;
                f.PRICE = Convert.ToDecimal(FoodPriceUpdate.Text);
                f.RATING = FoodRatingUpdate.Value;
                f.RESTAURANT_LOCATION = FoodRestLocUpdate.Text;
                f.RESTAURANT_NAME = FoodRestNameUpdate.Text;
                f.TOP_DISH = (FoodTopDishUpdate.Checked ? "y" : "n");
                ent.FOODs.AddOrUpdate(f);
                ent.SaveChanges();
                CustomMsgBox.Show(FoodNameUpdate.Text + " Updated");
            }
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
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }
        private void FoodAddBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }
        private void FoodAddBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }
        private void FoodImageAdd_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void FoodImageAdd_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
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

        private void FoodIngAdd_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Ingrediants");
        }

        private void FoodIngAdd_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Ingrediants");
        }

        private void FoodNameAdd_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Food Name");
        }

        private void FoodNameAdd_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Food Name");
        }

        private void FoodTypeAdd_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Food Type");
        }

        private void FoodTypeAdd_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Food Type");
        }

        private void FoodDiscountAdd_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Discount");
        }

        private void FoodDiscountAdd_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Discount");
        }

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Food Price");
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolderB((Bunifu.Framework.UI.BunifuMetroTextbox)sender, "Food Price");
        }
        #endregion
    }
}
