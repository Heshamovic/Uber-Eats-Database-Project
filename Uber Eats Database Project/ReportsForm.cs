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
        ResaturantFoodReport roe;
        int choice = 0;
        DateTime fromDate, toDate;
        string restName = "";
        public ReportsForm()
        {
            InitializeComponent();
        }
        public ReportsForm(DateTime fDate = new DateTime(), DateTime tDate = new DateTime(), string rest = "")
        {
            InitializeComponent();
            if (rest != "")
                choice = 1;
            fromDate = fDate;
            toDate = tDate;
            restName = rest;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            if (choice == 0) // delivered orders report
            {
                doe = new DeliveredOrders();
                doe.SetParameterValue(0, Helper.currentUserName);
                crystalReportViewer1.ReportSource = doe;
            }
            else // restaurants report
            {
                roe = new ResaturantFoodReport();
                roe.SetParameterValue(0, restName);
                roe.SetParameterValue(1, fromDate);
                roe.SetParameterValue(2, toDate);
                crystalReportViewer1.ReportSource = roe;
            }
            crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            crystalReportViewer1.RefreshReport();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
