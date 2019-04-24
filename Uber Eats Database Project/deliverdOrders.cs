using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_Eats_Database_Project
{
    public partial class deliverdOrders : Form
    {
        public deliverdOrders()
        {
            InitializeComponent();
        }
        OracleDataAdapter adapter;
        DataSet ds;
        private void deliverdOrders_Load(object sender, EventArgs e)
        {
            Helper.currentUserName = "muhammedaly";
            adapter = new OracleDataAdapter("select * from scott.\"ORDER\" where status = 'd' and CUSTOMER_USERNAME = '" + Helper.currentUserName + "'", new OracleConnection(Helper.conStr));
            ds = new DataSet();
            adapter.Fill(ds);
            deliveredOrdersGrid.DataSource = ds.Tables[0];
        }

        private void deliveredOrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = deliveredOrdersGrid.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(deliveredOrdersGrid.Rows[i].Cells[0].Value);
            adapter = new OracleDataAdapter(@"select o.restaurant_name, o.restaurant_location, o.food_name, o.no_of_items_per_food, f.price 
                                            from order_food o, food f where o.restaurant_name = f.restaurant_name and o.food_name = f.food_name 
                                            and o.restaurant_location = f.restaurant_location and o.order_id =" + id.ToString(), new OracleConnection(Helper.conStr));
            ds = new DataSet();
            adapter.Fill(ds);
            foodGrid.DataSource = ds.Tables[0];
        }
    }
}
