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
        DataSet ds;
        //DataSet ds1;
        OracleDataAdapter adapter;
        OracleDataAdapter adapter1;
        OracleCommandBuilder builder;
        string part_pass, part_vehicle, rating;
        int index;
        public PartnerAccount()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editUsernameBtn_Click(object sender, EventArgs e)
        {
            userName.Enabled = true;
            saveUserNameBtn.Show();
            
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from delivery_partner";
            //cmd.CommandType = CommandType.Text;
            //index = 0;
            //OracleDataReader rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //    if (rdr[0].ToString() == Helper.currentUserName)
            //    {
            //        break;
            //    }
            //    index++;
            //}
        }

        private void saveUserNameBtn_Click(object sender, EventArgs e)
        {
            //int tmp_ind = 0;
            //bool found = false;
            
            //while(tmp_ind < ds.Tables["partner"].Rows.Count)
            //{
            //    if(ds.Tables["partner"].Rows[tmp_ind][0].ToString()==userName.Text && tmp_ind!=index)
            //    {
            //        found = true;
            //        break;
            //    }
            //    tmp_ind++;
            //}
            //if(found==true)
            //{
            //    CustomMsgBox.Show("Username already taken.");
            //}
            //else
            //{
            //    if(userName.Text!=Helper.currentUserName)
            //    {
            //        DataRow r = ds.Tables["partner"].NewRow();
            //        r[0] = userName.Text;
            //        r[1] = part_vehicle;
            //        r[2] = part_pass;
            //        r[3] = rating;
            //        ds.Tables[0].Rows.Add(r);
            //        builder = new OracleCommandBuilder(adapter);
            //        adapter.Update(ds.Tables[0]);

            //        int row_num = 0;
            //        while(row_num<ds.Tables["trip"].Rows.Count)
            //        {
            //            if(ds.Tables["trip"].Rows[row_num][2].ToString()==Helper.currentUserName)
            //            {
            //                ds.Tables["trip"].Rows[row_num][2] = userName.Text;
            //                builder = new OracleCommandBuilder(adapter1);
            //                adapter1.Update(ds.Tables["trip"]);
            //            }
            //        }
            //        ds.Tables["partner"].Rows.RemoveAt(index);
            //        builder = new OracleCommandBuilder(adapter);
            //        adapter.Update(ds.Tables["trip"]);

            //        Helper.currentUserName = userName.Text;
            //        CustomMsgBox.Show("Username is changed successfully.");
            //    }
            //}
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from delivery_partner";
            //cmd.CommandType = CommandType.Text;
            //OracleDataReader rdr = cmd.ExecuteReader();
            //int tmp_ind = 0;
            //bool found = false;
            //while (rdr.Read())
            //{
            //    if (rdr[0].ToString() == userName.Text && tmp_ind != index)
            //    {
            //        found = true;
            //        break;
            //    }
            //    tmp_ind++;
            //}
            //if (found == true)
            //{
            //    CustomMsgBox.Show("Username already taken.");
            //}
            //else
            //{
            //    if (userName.Text != Helper.currentUserName)
            //    {
            //        cmd = new OracleCommand();
            //        cmd.Connection = con;
            //        cmd.CommandText = "insert into delivery_partner values(:uname, :vehicle, :pass, :rating)";
            //        cmd.CommandType = CommandType.Text;
            //        cmd.Parameters.Add("uname", userName.Text);
            //        cmd.Parameters.Add("vehicle", part_vehicle);
            //        cmd.Parameters.Add("pass", part_pass);
            //        cmd.Parameters.Add("rating", rating);
            //        cmd.ExecuteNonQuery();

            //        OracleCommand cmd3 = new OracleCommand();
            //        cmd3.Connection = con;
            //        cmd3.CommandText = "update trip set deliverypartner_username=:newd where deliverypartner_username=:oldd";
            //        cmd3.CommandType = CommandType.Text;
            //        cmd3.Parameters.Add("newd", userName.Text);
            //        cmd3.Parameters.Add("oldd", Helper.currentUserName);
            //        cmd3.ExecuteNonQuery();

            //        OracleCommand cmd2 = new OracleCommand();
            //        cmd2.Connection = con;
            //        cmd2.CommandText = "delete from delivery_partner where username=:del";
            //        cmd2.CommandType = CommandType.Text;
            //        cmd2.Parameters.Add("del", Helper.currentUserName);
            //        cmd2.ExecuteNonQuery();

            //        Helper.currentUserName = userName.Text;
            //    }
            //    CustomMsgBox.Show("Username changed successfully.");
            //}
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
            ds.Tables["partner"].Rows[index][1] = vehicleType.Text;
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables["partner"]);
            CustomMsgBox.Show("Vehicle is updated successfully.");
            part_vehicle = vehicleType.Text;
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "update delivery_partner set vehicle=:veh where username=:uname";
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("veh", vehicleType.Text);
            //cmd.Parameters.Add("uname", Helper.currentUserName);
            //int r = cmd.ExecuteNonQuery();
            //if (r != -1)
            //{
            //    CustomMsgBox.Show("Vehicle is Updated successfully.");
            //    part_vehicle = vehicleType.Text;
            //}
            //else
            //{
            //    CustomMsgBox.Show("Couldn't update your information. Please try again.");
            //}
            saveBtn.Hide();
            editBtn.Show();
            userName.Enabled = false;
            vehicleType.Enabled = false;
        }

        private void savePasswordBtn_Click(object sender, EventArgs e)
        {
            if (newPassword.Text == "" || oldPassword.Text == "" || confirmPassword.Text == "")
            {
                CustomMsgBox.Show("Please fill all fields.");
            }
            if(oldPassword.Text==part_pass)
            {
                if(newPassword.Text==confirmPassword.Text)
                {
                    ds.Tables["partner"].Rows[index][2] = newPassword.Text;
                    part_pass = newPassword.Text;
                    builder = new OracleCommandBuilder(adapter);
                    adapter.Update(ds.Tables["partner"]);
                    CustomMsgBox.Show("Password is changed successfully.");
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
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select password from delivery_partner where username=:uname";
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("uname", Helper.currentUserName);
            //OracleDataReader rdr = cmd.ExecuteReader();
            //if (rdr.Read())
            //{
            //    part_pass = rdr[0].ToString();
            //}
            //if (part_pass == oldPassword.Text)
            //{
            //    if (newPassword.Text == confirmPassword.Text)
            //    {
            //        OracleCommand cmd2 = new OracleCommand();
            //        cmd2.Connection = con;
            //        cmd2.CommandText = "update delivery_partner set password=:newpass where username=:uname";
            //        cmd2.CommandType = CommandType.Text;
            //        cmd2.Parameters.Add("newpass", newPassword.Text);
            //        cmd2.Parameters.Add("uname", Helper.currentUserName);
            //        int r = cmd2.ExecuteNonQuery();
            //        if (r != -1)
            //        {
            //            CustomMsgBox.Show("Password is changed successfully.");
            //            part_pass = newPassword.Text;
            //            oldPassword.Text = "";
            //            newPassword.Text = "";
            //            confirmPassword.Text = "";
            //            oldPassword.Hide();
            //            newPassword.Hide();
            //            confirmPassword.Hide();
            //            savePasswordBtn.Hide();
            //        }
            //        else
            //        {
            //            CustomMsgBox.Show("Couldn't change your password. Please try again.");
            //        }
            //    }
            //    else
            //    {
            //        CustomMsgBox.Show("Please re-enter your new password.");
            //        newPassword.Text = "";
            //        confirmPassword.Text = "";
            //    }
            //}
            //else
            //{
            //    CustomMsgBox.Show("Wrong Password! Enter your password again.");
            //    oldPassword.Text = "";
            //}
        }

        private void DeliveredOrdersRptBtn_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm();
            rf.Show();
            this.Hide();
            rf.FormClosing += letsShow;
        }

        public int trips;

        private void PartnerAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            //con.Dispose();
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
            string cmdstr = "select * from delivery_partner";
            adapter = new OracleDataAdapter(cmdstr, Helper.constr);
            ds = new DataSet();
            adapter.Fill(ds,"partner");
            index = 0;
            while(index<ds.Tables["partner"].Rows.Count)
            {
                if(ds.Tables["partner"].Rows[index][0].ToString()==Helper.currentUserName)
                {
                    part_pass = ds.Tables["partner"].Rows[index][2].ToString();
                    part_vehicle = ds.Tables["partner"].Rows[index][1].ToString();
                    rating = ds.Tables["partner"].Rows[index][3].ToString();
                    double x = Math.Round(float.Parse(rating));
                    bunifuRating1.Value = Convert.ToInt32(x);
                    break;
                }
                index++;
            }
            userName.Text = Helper.currentUserName;
            vehicleType.Text = part_vehicle;

            cmdstr = "select * from trip";
            adapter1 = new OracleDataAdapter(cmdstr,Helper.constr);
            //DataSet ds1 = new DataSet();
            adapter1.Fill(ds,"trip");
            int tmp = 0;
            trips = 0;
            while(tmp<ds.Tables["trip"].Rows.Count)
            {
                if(ds.Tables["trip"].Rows[tmp][2].ToString()==Helper.currentUserName)
                {
                    trips++; 
                }
            }
            label4.Text = trips.ToString();
            //con = new OracleConnection(Helper.constr);
            //con.Open();

            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from delivery_partner where username=:uname";
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("uname", Helper.currentUserName);
            //OracleDataReader rdr = cmd.ExecuteReader();
            //if (rdr.Read())
            //{
            //    userName.Text = Helper.currentUserName;
            //    vehicleType.Text = rdr[1].ToString();
            //    part_vehicle = rdr[1].ToString();
            //    part_pass = rdr[2].ToString();
            //    rating = rdr[3].ToString();
            //    double x = Math.Round(float.Parse(rating));
            //    bunifuRating1.Value = Convert.ToInt32(x);
            //}

            //OracleCommand cmd2 = new OracleCommand();
            //cmd2.Connection = con;
            //cmd2.CommandText = "select count(*) from trip where deliverypartner_username=:uname";
            //cmd2.CommandType = CommandType.Text;
            //cmd2.CommandType = CommandType.Text;
            //cmd2.Parameters.Add("uname", Helper.currentUserName);
            //OracleDataReader rdr2 = cmd2.ExecuteReader();
            //if (rdr2.Read())
            //{
            //    label4.Text = rdr2[0].ToString();
            //}
            //else
            //{
            //    label4.Text = "0";
            //}
        }
        public void letsShow(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}