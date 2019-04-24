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
    public partial class CustomMsgBox : Form
    {
        public CustomMsgBox()
        {
            InitializeComponent();
            this.Visible = false;
        }
        static CustomMsgBox mb;
        static DialogResult result = DialogResult.OK;
        public static DialogResult Show(string txt, int type = 1)
        {
            mb = new CustomMsgBox();
            if (type == 1)
                mb.OKBtn.Visible = mb.OKBtn.Enabled = true;
            else
            {
                result = DialogResult.No;
                mb.NoBtn.Visible = mb.NoBtn.Enabled = mb.YesBtn.Visible = mb.YesBtn.Enabled = true;
            }
            mb.MessageTxt.Text = txt;
            mb.ShowDialog();
            return result;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            mb.Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            mb.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            mb.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Buttons hovers
        private void OKBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void YesBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void NoBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void NoBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Red);
        }

        private void OKBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void YesBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }
        #endregion
    }
}
