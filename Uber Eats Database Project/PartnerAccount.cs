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
        int trip_order,index;
        float trip_dist, trip_fee;
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
                    index++;
                }
            }
            //cmd.CommandText = "select * from trip where deliverypartner_username=:uname";
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("uname",Helper.currentUserName);
            //OracleDataReader rdr = cmd.ExecuteReader();
            //if(rdr.Read())
            //{
            //    trip_order =  int.Parse(rdr[0].ToString());
            //    trip_dist = float.Parse(rdr[1].ToString());
            //    trip_fee = float.Parse(rdr[3].ToString());
            //}
            //OracleCommand cmd2 = new OracleCommand();
            //cmd2.Connection = con;
            //cmd2.CommandText = "delete from delivery_partner where username=:uname";
            //cmd2.CommandType = CommandType.Text;
            //cmd2.Parameters.Add("uname", Helper.currentUserName);
            //cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void saveUserNameBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            if(userName.Text!=Helper.currentUserName)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into delivery_partner values(:uname, :vehicle, :pass, :rating)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("uname", userName.Text);
                cmd.Parameters.Add("vehicle",part_vehicle);
                cmd.Parameters.Add("pass", part_pass);
                cmd.Parameters.Add("rating", rating);
                cmd.ExecuteNonQuery();
                OracleCommand cmd2 = new OracleCommand();

            }
            
            //OracleDataReader rdr = cmd.ExecuteReader();
            //if (rdr.Read())
            //{
            //    MessageBox.Show("Username already taken.");
            //}
            //else
            //{
            //    OracleCommand cmd2 = new OracleCommand();
            //    cmd2.Connection = con;
            //    cmd2.CommandText = "insert into delivery_partner values (:uname,:vehicle,:pass,:rating)";
            //    cmd2.CommandType = CommandType.Text;
            //    cmd2.Parameters.Add("uname", userName.Text);
            //    cmd2.Parameters.Add("vehicle", part_vehicle);
            //    cmd2.Parameters.Add("pass", part_pass);
            //    cmd2.Parameters.Add("rating", rating);
            //    int r = cmd2.ExecuteNonQuery();
            //    if (r != -1)
            //    {
            //        MessageBox.Show("Username changed successfully.");
            //        OracleCommand cmd3 = new OracleCommand();
            //        cmd3.Connection = con;
            //        cmd3.CommandText = "update trip set deliverypartner_username=:uname where deliverypartner_username is NULL";
            //        cmd3.CommandType = CommandType.Text;
            //        //cmd3.Parameters.Add("orderid", trip_order);
            //        //cmd3.Parameters.Add("distance", trip_dist);
            //        cmd3.Parameters.Add("uname", Helper.currentUserName);
            //        //cmd3.Parameters.Add("fees", trip_fee);
            //        cmd3.ExecuteNonQuery();
            //        saveUserNameBtn.Hide();
            //        userName.Enabled = false;
            //        Helper.currentUserName = userName.Text;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Couldn't change username. Please try again.");
            //    }
            //}
            con.Close();
            savePasswordBtn.Hide();
            //string cmdstr = "select * from delivery_partner";
            //OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds,"partner");
            //part_index = 0;
            //fk_index = 0;
            //foreach (DataRow row in ds.Tables["partner"].Rows)
            //{
            //    string tmp_username = row[0].ToString();
            //    if (tmp_username == Helper.currentUserName)
            //    {
            //        break;
            //    }
            //    part_index++;
            //}

            //cmdstr = "select * from trip";
            //OracleDataAdapter adapter1 = new OracleDataAdapter(cmdstr, constr);
            ////DataSet ds1 = new DataSet();
            //adapter1.Fill(ds,"trip");
            //bool rel = false;
            //foreach (DataRow row in ds.Tables["trip"].Rows)
            //{
            //    string tmp_fk = row[2].ToString();
            //    if (tmp_fk == Helper.currentUserName)
            //    {
            //        rel = true;
            //        break;
            //    }
            //    fk_index++;
            //}

            //OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            //OracleCommandBuilder builder1 = new OracleCommandBuilder(adapter1);
            //DataRow r = ds.Tables["partner"].Rows[part_index];
            //DataRow f = ds.Tables["trip"].Rows[fk_index];
            //bool exist = false;
            //int tmp = 0;
            //foreach(DataRow row in ds.Tables["partner"].Rows)
            //{
            //    string tmp_username = row[0].ToString();
            //    if(tmp_username == userName.Text && tmp!=part_index)
            //    {
            //        exist = true;
            //        MessageBox.Show("Username is already taken.");
            //        userName.Text = "";
            //    }
            //    tmp++;
            //}
            //var relation = ds.Relations.Add(ds.Tables["partner"].Columns["USERNAME"], ds.Tables["trip"].Columns["DELIVERYPARTNER_USERNAME"]);
            //relation.ChildKeyConstraint.UpdateRule = Rule.None;
            //if (exist==false)
            //{
            //    r[0] = userName.Text;

            //    if (rel==true)
            //    {
            //        f[2] = userName.Text;
            //        adapter1.Update(ds.Tables["trip"]);
            //    }
            //    adapter.Update(ds.Tables["partner"]);
            //    Helper.currentUserName = userName.Text;
            //    MessageBox.Show("Username changed successfully.");
            //    saveUserNameBtn.Hide();
            //    userName.Enabled = false;


            //}

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
            //string cmdstr = "select * from delivery_partner";
            //OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            //part_index = 0;
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    string tmp_username = row[0].ToString();
            //    if (tmp_username == Helper.currentUserName)
            //    {
            //        break;
            //    }
            //    part_index++;
            //}
            //DataRow r = ds.Tables[0].Rows[part_index];
            //r[1] = vehicleType.Text;
            //adapter.Update(ds.Tables[0]);
            //vehicle = vehicleType.Text;
            //MessageBox.Show("Vehicle type changed successfully.");
            //saveBtn.Hide();
            //vehicleType.Enabled = false;
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

            //    trips = 0;
            //    constr = "data source = orcl; user id = scott; password = tiger;";
            //    string cmdstr = "select * from delivery_partner";
            //    OracleDataAdapter adapter = new OracleDataAdapter(cmdstr,constr);
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds);
            //    foreach(DataRow row in ds.Tables[0].Rows)
            //    {
            //        string tmp_username = row[0].ToString();
            //        if(tmp_username==Helper.currentUserName)
            //        {
            //            userName.Text = tmp_username;
            //            vehicleType.Text = row[1].ToString();
            //            vehicle = row[1].ToString();
            //            pass = row[2].ToString();
            //            rating = row[3].ToString();
            //            double x = Math.Round(float.Parse(rating));
            //            bunifuRating1.Value = Convert.ToInt32(x);
            //        }
            //    }
            //    cmdstr = "select * from trip";
            //    adapter = new OracleDataAdapter(cmdstr,constr);
            //    ds = new DataSet();
            //    adapter.Fill(ds);
            //    foreach(DataRow row in ds.Tables[0].Rows)
            //    {
            //        string tmp_username = row[2].ToString();
            //        if(tmp_username==Helper.currentUserName)
            //        {
            //            trips++;
            //        }
            //    }
            //    label4.Text = trips.ToString();
        }
    }
}
