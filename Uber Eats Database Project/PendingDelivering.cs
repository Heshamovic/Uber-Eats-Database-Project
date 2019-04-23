using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.EntityClient;
using System.Data.Entity;

namespace Uber_Eats_Database_Project
{
    public partial class PendingDelivering : Form
    {
        private int ordID;
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
            Entities ent = new Entities();
            var oid = from ord in ent.ORDERS
                      where ord.STATUS == "pd"
                      select ord.ORDER_ID;
            ordID = int.Parse(oid.FirstOrDefault().ToString());
            var v = from of in ent.ORDER_FOOD
                    join t in ent.TRIPs on of.ORDER_ID equals t.ORDER_ID
                    where t.ORDER_ID == oid.FirstOrDefault()
                    && t.DELIVERYPARTNER_USERNAME == Helper.currentUserName
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
            if (enableConfirmBtn())
                OrderDeliveredBtn.Enabled = true;
        }
        private bool enableConfirmBtn()
        {
            Entities ent = new Entities();
            return ent.ORDER_FOOD.Count(x => x.ORDER_ID == ordID && (x.BOUGHT == "y" || x.BOUGHT == "Y")) == ent.ORDER_FOOD.Count(x => x.ORDER_ID == ordID);
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string s = OrdersGV[0, e.RowIndex].Value.ToString(),
                       t = OrdersGV[1, e.RowIndex].Value.ToString(),
                       u = OrdersGV[2, e.RowIndex].Value.ToString();
                Entities ent = new Entities();
                ORDER_FOOD fo = (from x in ent.ORDER_FOOD
                                 where x.FOOD_NAME == s
                                 && x.RESTAURANT_NAME == t
                                 && x.RESTAURANT_LOCATION == u
                                 select x).FirstOrDefault();
                if ((bool)OrdersGV[4, e.RowIndex].Value == true)
                {
                    fo.BOUGHT = "y";
                    MessageBox.Show("heeeeh");
                }
                else
                    fo.BOUGHT = "n";
                ent.SaveChanges();
                enableConfirmBtn();
            }
        }

        private void OrderDeliveredBtn_Click(object sender, EventArgs e)
        {

            Entities ent = new Entities();
            ORDER o = (from x in ent.ORDERS
                             where x.ORDER_ID == ordID
                             select x).FirstOrDefault();
            o.STATUS = "d";
            ent.SaveChanges();
            //cars, bikes, or on foot.
            var pv = from p in ent.DELIVERY_PARTNER
                      where p.USERNAME == Helper.currentUserName
                      select p.VEHICLE;
            var td = from t in ent.TRIPs
                     where t.ORDER_ID == ordID
                     select t.DISTANCE_OF_TRIP;
            float totalprice = 0, deliverycost = 0;
            if (pv.FirstOrDefault() == "car")
                totalprice += float.Parse(td.FirstOrDefault().ToString()) * 15;
            else if (pv.FirstOrDefault() == "bike")
                totalprice += float.Parse(td.FirstOrDefault().ToString()) * 20;
            else
                totalprice += float.Parse(td.FirstOrDefault().ToString()) * 25;
            deliverycost = totalprice;
            MessageBox.Show("Order total cost = " + totalprice.ToString());
            this.Close();
        }
    }
}
