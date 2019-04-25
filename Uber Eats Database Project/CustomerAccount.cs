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
        public string cust_fname, cust_lname,cust_loc,cust_credit,cust_pass;
        public CustomerAccount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            userName.Enabled = false;
            fName.Enabled = false;
            lName.Enabled = false;
            location.Enabled = false;
            creditCard.Enabled = false;
            oldPassword.Hide();
            newPassword.Hide();
            confirmPassword.Hide();
            savePasswordBtn.Hide();
            saveUserNameBtn.Hide();
            saveBtn.Hide();
            userName.Text = Helper.currentUserName;
            con = new OracleConnection("data source = orcl; user id = scott; password = tiger;");
            con.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "get_customer_info";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("user_name",OracleDbType.Varchar2).Value=Helper.currentUserName;
            ////cmd.Parameters.Add("user_name", OracleDbType.Varchar2, Helper.currentUserName, ParameterDirection.Input);
            //cmd.Parameters.Add("first_name", OracleDbType.Varchar2, ParameterDirection.Output);
            //cmd.Parameters.Add("last_name", OracleDbType.Varchar2, ParameterDirection.Output);
            //cmd.Parameters.Add("loc", OracleDbType.Varchar2, ParameterDirection.Output);
            //cmd.Parameters.Add("credit", OracleDbType.Varchar2, ParameterDirection.Output);
            //cmd.ExecuteNonQuery();
            //fName.Text = cmd.Parameters["first_name"].Value.ToString();
            //lName.Text = cmd.Parameters["last_name"].Value.ToString();
            //location.Text = cmd.Parameters["loc"].Value.ToString();
            //creditCard.Text = cmd.Parameters["credit"].Value.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from customer where username=:uname";
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
                creditCard.Text = rdr[4].ToString();
                cust_credit = rdr[4].ToString();
                cust_pass = rdr[5].ToString();
            }
            con.Close();

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            oldPassword.Show();
            newPassword.Show();
            confirmPassword.Show();
            savePasswordBtn.Show();
        }

        private void savePasswordBtn_Click(object sender, EventArgs e)
        {
            if (newPassword.Text == "" || oldPassword.Text == "" || confirmPassword.Text == "")
            {
                CustomMsgBox.Show("Please fill all fields.");
            }
            con = new OracleConnection("data source = orcl; user id = scott; password = tiger;");
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select password from customer where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", Helper.currentUserName);
            OracleDataReader rdr = cmd.ExecuteReader();
            //string cust_pass = "";
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
            con.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            con = new OracleConnection("data source = orcl; user id = scott; password = tiger;");
            con.Open();
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
            con.Close();
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
            con = new OracleConnection("data source = orcl; user id = scott; password = tiger;");
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from customer where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname",Helper.currentUserName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void saveUserNameBtn_Click(object sender, EventArgs e)
        {
            con = new OracleConnection("data source = orcl; user id = scott; password = tiger;");
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from customer where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname",userName.Text);
            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                CustomMsgBox.Show("Username already taken.");
            }
            else
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "insert into customer values (:uname,:fname,:lname,:loc,:credit,:pass)";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("uname",userName.Text);
                cmd2.Parameters.Add("fname",cust_fname);
                cmd2.Parameters.Add("lname",cust_lname);
                cmd2.Parameters.Add("loc",cust_loc);
                cmd2.Parameters.Add("credit",cust_credit);
                cmd2.Parameters.Add("pass",cust_pass);
                int r = cmd2.ExecuteNonQuery();
                if (r != -1)
                {
                    CustomMsgBox.Show("Username changed successfully.");
                    saveUserNameBtn.Hide();
                    userName.Enabled = false;
                    Helper.currentUserName = userName.Text;
                }
                else
                {
                    CustomMsgBox.Show("Couldn't change username. Please try again.");
                }
            }
            con.Close();
        }
    }
}