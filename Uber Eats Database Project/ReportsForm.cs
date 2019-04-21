using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Uber_Eats_Database_Project
{
    public partial class ReportsForm : Form
    {
        DeliveredOrders doe;
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            doe = new DeliveredOrders();
            doe.SetParameterValue(0, Helper.currentUserName);
            crystalReportViewer1.ReportSource = doe;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
