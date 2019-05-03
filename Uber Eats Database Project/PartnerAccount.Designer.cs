namespace Uber_Eats_Database_Project
{
    partial class PartnerAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerAccount));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userName = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.header = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.savePasswordBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.editUsernameBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveUserNameBtn = new System.Windows.Forms.Button();
            this.vehicleType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.label4 = new System.Windows.Forms.Label();
            this.DeliveredOrdersRptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.DarkGray;
            this.userName.Location = new System.Drawing.Point(48, 85);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(246, 25);
            this.userName.TabIndex = 53;
            this.userName.Text = "Username";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBtn.Location = new System.Drawing.Point(393, 133);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(129, 37);
            this.editBtn.TabIndex = 58;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Account Info";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageActive = null;
            this.exit.Location = new System.Drawing.Point(728, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 17;
            this.exit.TabStop = false;
            this.exit.Zoom = 20;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.exit);
            this.header.Controls.Add(this.label2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(762, 29);
            this.header.TabIndex = 59;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Black;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(559, 133);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 37);
            this.saveBtn.TabIndex = 60;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.Black;
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePasswordBtn.Location = new System.Drawing.Point(48, 211);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(245, 30);
            this.changePasswordBtn.TabIndex = 61;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // oldPassword
            // 
            this.oldPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.oldPassword.Location = new System.Drawing.Point(48, 256);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(246, 25);
            this.oldPassword.TabIndex = 62;
            this.oldPassword.Text = "Password";
            this.oldPassword.Enter += new System.EventHandler(this.oldPassword_Enter);
            this.oldPassword.Leave += new System.EventHandler(this.oldPassword_Leave);
            // 
            // newPassword
            // 
            this.newPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.newPassword.Location = new System.Drawing.Point(48, 285);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(246, 25);
            this.newPassword.TabIndex = 63;
            this.newPassword.Text = "New Password";
            this.newPassword.Enter += new System.EventHandler(this.newPassword_Enter);
            this.newPassword.Leave += new System.EventHandler(this.newPassword_Leave);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.confirmPassword.Location = new System.Drawing.Point(48, 313);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(246, 25);
            this.confirmPassword.TabIndex = 64;
            this.confirmPassword.Text = "Confirm Password";
            this.confirmPassword.Enter += new System.EventHandler(this.confirmPassword_Enter);
            this.confirmPassword.Leave += new System.EventHandler(this.confirmPassword_Leave);
            // 
            // savePasswordBtn
            // 
            this.savePasswordBtn.BackColor = System.Drawing.Color.Black;
            this.savePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePasswordBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePasswordBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savePasswordBtn.Location = new System.Drawing.Point(96, 344);
            this.savePasswordBtn.Name = "savePasswordBtn";
            this.savePasswordBtn.Size = new System.Drawing.Size(142, 37);
            this.savePasswordBtn.TabIndex = 65;
            this.savePasswordBtn.Text = "Save Password";
            this.savePasswordBtn.UseVisualStyleBackColor = false;
            this.savePasswordBtn.Click += new System.EventHandler(this.savePasswordBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.Location = new System.Drawing.Point(44, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Username";
            // 
            // editUsernameBtn
            // 
            this.editUsernameBtn.BackColor = System.Drawing.Color.Black;
            this.editUsernameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editUsernameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUsernameBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUsernameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editUsernameBtn.Location = new System.Drawing.Point(48, 120);
            this.editUsernameBtn.Name = "editUsernameBtn";
            this.editUsernameBtn.Size = new System.Drawing.Size(245, 31);
            this.editUsernameBtn.TabIndex = 71;
            this.editUsernameBtn.Text = "Change Username";
            this.editUsernameBtn.UseVisualStyleBackColor = false;
            this.editUsernameBtn.Click += new System.EventHandler(this.editUsernameBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(339, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 302);
            this.panel2.TabIndex = 72;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label9.Location = new System.Drawing.Point(358, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 70;
            this.label9.Text = "Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label7.Location = new System.Drawing.Point(345, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 68;
            this.label7.Text = "Vehicle Type";
            // 
            // saveUserNameBtn
            // 
            this.saveUserNameBtn.BackColor = System.Drawing.Color.Black;
            this.saveUserNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveUserNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserNameBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserNameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveUserNameBtn.Location = new System.Drawing.Point(96, 158);
            this.saveUserNameBtn.Name = "saveUserNameBtn";
            this.saveUserNameBtn.Size = new System.Drawing.Size(142, 37);
            this.saveUserNameBtn.TabIndex = 73;
            this.saveUserNameBtn.Text = "Save Username";
            this.saveUserNameBtn.UseVisualStyleBackColor = false;
            this.saveUserNameBtn.Click += new System.EventHandler(this.saveUserNameBtn_Click);
            // 
            // vehicleType
            // 
            this.vehicleType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleType.ForeColor = System.Drawing.Color.DarkGray;
            this.vehicleType.Location = new System.Drawing.Point(471, 95);
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.Size = new System.Drawing.Size(246, 25);
            this.vehicleType.TabIndex = 74;
            this.vehicleType.Text = "Vehicle Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(358, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Trips made";
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(484, 182);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(169, 34);
            this.bunifuRating1.TabIndex = 76;
            this.bunifuRating1.Value = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(519, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "label4";
            // 
            // DeliveredOrdersRptBtn
            // 
            this.DeliveredOrdersRptBtn.BackColor = System.Drawing.Color.Black;
            this.DeliveredOrdersRptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeliveredOrdersRptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveredOrdersRptBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveredOrdersRptBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliveredOrdersRptBtn.Location = new System.Drawing.Point(408, 308);
            this.DeliveredOrdersRptBtn.Name = "DeliveredOrdersRptBtn";
            this.DeliveredOrdersRptBtn.Size = new System.Drawing.Size(245, 30);
            this.DeliveredOrdersRptBtn.TabIndex = 78;
            this.DeliveredOrdersRptBtn.Text = "Delivered Orders Report";
            this.DeliveredOrdersRptBtn.UseVisualStyleBackColor = false;
            this.DeliveredOrdersRptBtn.Click += new System.EventHandler(this.DeliveredOrdersRptBtn_Click);
            // 
            // PartnerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 395);
            this.Controls.Add(this.DeliveredOrdersRptBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleType);
            this.Controls.Add(this.saveUserNameBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editUsernameBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savePasswordBtn);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PartnerAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartnerAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartnerAccount_FormClosing);
            this.Load += new System.EventHandler(this.PartnerAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleType;
        private System.Windows.Forms.Button saveUserNameBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editUsernameBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savePasswordBtn;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox userName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button DeliveredOrdersRptBtn;
    }
}