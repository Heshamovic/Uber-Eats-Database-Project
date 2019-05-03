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
    public partial class CustomerAccount : Form
    {
        public OracleConnection con;
        string cust_fname, cust_lname, cust_loc, cust_credit, cust_pass;
        int index;
        public CustomerAccount()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            userName.Enabled = true;
            fName.Enabled = true;
            lName.Enabled = true;
            location.Enabled = true;
            creditCard.Enabled = true;
            editBtn.Hide();
            saveBtn.Show();
        }

        private void CustomerAccount_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(Helper.constr);
            con.Open();
            oldPassword.Hide();
            newPassword.Hide();
            confirmPassword.Hide();
            savePasswordBtn.Hide();
            saveUserNameBtn.Hide();
            saveBtn.Hide();
            userName.Text = Helper.currentUserName;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from customer where username = :uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", Helper.currentUserName);
            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                fName.Text = rdr[1].ToString();
                cust_fname = rdr[1].ToString();
                lName.Text = rdr[2].ToString();
                cust_lname = rdr[2].ToString();
                location.Text = rdr[3].ToString();
                cust_loc = rdr[3].ToString();
                if (rdr[4] != null)
                {
                    creditCard.Text = rdr[4].ToString();
                    cust_credit = rdr[4].ToString();
                }
                cust_pass = rdr[5].ToString();
            }
            userName.Enabled = false;
            fName.Enabled = false;
            lName.Enabled = false;
            location.Enabled = false;
            creditCard.Enabled = false;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "select count(*) from orders where customer_username = :uname and status = 'd'";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("uname", Helper.currentUserName);
            int order_cnt = 0;
            OracleDataReader rdr2 = cmd2.ExecuteReader();
            if (rdr2.Read())
                order_cnt = int.Parse(rdr2[0].ToString());

            int voucher = 0;
            if (order_cnt > 20)
                voucher = Math.Min(50, order_cnt / 2);
            label5.Text = voucher.ToString() + '%'; ;
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            oldPassword.Show();
            newPassword.Show();
            confirmPassword.Show();
            savePasswordBtn.Show();
            Helper.AddPlaceHolder(oldPassword, "Password");
            Helper.AddPlaceHolder(newPassword, "New Password");
            Helper.AddPlaceHolder(confirmPassword, "Confirm Password");
        }
        #region Text place Holders
        private void oldPassword_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Password");
        }

        private void oldPassword_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Password");
        }

        private void newPassword_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "New Password");
        }

        private void newPassword_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "New Password");
        }

        private void confirmPassword_Enter(object sender, EventArgs e)
        {
            Helper.RemovePlaceHolder((TextBox)sender, "Confirm Password");
        }

        private void confirmPassword_Leave(object sender, EventArgs e)
        {
            Helper.AddPlaceHolder((TextBox)sender, "Confirm Password");
        }
        #endregion

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Buttons Hovers
        private void saveBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void editBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void editUsernameBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void saveUserNameBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void changePasswordBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void savePasswordBtn_MouseEnter(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Green);
        }

        private void editUsernameBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void saveUserNameBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void changePasswordBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void savePasswordBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }

        private void editBtn_MouseLeave(object sender, EventArgs e)
        {
            Helper.onHover((Button)sender, Color.Black);
        }
        #endregion

        private void savePasswordBtn_Click(object sender, EventArgs e)
        {
            if (newPassword.Text == "" || oldPassword.Text == "" || confirmPassword.Text == "")
            {
                CustomMsgBox.Show("Please fill all fields.");
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select password from customer where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", Helper.currentUserName);
            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                cust_pass = rdr[0].ToString();
            }
            if (cust_pass == oldPassword.Text)
            {
                if (newPassword.Text == confirmPassword.Text)
                {
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "update customer set password=:newpass where username=:uname";
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.Add("newpass", newPassword.Text);
                    cmd2.Parameters.Add("uname", Helper.currentUserName);
                    int r = cmd2.ExecuteNonQuery();
                    if (r != -1)
                    {
                        CustomMsgBox.Show("Password is changed successfully.");
                        cust_pass = newPassword.Text;
                        oldPassword.Text = "";
                        newPassword.Text = "";
                        confirmPassword.Text = "";
                        oldPassword.Hide();
                        newPassword.Hide();
                        confirmPassword.Hide();
                        savePasswordBtn.Hide();
                    }
                    else
                    {
                        CustomMsgBox.Show("Couldn't change your password. Please try again.");
                    }
                }
                else
                {
                    CustomMsgBox.Show("Please re-enter your new password.");
                    newPassword.Text = "";
                    confirmPassword.Text = "";
                }
            }
            else
            {
                CustomMsgBox.Show("Wrong Password! Enter your password again.");
                oldPassword.Text = "";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "update customer set fname=:fn, lname=:ln, location=:loc, credit_no=:credit where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("fn", fName.Text);
            cmd.Parameters.Add("ln", lName.Text);
            cmd.Parameters.Add("loc", location.Text);
            cmd.Parameters.Add("credit", creditCard.Text);
            cmd.Parameters.Add("uname", Helper.currentUserName);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                CustomMsgBox.Show("Info is Updated successfully.");
                cust_fname = fName.Text;
                cust_lname = lName.Text;
                cust_loc = location.Text;
                cust_credit = creditCard.Text;
            }
            else
            {
                CustomMsgBox.Show("Couldn't update your information. Please try again.");
            }
            saveBtn.Hide();
            editBtn.Show();
            userName.Enabled = false;
            fName.Enabled = false;
            lName.Enabled = false;
            location.Enabled = false;
            creditCard.Enabled = false;
        }

        private void editUsernameBtn_Click(object sender, EventArgs e)
        {
            userName.Enabled = true;
            saveUserNameBtn.Show();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from customer";
            cmd.CommandType = CommandType.Text;
            index = 0;
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[0].ToString() == Helper.currentUserName)
                {
                    break;
                }
                index++;
            }
        }
        private void saveUserNameBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from customer";
            cmd.CommandType = CommandType.Text;
            OracleDataReader rdr = cmd.ExecuteReader();
            int tmp_ind = 0;
            bool found = false;
            while (rdr.Read())
            {
                if (rdr[0].ToString() == userName.Text && tmp_ind != index)
                {
                    found = true;
                    break;
                }
                tmp_ind++;
            }
            if (found == true)
            {
                CustomMsgBox.Show("Username already taken.");
            }
            else
            {
                if (userName.Text != Helper.currentUserName)
                {
                    cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into customer values(:uname, :fname, :lname, :loc, :credit, :pass)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("uname", userName.Text);
                    cmd.Parameters.Add("fname", cust_fname);
                    cmd.Parameters.Add("lname", cust_lname);
                    cmd.Parameters.Add("loc", cust_loc);
                    cmd.Parameters.Add("credit", cust_credit);
                    cmd.Parameters.Add("pass", cust_pass);
                    cmd.ExecuteNonQuery();

                    OracleCommand cmd3 = new OracleCommand();
                    cmd3.Connection = con;
                    cmd3.CommandText = "update orders set customer_username=:newd where customer_username=:oldd";
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.Add("newd", userName.Text);
                    cmd3.Parameters.Add("oldd", Helper.currentUserName);
                    cmd3.ExecuteNonQuery();

                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "delete from customer where username=:del";
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.Add("del", Helper.currentUserName);
                    cmd2.ExecuteNonQuery();

                    Helper.currentUserName = userName.Text;
                }
                CustomMsgBox.Show("Username changed successfully.");
            }
            saveUserNameBtn.Hide();
            userName.Enabled = false;
        }
    }
}