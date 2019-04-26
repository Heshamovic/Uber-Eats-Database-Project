using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_Eats_Database_Project
{
    public partial class UserOrderItem : UserControl
    {
       public int cur_order;
        public UserOrderItem()
        {
            InitializeComponent();
        }

        private void Show_Order_Items_Click(object sender, EventArgs e)
        {
            Order_details o = new Order_details();
            o.c_order = cur_order;
            o.Show();
            //string s= this.Order_Number;

           // MessageBox.Show(o.c_order.ToString());

         
        }

        private void UserOrderItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
