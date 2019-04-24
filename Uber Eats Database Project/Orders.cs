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
    public partial class Orders : Form
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
        public Orders()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OracleDataAdapter adapter1, adapter2;
        DataSet ds;
        private void Orders_Load(object sender, EventArgs e)
        {
            //Helper.currentUserName = "muhammedaly";
            //Helper.currentUserRole = 1;
            if(Helper.currentUserRole == 1)
            {
                adapter1 = new OracleDataAdapter("select * from scott.\"ORDER\" where status = 'pd' and CUSTOMER_USERNAME = '" + Helper.currentUserName + "'", new OracleConnection(Helper.conStr));
                adapter2 = new OracleDataAdapter("select ord.order_id, f.* from food f, order_food o, scott.\"ORDER\" ord where f.restaurant_name = o.restaurant_name and f.restaurant_location = o.restaurant_location and f.food_name = o.food_name and o.order_id = ord.order_id and ord.CUSTOMER_USERNAME = '" + Helper.currentUserName + "'", new OracleConnection(Helper.conStr));
            }
            else
            {
                adapter1 = new OracleDataAdapter("select o.* from scott.\"ORDER\" o, trip t where (o.status = 'pd' and t.deliverypartner_username = '" + Helper.currentUserName + "') or o.status = 'pp' and o.ORDER_ID = t.ORDER_ID", new OracleConnection(Helper.conStr));
                adapter2 = new OracleDataAdapter(@"select t.order_id, f.* from food f, order_food o, trip t
                        where f.restaurant_name = o.restaurant_name and f.restaurant_location = o.restaurant_location 
                        and f.food_name = o.food_name and o.order_id = t.order_id and t.deliverypartner_username = '" + Helper.currentUserName + "'", new OracleConnection(Helper.conStr));
            }
            ds = new DataSet();
            adapter1.Fill(ds, "order");
            adapter2.Fill(ds, "fo");
            DataRelation r = new DataRelation("fk", ds.Tables[0].Columns["ORDER_ID"], ds.Tables[1].Columns["ORDER_ID"]);
            ds.Relations.Add(r);
            BindingSource bs_Master = new BindingSource(ds, "order");
            BindingSource bs_Child = new BindingSource(bs_Master, "fk");
            pendingOrdersGrid.DataSource = bs_Master;
            foodGrid.DataSource = bs_Child;
        }

        private void pendingOrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OracleDataAdapter adapterr;
            DataSet dss;
            int i = pendingOrdersGrid.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(pendingOrdersGrid.Rows[i].Cells[0].Value);
            adapterr = new OracleDataAdapter(@"select o.restaurant_name, o.restaurant_location, o.food_name, o.no_of_items_per_food, f.price 
                                            from order_food o, food f where o.restaurant_name = f.restaurant_name and o.food_name = f.food_name 
                                            and o.restaurant_location = f.restaurant_location and o.order_id =" + id.ToString(), new OracleConnection(Helper.conStr));
            dss = new DataSet();
            adapterr.Fill(dss);
            foodGrid.DataSource = dss.Tables[0];
        }
    }
}
