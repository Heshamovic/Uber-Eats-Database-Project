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
    public partial class PartnerAccount : Form
    {
        //string constr,pass,vehicle;
        //int part_index,fk_index;
        public OracleConnection con;
        string part_pass,part_vehicle,rating;
        int index;
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editUsernameBtn_Click(object sender, EventArgs e)
        {
            userName.Enabled = true;
            saveUserNameBtn.Show();

            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from delivery_partner";
            cmd.CommandType = CommandType.Text;
            index = 0;
            OracleDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                if(rdr[0].ToString()==Helper.currentUserName)
                {
                    break;
                }
                index++;
            }
            con.Close();
        }

        private void saveUserNameBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from delivery_partner";
            cmd.CommandType = CommandType.Text;
            OracleDataReader rdr = cmd.ExecuteReader();
            int tmp_ind = 0;
            bool found = false;
            while(rdr.Read())
            {
                if(rdr[0].ToString() == userName.Text && tmp_ind!=index)
                {
                    found = true;
                    break;
                }
                tmp_ind++;
            }
            if(found==true)
            {
                CustomMsgBox.Show("Username already taken.");
            }
            else
            {
                if (userName.Text != Helper.currentUserName)
                {
                    cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into delivery_partner values(:uname, :vehicle, :pass, :rating)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("uname", userName.Text);
                    cmd.Parameters.Add("vehicle", part_vehicle);
                    cmd.Parameters.Add("pass", part_pass);
                    cmd.Parameters.Add("rating", rating);
                    cmd.ExecuteNonQuery();

                    OracleCommand cmd3 = new OracleCommand();
                    cmd3.Connection = con;
                    cmd3.CommandText = "update trip set deliverypartner_username=:newd where deliverypartner_username=:oldd";
                    cmd3.CommandType = CommandType.Text;
                    cmd3.Parameters.Add("newd", userName.Text);
                    cmd3.Parameters.Add("oldd", Helper.currentUserName);
                    cmd3.ExecuteNonQuery();

                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "delete from delivery_partner where username=:del";
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.Add("del", Helper.currentUserName);
                    cmd2.ExecuteNonQuery();

                    Helper.currentUserName = userName.Text;
                }
                MessageBox.Show("Username changed successfully.");
            }
            con.Close();
            saveUserNameBtn.Hide();
            userName.Enabled = false;
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            vehicleType.Enabled = true;
            saveBtn.Show();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "update delivery_partner set vehicle=:veh where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("veh", vehicleType.Text);
            cmd.Parameters.Add("uname",Helper.currentUserName);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Vehicle is Updated successfully.");
                part_vehicle = vehicleType.Text;
            }
            else
            {
                MessageBox.Show("Couldn't update your information. Please try again.");
            }
            con.Close();
            saveBtn.Hide();
            editBtn.Show();
            userName.Enabled = false;
            vehicleType.Enabled = false;
        }

        private void savePasswordBtn_Click(object sender, EventArgs e)
        {
            if (newPassword.Text == "" || oldPassword.Text == "" || confirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
            }

            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select password from delivery_partner where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", Helper.currentUserName);
            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                part_pass = rdr[0].ToString();
            }
            if (part_pass == oldPassword.Text)
            {
                if (newPassword.Text == confirmPassword.Text)
                {
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "update delivery_partner set password=:newpass where username=:uname";
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.Add("newpass", newPassword.Text);
                    cmd2.Parameters.Add("uname", Helper.currentUserName);
                    int r = cmd2.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Password is changed successfully.");
                        part_pass = newPassword.Text;
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
                        MessageBox.Show("Couldn't change your password. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please re-enter your new password.");
                    newPassword.Text = "";
                    confirmPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Wrong Password! Enter your password again.");
                oldPassword.Text = "";
            }
            con.Close();
        }

        public int trips;
        public PartnerAccount()
        {
            InitializeComponent();
        }

        private void PartnerAccount_Load(object sender, EventArgs e)
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
            con = new OracleConnection("data source = orcl; user id = scott; password = tiger;");
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from delivery_partner where username=:uname";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("uname", Helper.currentUserName);
            OracleDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                userName.Text = Helper.currentUserName;
                vehicleType.Text = rdr[1].ToString();
                part_vehicle = rdr[1].ToString();
                part_pass = rdr[2].ToString();
                rating = rdr[3].ToString();
                double x = Math.Round(float.Parse(rating));
                bunifuRating1.Value = Convert.ToInt32(x);
            }
            
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "select count(*) from trip where deliverypartner_username=:uname";
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("uname", Helper.currentUserName);
            OracleDataReader rdr2 = cmd2.ExecuteReader();
            if(rdr2.Read())
            {
                label4.Text = rdr2[0].ToString();
            }
            else
            {
                label4.Text = "0";
            }
            con.Close();
        }
    }
}
