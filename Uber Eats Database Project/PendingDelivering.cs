using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Uber_Eats_Database_Project
{
    public partial class PendingDelivering : Form
    {
        private int ordID = 0;
        public PendingDelivering()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PendingDelivering_Load(object sender, EventArgs e)
        {
            OrdersGV.ColumnHeadersVisible = true;
            OrdersGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            OrdersGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            Entities ent = new Entities();
            var oid = from ord in ent.ORDERS
                      join t in ent.TRIPs on ord.ORDER_ID equals t.ORDER_ID
                      where ord.STATUS == "pd" && t.DELIVERYPARTNER_USERNAME == Helper.currentUserName
                      select ord.ORDER_ID;
            ordID = int.Parse(oid.FirstOrDefault().ToString());
            var v = from of in ent.ORDER_FOOD
                    join t in ent.TRIPs on of.ORDER_ID equals t.ORDER_ID
                    where t.ORDER_ID == oid.FirstOrDefault()
                    select new
                    {
                        of.FOOD_NAME,
                        of.RESTAURANT_NAME,
                        of.RESTAURANT_LOCATION,
                        of.NO_OF_ITEMS_PER_FOOD,
                        of.BOUGHT
                    };
            int rind = 0;
            foreach (var i in v)
            {
                OrdersGV.Rows.Add();
                OrdersGV[0, rind].Value = i.FOOD_NAME;
                OrdersGV[1, rind].Value = i.RESTAURANT_NAME;
                OrdersGV[2, rind].Value = i.RESTAURANT_LOCATION;
                OrdersGV[3, rind].Value = i.NO_OF_ITEMS_PER_FOOD.ToString();
                OrdersGV[4, rind++].Value = (i.BOUGHT == "y" || i.BOUGHT == "Y");
            }
            enableConfirmBtn();
        }
        private void enableConfirmBtn()
        {
            Entities ent = new Entities();
            int c = ent.ORDER_FOOD.Count(x => x.ORDER_ID == ordID && (x.BOUGHT == "y" || x.BOUGHT == "Y"));
            if (ent.ORDER_FOOD.Count(x => x.ORDER_ID == ordID && (x.BOUGHT == "y" || x.BOUGHT == "Y")) == ent.ORDER_FOOD.Count(x => x.ORDER_ID == ordID))
                OrderDeliveredBtn.Enabled = true;
            else
                OrderDeliveredBtn.Enabled = false;
        }

        private void OrderDeliveredBtn_Click(object sender, EventArgs e)
        {
            Entities ent = new Entities();
            ORDER o = (from x in ent.ORDERS
                       where x.ORDER_ID == ordID
                       select x).FirstOrDefault();
            o.STATUS = "d";
            DELIVERY_PARTNER dp = (from p in ent.DELIVERY_PARTNER
                                   where p.USERNAME == Helper.currentUserName
                                   select p).FirstOrDefault();
            TRIP t = (from tr in ent.TRIPs
                      where tr.ORDER_ID == o.ORDER_ID
                      select tr).FirstOrDefault();

            var l = (from fo in ent.ORDER_FOOD
                    join f in ent.FOODs on new { k1 = fo.RESTAURANT_LOCATION, k2 = fo.RESTAURANT_NAME, k3 = fo.FOOD_NAME} 
                                    equals new { k1 = f.RESTAURANT_LOCATION, k2 = f.RESTAURANT_NAME, k3 = f.FOOD_NAME }
                    select new
                    {
                        f.PRICE,
                        f.DISCOUNT,
                        fo.NO_OF_ITEMS_PER_FOOD
                    });

            decimal mealcost = 0, deliverycost = t.DISTANCE_OF_TRIP.Value * dp.RATING.Value, applicationfees = 5, totalcost = 0;
            if (dp.VEHICLE == "car")
                deliverycost *= 8;
            else if (dp.VEHICLE == "bike")
                deliverycost *= 5;
            else
                deliverycost *= 3;
            t.DELIVERYFEES = deliverycost;
            dp.RATING = Math.Max(5, dp.RATING.Value + (decimal)(0.01));
            foreach (var i in l)
                mealcost += ((i.PRICE - i.PRICE * i.DISCOUNT) * i.NO_OF_ITEMS_PER_FOOD).Value;
            totalcost = deliverycost + applicationfees + mealcost;
            CustomMsgBox.Show("Delivery Fees = " + deliverycost.ToString() + 
                              "\nMeal Cost = " + mealcost.ToString() + 
                              "\nTotal Cost = " + totalcost.ToString());
            ent.SaveChanges();
            this.Close();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                this.OrdersGV.CommitEdit(DataGridViewDataErrorContexts.Commit);
                string s = OrdersGV[0, e.RowIndex].Value.ToString(),
                       t = OrdersGV[1, e.RowIndex].Value.ToString(),
                       u = OrdersGV[2, e.RowIndex].Value.ToString();
                Entities ent = new Entities();
                ORDER_FOOD fo = (from x in ent.ORDER_FOOD
                                 where x.FOOD_NAME == s
                                 && x.RESTAURANT_NAME == t
                                 && x.RESTAURANT_LOCATION == u
                                 && x.ORDER_ID == ordID
                                 select x).FirstOrDefault();
                if (OrdersGV[4, e.RowIndex].Value.ToString() == "true")
                    fo.BOUGHT = "y";
                else
                    fo.BOUGHT = "n";
                ent.SaveChanges();
                enableConfirmBtn();
            }
        }

        private void CancelDeliveryBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CustomMsgBox.Show("Are you sure you want to cancel the order\n if you cancel the order your " +
                "rating will decrease by 0.2", 2);
            if (dialogResult == DialogResult.Yes)
            {
                Entities ent = new Entities();
                var l = (from fo in ent.ORDER_FOOD
                         where fo.ORDER_ID == ordID
                         select fo);
                foreach (var i in l)
                    i.BOUGHT = "f";
                var ord = (from o in ent.ORDERS
                           where o.ORDER_ID == ordID
                           select o).First();
                ord.STATUS = "pp";
                DELIVERY_PARTNER dp = (from p in ent.DELIVERY_PARTNER
                                       where p.USERNAME == Helper.currentUserName
                                       select p).FirstOrDefault();
                dp.RATING = Math.Min(0, dp.RATING.Value - (decimal)(0.2));
                ent.SaveChanges();
                this.Close();
            }
        }

        #region Buttons Hovers
        private void OrderDeliveredBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void OrderDeliveredBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void CancelDeliveryBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void CancelDeliveryBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Red);
        }
        #endregion
    }
}
