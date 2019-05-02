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
    public partial class DPartnerAccountcs : Form
    {
        DataSet ds;
        //DataSet ds1;
        OracleDataAdapter adapter;
        //OracleDataAdapter adapter1;
        OracleCommandBuilder builder;
        string part_pass, part_vehicle, rating;
        int index;
        public int trips;
        public DPartnerAccountcs()
        {
            InitializeComponent();
        }

        private void DPartnerAccountcs_Load(object sender, EventArgs e)
        {
            bunifuRating1.Enabled = false;
            userName.Enabled = false;
            vehicleType.Enabled = false;
            savePasswordBtn.Hide();
            saveUserNameBtn.Hide();
            oldPassword.Hide();
            newPassword.Hide();
            confirmPassword.Hide();
            saveBtn.Hide();
            string cmdstr = "select * from delivery_partner";
            adapter = new OracleDataAdapter(cmdstr, Helper.constr);
            ds = new DataSet();
            adapter.Fill(ds);
            index = 0;
            while (index < ds.Tables[0].Rows.Count)
            {
                if (ds.Tables[0].Rows[index][0].ToString() == Helper.currentUserName)
                {
                    part_pass = ds.Tables[0].Rows[index][2].ToString();
                    part_vehicle = ds.Tables[0].Rows[index][1].ToString();
                    rating = ds.Tables[0].Rows[index][3].ToString();
                    double x = Math.Round(float.Parse(rating));
                    bunifuRating1.Value = Convert.ToInt32(x);
                    break;
                }
                index++;
            }
            userName.Text = Helper.currentUserName;
            vehicleType.Text = part_vehicle;

            cmdstr = "select * from trip";
            OracleDataAdapter adapter1 = new OracleDataAdapter(cmdstr, Helper.constr);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);
            int tmp = 0;
            trips = 0;
            while (tmp < ds1.Tables[0].Rows.Count)
            {
                if (ds1.Tables[0].Rows[tmp][2].ToString() == Helper.currentUserName)
                {
                    trips++;
                }
                tmp++;
            }
            label4.Text = trips.ToString();
        }
    }
}
