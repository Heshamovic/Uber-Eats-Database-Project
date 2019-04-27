using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber_Eats_Database_Project
{
    public static class Helper
    {
        public static string currentUserName;
        public static int currentUserRole;
        public static int currentOrderId=1;
        public static string constr = "data source = orcl; user id = scott; password = tiger;";
        public static void RemovePlaceHolder(TextBox tb, string placeHolderText)
        {
            if (tb.Text != null && tb.Text == placeHolderText)
            {
                tb.Clear();
                tb.ForeColor = Color.Black;
            }
        }
        public static void AddPlaceHolder(TextBox tb, string placeHolderText)
        {
            if (tb.Text == "" || tb.Text == null)
            {
                tb.ForeColor = Color.DarkGray;
                tb.Text = placeHolderText;
            }
        }
        public static void onHover(Button btn, Color c)
        {
            btn.BackColor = c;
        }
    }
}
