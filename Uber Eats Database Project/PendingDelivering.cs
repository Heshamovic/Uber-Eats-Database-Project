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
            Entities ent = new Entities();
            var oid = from ord in ent.ORDERS
                      where ord.STATUS == "pd"
                      select ord.ORDER_ID;
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
                OrdersGV[4, rind].Value = false;
                if (i.BOUGHT == "y" || i.BOUGHT == "Y")
                    OrdersGV[4, rind].Value = true;
                rind++;
            }
        }
    }
}
