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
using Oracle.ManagedDataAccess.EntityFramework;

namespace Uber_Eats_Database_Project
{
    public partial class login : Form
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
        public OracleConnection con;
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Username*");
        }

        private void userNameSignUp_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Username*");
        }

        private void passwordSignUp_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Password*");
        }

        private void fName_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "First Name");
        }

        private void lName_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Last Name");
        }

        private void location_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Location");
        }

        private void creditCard_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Credit Card");
        }

        private void passwordSignUp_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Password*");
        }

        private void fName_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "First Name");
        }

        private void lName_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Last Name");
        }

        private void location_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Location");
        }

        private void creditCard_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Credit Card");
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (!customerChkBx.Checked && !partnerChkBx.Checked)
            {
                CustomMsgBox.Show("Please select your membership role!");
                return;
            }
            if(userNameSignUp.Text == "Username*" || userNameSignUp.Text == "")
            {
                CustomMsgBox.Show("Please fill the required (*) fields!");
                return;
            }
            if (passwordSignUp.Text == "Password*" || passwordSignUp.Text == "")
            {
                CustomMsgBox.Show("Please fill the required (*) fields!");
                return;
            }
            string lname = lName.Text, fname = fName.Text, location = locationTB.Text, cc = creditCard.Text, vehicle = vehicleTB.Text;
            if (lname == "Last Name")
                lname = null;
            if (fname == "First Name")
                fname = null;
            if (location == "Location")
                location = null;
            if (cc == "Credit Card")
                cc = null;
            if (vehicle == "Vehicle")
                vehicle = null;
            OracleCommand cmd = new OracleCommand("sign_up", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("nusername", userNameSignUp.Text);
            cmd.Parameters.Add("npassword", passwordSignUp.Text);
            int nrole;
            if (customerChkBx.Checked)
                nrole = 1;
            else
                nrole = 2;
            cmd.Parameters.Add("nrole", nrole);
            cmd.Parameters.Add("done", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("nfname", fname);
            cmd.Parameters.Add("nlname", lname);
            cmd.Parameters.Add("nlocation", location);
            cmd.Parameters.Add("ncredit_no", cc);
            cmd.Parameters.Add("nvehicle", vehicle);
            cmd.ExecuteNonQuery();
            int done = Convert.ToInt32(cmd.Parameters["done"].Value.ToString());
            if (done == 0)
            {
                #region create cart
                if (customerChkBx.Checked)
                {
                    cmd = new OracleCommand("Create_Cart", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("un", userNameSignUp.Text);
                    cmd.ExecuteNonQuery();
                }
                #endregion
                CustomMsgBox.Show("This user has been added!");
                customerChkBx.Checked = partnerChkBx.Checked = false;
                vehicleTB.Enabled = false;
                userNameSignIn.Text = userNameSignUp.Text;
                userNameSignIn.ForeColor = Color.Black;
                userNameSignUp.Text = "Username*";
                passwordSignUp.Text = "Password*";
                fName.Text = "First Name";
                lName.Text = "Last Name";
                creditCard.Text = "Credit Card";
                locationTB.Text = "Location";
                vehicleTB.Text = "Vehicle";
                vehicleTB.ForeColor = Color.DarkGray;
                fName.ForeColor = lName.ForeColor = creditCard.ForeColor = locationTB.ForeColor = userNameSignUp.ForeColor = passwordSignUp.ForeColor = Color.DarkGray;
            }
            else
                CustomMsgBox.Show("This username is already taken!");
        }

        private void login_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(Helper.constr);
            con.Open();
        }
        
        private void customerChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if(customerChkBx.Checked)
            {
                fName.Enabled = lName.Enabled = creditCard.Enabled = locationTB.Enabled = true;
                vehicleTB.Text = "Vehicle";
                vehicleTB.ForeColor = Color.DarkGray;
                vehicleTB.Enabled = false;
            }
            else
            {
                fName.Enabled = lName.Enabled = creditCard.Enabled = locationTB.Enabled = false;
                fName.Text = "First Name";
                lName.Text = "Last Name";
                creditCard.Text = "Credit Card";
                locationTB.Text = "Location";
                fName.ForeColor = lName.ForeColor = creditCard.ForeColor = locationTB.ForeColor = Color.DarkGray;
                vehicleTB.Enabled = true;
            }
        }
        MainForm mainform;
        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (userNameSignIn.Text.ToLower() == "admin" && passwordSignIn.Text == "123")
            {
                adminForm af = new adminForm();
                af.Show();
                this.Hide();
                af.FormClosing += letsShow;
                return;
            }
            if (!customerChkBxSignIn.Checked && !partnerChkBxSignIn.Checked)
            {
                CustomMsgBox.Show("Please select your membership role!");
                return;
            }
            if (userNameSignIn.Text == "Username*" || userNameSignIn.Text == "")
            {
                CustomMsgBox.Show("Please fill the Username field");
                return;
            }
            if (passwordSignIn.Text == "Password*" || passwordSignIn.Text == "")
            {
                CustomMsgBox.Show("Please fill the Password field");
                return;
            }
            if(customerChkBxSignIn.Checked)
            {
                OracleCommand cmd = new OracleCommand("select count(USERNAME) from customer where USERNAME = :name and PASSWORD = :pass", con);
                cmd.Parameters.Add("name", userNameSignIn.Text);
                cmd.Parameters.Add("pass", passwordSignIn.Text);
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt > 0)
                {
                    Helper.currentUserName = userNameSignIn.Text;
                    Helper.currentUserRole = 1;
                    mainform = new MainForm();
                    mainform.Show();
                    this.Hide();
                    mainform.FormClosing += letsShow;
                    
                    OracleCommand cmd6 = new OracleCommand();
                    cmd6.Connection = con;
                    cmd6.CommandText = "Count_GetPoints";
                    cmd6.CommandType = CommandType.StoredProcedure;
                    cmd6.Parameters.Add("username", Helper.currentUserName);
                    cmd6.Parameters.Add("cnt", OracleDbType.Int32, ParameterDirection.Output);
                    cmd6.ExecuteNonQuery();
                    Helper.points = int.Parse(cmd6.Parameters["cnt"].Value.ToString());
                }
                else
                    CustomMsgBox.Show("check your username and password!");
            }
            else
            {
                OracleCommand cmd = new OracleCommand("select count(USERNAME) from DELIVERY_PARTNER where USERNAME = :name and PASSWORD = :pass", con);
                cmd.Parameters.Add("name", userNameSignIn.Text);
                cmd.Parameters.Add("pass", passwordSignIn.Text);
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt > 0)
                {
                    Helper.currentUserName = userNameSignIn.Text;
                    Helper.currentUserRole = 2;
                    mainform = new MainForm();
                    mainform.Show();
                    this.Hide();
                    mainform.FormClosing += letsShow;
                }
                else
                    CustomMsgBox.Show("check your username and password!");
            }
        }
        public void letsShow(object sender, FormClosingEventArgs e)
        {
            passwordSignIn.ForeColor = Color.DarkGray;
            userNameSignIn.Text = Helper.currentUserName;
            passwordSignIn.Text = "Password*";
            this.Show();
        }

        private void vehicleTB_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Vehicle");
        }

        private void vehicleTB_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Vehicle");
        }

        private void partnerChkBx_CheckedChanged(object sender, EventArgs e)
        {
            if (customerChkBx.Checked)
            {
                fName.Enabled = lName.Enabled = creditCard.Enabled = locationTB.Enabled = true;
                vehicleTB.Text = "Vehicle";
                vehicleTB.ForeColor = Color.DarkGray;
                vehicleTB.Enabled = false;
            }
            else
            {
                fName.Enabled = lName.Enabled = creditCard.Enabled = locationTB.Enabled = false;
                fName.Text = "First Name";
                lName.Text = "Last Name";
                creditCard.Text = "Credit Card";
                locationTB.Text = "Location";
                fName.ForeColor = lName.ForeColor = creditCard.ForeColor = locationTB.ForeColor = Color.DarkGray;
                vehicleTB.Enabled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signInBtn_MouseHover(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void signInBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void userNameSignIn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (userNameSignIn.Text.ToLower() == "admin" && passwordSignIn.Text == "123")
                {
                    adminForm af = new adminForm();
                    af.Show();
                    this.Hide();
                    af.FormClosing += letsShow;
                    return;
                }
                if (!customerChkBxSignIn.Checked && !partnerChkBxSignIn.Checked)
                {
                    CustomMsgBox.Show("Please select your membership role!");
                    return;
                }
                if (userNameSignIn.Text == "Username*" || userNameSignIn.Text == "")
                {
                    CustomMsgBox.Show("Please fill the Username field");
                    return;
                }
                if (passwordSignIn.Text == "Password*" || passwordSignIn.Text == "")
                {
                    CustomMsgBox.Show("Please fill the Password field");
                    return;
                }
                if (customerChkBxSignIn.Checked)
                {
                    OracleCommand cmd = new OracleCommand("select count(USERNAME) from customer where USERNAME = :name and PASSWORD = :pass", con);
                    cmd.Parameters.Add("name", userNameSignIn.Text);
                    cmd.Parameters.Add("pass", passwordSignIn.Text);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cnt > 0)
                    {
                        Helper.currentUserName = userNameSignIn.Text;
                        Helper.currentUserRole = 1;
                        mainform = new MainForm();
                        mainform.Show();
                        this.Hide();
                        mainform.FormClosing += letsShow;
                    }
                    else
                        CustomMsgBox.Show("check your username and password!");
                }
                else
                {
                    OracleCommand cmd = new OracleCommand("select count(USERNAME) from DELIVERY_PARTNER where USERNAME = :name and PASSWORD = :pass", con);
                    cmd.Parameters.Add("name", userNameSignIn.Text);
                    cmd.Parameters.Add("pass", passwordSignIn.Text);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cnt > 0)
                    {
                        Helper.currentUserName = userNameSignIn.Text;
                        Helper.currentUserRole = 2;
                        mainform = new MainForm();
                        mainform.Show();
                        this.Hide();
                        mainform.FormClosing += letsShow;
                    }
                    else
                        CustomMsgBox.Show("check your username and password!");
                }
            }
        }

        private void passwordSignIn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (userNameSignIn.Text.ToLower() == "admin" && passwordSignIn.Text == "123")
                {
                    adminForm af = new adminForm();
                    af.Show();
                    this.Hide();
                    af.FormClosing += letsShow;
                    return;
                }
                if (!customerChkBxSignIn.Checked && !partnerChkBxSignIn.Checked)
                {
                    CustomMsgBox.Show("Please select your membership role!");
                    return;
                }
                if (userNameSignIn.Text == "Username*" || userNameSignIn.Text == "")
                {
                    CustomMsgBox.Show("Please fill the Username field");
                    return;
                }
                if (passwordSignIn.Text == "Password*" || passwordSignIn.Text == "")
                {
                    CustomMsgBox.Show("Please fill the Password field");
                    return;
                }
                if (customerChkBxSignIn.Checked)
                {
                    OracleCommand cmd = new OracleCommand("select count(USERNAME) from customer where USERNAME = :name and PASSWORD = :pass", con);
                    cmd.Parameters.Add("name", userNameSignIn.Text);
                    cmd.Parameters.Add("pass", passwordSignIn.Text);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cnt > 0)
                    {
                        Helper.currentUserName = userNameSignIn.Text;
                        Helper.currentUserRole = 1;
                        mainform = new MainForm();
                        mainform.Show();
                        this.Hide();
                        mainform.FormClosing += letsShow;
                    }
                    else
                        CustomMsgBox.Show("check your username and password!");
                }
                else
                {
                    OracleCommand cmd = new OracleCommand("select count(USERNAME) from DELIVERY_PARTNER where USERNAME = :name and PASSWORD = :pass", con);
                    cmd.Parameters.Add("name", userNameSignIn.Text);
                    cmd.Parameters.Add("pass", passwordSignIn.Text);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cnt > 0)
                    {
                        Helper.currentUserName = userNameSignIn.Text;
                        Helper.currentUserRole = 2;
                        mainform = new MainForm();
                        mainform.Show();
                        this.Hide();
                        mainform.FormClosing += letsShow;
                    }
                    else
                        CustomMsgBox.Show("check your username and password!");
                }
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }
    }
}
