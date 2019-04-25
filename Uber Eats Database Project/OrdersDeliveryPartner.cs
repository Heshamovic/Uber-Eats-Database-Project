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
    public partial class OrdersDeliveryPartner : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        int pending = 1, type;
        public OrdersDeliveryPartner(int t)
        {
            InitializeComponent();
            type = t;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OracleDataAdapter adapter1, adapter2;
        bool erg3 = false;
        private void orders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (type == 1)
            {
                DialogResult dialogResult = CustomMsgBox.Show("Do you want to take this order?", 2);
                if (dialogResult == DialogResult.Yes)
                {
                    int i = orders.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(orders.Rows[i].Cells[0].Value);
                    orders.Rows[i].Cells[4].Value = "pd";
                    OracleConnection con = new OracleConnection(Helper.constr);
                    con.Open();
                    OracleCommand cmd = new OracleCommand(@"update trip set DELIVERYPARTNER_USERNAME = '" + Helper.currentUserName + "'" +
                                                           "where order_id = " + id.ToString(), con);
                    cmd.ExecuteNonQuery();
                    cmd = new OracleCommand(@"update Orders set status = 'pd' where order_id = " + id.ToString(), con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    builder = new OracleCommandBuilder(adapter1);
                    adapter1.Update(ds.Tables[0]);
                    this.Close();
                }
            }
        }

        DataSet ds;

        private void OrdersDeliveryPartner_Shown(object sender, EventArgs e)
        {
            if (erg3)
                this.Close();
        }

        OracleCommandBuilder builder;
        private void OrdersDeliveryPartner_Load(object sender, EventArgs e)
        {
            if (type == pending)
            {
                try
                {
                    adapter1 = new OracleDataAdapter("select o.* from orders o, trip t where t.DELIVERYPARTNER_USERNAME is null and t.ORDER_ID = o.ORDER_ID and o.status = 'pp'", new OracleConnection(Helper.constr));
                    adapter2 = new OracleDataAdapter("select o.ORDER_ID, f.* from food f, order_food offf, orders o, trip t where o.ORDER_ID = offf.ORDER_ID and t.order_id = o.order_id and offf.RESTAURANT_NAME = f.RESTAURANT_NAME and offf.RESTAURANT_LOCATION = f.RESTAURANT_LOCATION and offf.FOOD_NAME= f.FOOD_NAME and t.deliverypartner_username is null", new OracleConnection(Helper.constr));
                    ds = new DataSet();
                    adapter1.Fill(ds, "order");
                    adapter2.Fill(ds, "food");
                    DataRelation r1 = new DataRelation("fk1", ds.Tables[0].Columns["order_id"], ds.Tables[1].Columns["order_id"]);
                    ds.Relations.Add(r1);
                    BindingSource bs_Master = new BindingSource(ds, "order");
                    BindingSource bs_child1 = new BindingSource(bs_Master, "fk1");
                    orders.DataSource = bs_Master;
                    food.DataSource = bs_child1;
                }
                catch
                {
                    erg3 = true;
                    CustomMsgBox.Show("There's no orders to show");
                }
            }
            else
            {
                try
                {
                    adapter1 = new OracleDataAdapter("select o.* from orders o, trip t where t.DELIVERYPARTNER_USERNAME = '" + Helper.currentUserName + "' and t.ORDER_ID = o.ORDER_ID and o.status = 'd'", new OracleConnection(Helper.constr));
                    adapter2 = new OracleDataAdapter("select o.ORDER_ID, f.* from food f, order_food offf, orders o, trip t where o.ORDER_ID = offf.ORDER_ID and t.order_id = o.order_id and offf.RESTAURANT_NAME = f.RESTAURANT_NAME and offf.RESTAURANT_LOCATION = f.RESTAURANT_LOCATION and offf.FOOD_NAME= f.FOOD_NAME and t.DELIVERYPARTNER_USERNAME = '" + Helper.currentUserName + "' and o.status = 'd'", new OracleConnection(Helper.constr));
                    ds = new DataSet();
                    adapter1.Fill(ds, "order");
                    adapter2.Fill(ds, "food");
                    DataRelation r1 = new DataRelation("fk1", ds.Tables[0].Columns["order_id"], ds.Tables[1].Columns["order_id"]);
                    ds.Relations.Add(r1);
                    BindingSource bs_Master = new BindingSource(ds, "order");
                    BindingSource bs_child1 = new BindingSource(bs_Master, "fk1");
                    orders.DataSource = bs_Master;
                    food.DataSource = bs_child1;
                }
                catch
                {
                    erg3 = true;
                    CustomMsgBox.Show("There's no orders to show");
                }
            }
        }
    }
}
