using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;
namespace Uber_Eats_Database_Project
{
    public static class Helper
    {
        public static string currentUserName;
        public static int currentUserRole;
        public static int currentOrderId = 1;
        public static int points=0;
        public static int voucher=0;
        public static string constr = "data source = orcl; user id = scott; password = tiger;";
        public static void RemovePlaceHolder(TextBox tb, string placeHolderText)
        {
            if (tb.Text != null && tb.Text == placeHolderText)
            {
                tb.Clear();
                tb.ForeColor = Color.Black;
            }
        }
        public static void RemovePlaceHolderB(Bunifu.Framework.UI.BunifuMetroTextbox tb, string placeHolderText)
        {
            if (tb.Text != null && tb.Text == placeHolderText)
            {
                tb.Text = "";
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
        public static void AddPlaceHolderB(Bunifu.Framework.UI.BunifuMetroTextbox tb, string placeHolderText)
        {
            if (tb.Text == "" || tb.Text == null)
            {
                tb.ForeColor = Color.DarkGray;
                tb.Text = placeHolderText;
            }
        }
        public static string placeFileinResources(string fileToCopy)
        {
            string newCopy = "";
            for (int i = fileToCopy.Length - 1; i > -1; i--)
            {
                if (fileToCopy[i] == '\\')
                    break;
                newCopy += fileToCopy[i];
            }
            char[] s = newCopy.ToCharArray();
            Array.Reverse(s);
            newCopy = new string(s);
            newCopy = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "resources\\") + newCopy;
            if (System.IO.File.Exists(fileToCopy) && !System.IO.File.Exists(newCopy))
                System.IO.File.Copy(fileToCopy, newCopy);
            return newCopy;
        }
        public static string getFileName(string fil)
        {
            string ans = "";
            for (int i = fil.Length - 1; i > -1; i--)
            {
                if (fil[i] == '\\')
                    break;
                ans += fil[i];
            }
            char[] s = ans.ToCharArray();
            Array.Reverse(s);
            return new string(s);
        }
        public static void onHover(Button btn, Color c)
        {
            btn.BackColor = c;
        }

        public static int getCartId()
        {
            int id = -1;
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GetCartId";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("username", currentUserName);
            cmd.Parameters.Add("cartid", OracleDbType.Int32, System.Data.ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            id = int.Parse(cmd.Parameters["cartid"].Value.ToString());
            con.Close();
            return id;
        }
    }
}
