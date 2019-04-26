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
    public partial class test : UserControl
    {
        public test(string txt)
        {
            InitializeComponent();
            label1.Text = txt;
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
