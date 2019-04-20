namespace Uber_Eats_Database_Project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameSignUp = new System.Windows.Forms.TextBox();
            this.passwordSignUp = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.locationTB = new System.Windows.Forms.TextBox();
            this.creditCard = new System.Windows.Forms.TextBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.customerChkBx = new System.Windows.Forms.RadioButton();
            this.partnerChkBx = new System.Windows.Forms.RadioButton();
            this.vehicleTB = new System.Windows.Forms.TextBox();
            this.userNameSignIn = new System.Windows.Forms.TextBox();
            this.passwordSignIn = new System.Windows.Forms.TextBox();
            this.customerChkBxSignIn = new System.Windows.Forms.RadioButton();
            this.partnerChkBxSignIn = new System.Windows.Forms.RadioButton();
            this.signInBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(194, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(527, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign In!";
            // 
            // userNameSignUp
            // 
            this.userNameSignUp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameSignUp.ForeColor = System.Drawing.Color.DarkGray;
            this.userNameSignUp.Location = new System.Drawing.Point(108, 97);
            this.userNameSignUp.Name = "userNameSignUp";
            this.userNameSignUp.Size = new System.Drawing.Size(246, 25);
            this.userNameSignUp.TabIndex = 1;
            this.userNameSignUp.Text = "Username*";
            this.userNameSignUp.Enter += new System.EventHandler(this.textBox1_Enter);
            this.userNameSignUp.Leave += new System.EventHandler(this.userNameSignUp_Leave);
            // 
            // passwordSignUp
            // 
            this.passwordSignUp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignUp.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordSignUp.Location = new System.Drawing.Point(108, 128);
            this.passwordSignUp.Name = "passwordSignUp";
            this.passwordSignUp.Size = new System.Drawing.Size(246, 25);
            this.passwordSignUp.TabIndex = 2;
            this.passwordSignUp.Text = "Password*";
            this.passwordSignUp.Enter += new System.EventHandler(this.passwordSignUp_Enter);
            this.passwordSignUp.Leave += new System.EventHandler(this.passwordSignUp_Leave);
            // 
            // fName
            // 
            this.fName.Enabled = false;
            this.fName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.Color.DarkGray;
            this.fName.Location = new System.Drawing.Point(108, 187);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(246, 25);
            this.fName.TabIndex = 3;
            this.fName.Text = "First Name";
            this.fName.Enter += new System.EventHandler(this.fName_Enter);
            this.fName.Leave += new System.EventHandler(this.fName_Leave);
            // 
            // lName
            // 
            this.lName.Enabled = false;
            this.lName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.DarkGray;
            this.lName.Location = new System.Drawing.Point(108, 219);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(246, 25);
            this.lName.TabIndex = 4;
            this.lName.Text = "Last Name";
            this.lName.Enter += new System.EventHandler(this.lName_Enter);
            this.lName.Leave += new System.EventHandler(this.lName_Leave);
            // 
            // locationTB
            // 
            this.locationTB.Enabled = false;
            this.locationTB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTB.ForeColor = System.Drawing.Color.DarkGray;
            this.locationTB.Location = new System.Drawing.Point(108, 251);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(246, 25);
            this.locationTB.TabIndex = 5;
            this.locationTB.Text = "Location";
            this.locationTB.Enter += new System.EventHandler(this.location_Enter);
            this.locationTB.Leave += new System.EventHandler(this.location_Leave);
            // 
            // creditCard
            // 
            this.creditCard.Enabled = false;
            this.creditCard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCard.ForeColor = System.Drawing.Color.DarkGray;
            this.creditCard.Location = new System.Drawing.Point(108, 286);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(246, 25);
            this.creditCard.TabIndex = 6;
            this.creditCard.Text = "Credit Card";
            this.creditCard.TextChanged += new System.EventHandler(this.creditCard_TextChanged);
            this.creditCard.Enter += new System.EventHandler(this.creditCard_Enter);
            this.creditCard.Leave += new System.EventHandler(this.creditCard_Leave);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Black;
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpBtn.Location = new System.Drawing.Point(188, 354);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 37);
            this.signUpBtn.TabIndex = 9;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            this.signUpBtn.MouseEnter += new System.EventHandler(this.signInBtn_MouseHover);
            this.signUpBtn.MouseLeave += new System.EventHandler(this.signInBtn_MouseLeave);
            // 
            // customerChkBx
            // 
            this.customerChkBx.AutoSize = true;
            this.customerChkBx.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerChkBx.Location = new System.Drawing.Point(108, 157);
            this.customerChkBx.Name = "customerChkBx";
            this.customerChkBx.Size = new System.Drawing.Size(97, 24);
            this.customerChkBx.TabIndex = 7;
            this.customerChkBx.Text = "Customer";
            this.customerChkBx.UseVisualStyleBackColor = true;
            this.customerChkBx.CheckedChanged += new System.EventHandler(this.customerChkBx_CheckedChanged);
            // 
            // partnerChkBx
            // 
            this.partnerChkBx.AutoSize = true;
            this.partnerChkBx.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnerChkBx.Location = new System.Drawing.Point(220, 157);
            this.partnerChkBx.Name = "partnerChkBx";
            this.partnerChkBx.Size = new System.Drawing.Size(144, 24);
            this.partnerChkBx.TabIndex = 8;
            this.partnerChkBx.Text = "Delivery Partner";
            this.partnerChkBx.UseVisualStyleBackColor = true;
            this.partnerChkBx.CheckedChanged += new System.EventHandler(this.partnerChkBx_CheckedChanged);
            // 
            // vehicleTB
            // 
            this.vehicleTB.Enabled = false;
            this.vehicleTB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTB.ForeColor = System.Drawing.Color.DarkGray;
            this.vehicleTB.Location = new System.Drawing.Point(108, 318);
            this.vehicleTB.Name = "vehicleTB";
            this.vehicleTB.Size = new System.Drawing.Size(246, 25);
            this.vehicleTB.TabIndex = 5;
            this.vehicleTB.Text = "Vehicle";
            this.vehicleTB.Enter += new System.EventHandler(this.vehicleTB_Enter);
            this.vehicleTB.Leave += new System.EventHandler(this.vehicleTB_Leave);
            // 
            // userNameSignIn
            // 
            this.userNameSignIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameSignIn.ForeColor = System.Drawing.Color.DarkGray;
            this.userNameSignIn.Location = new System.Drawing.Point(445, 251);
            this.userNameSignIn.Name = "userNameSignIn";
            this.userNameSignIn.Size = new System.Drawing.Size(246, 25);
            this.userNameSignIn.TabIndex = 10;
            this.userNameSignIn.Text = "Username*";
            this.userNameSignIn.Enter += new System.EventHandler(this.textBox1_Enter);
            this.userNameSignIn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userNameSignIn_KeyUp);
            this.userNameSignIn.Leave += new System.EventHandler(this.userNameSignUp_Leave);
            // 
            // passwordSignIn
            // 
            this.passwordSignIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignIn.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordSignIn.Location = new System.Drawing.Point(445, 283);
            this.passwordSignIn.Name = "passwordSignIn";
            this.passwordSignIn.Size = new System.Drawing.Size(246, 25);
            this.passwordSignIn.TabIndex = 11;
            this.passwordSignIn.Text = "Password*";
            this.passwordSignIn.Enter += new System.EventHandler(this.passwordSignUp_Enter);
            this.passwordSignIn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordSignIn_KeyUp);
            this.passwordSignIn.Leave += new System.EventHandler(this.passwordSignUp_Leave);
            // 
            // customerChkBxSignIn
            // 
            this.customerChkBxSignIn.AutoSize = true;
            this.customerChkBxSignIn.Checked = true;
            this.customerChkBxSignIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerChkBxSignIn.Location = new System.Drawing.Point(9, 5);
            this.customerChkBxSignIn.Name = "customerChkBxSignIn";
            this.customerChkBxSignIn.Size = new System.Drawing.Size(97, 24);
            this.customerChkBxSignIn.TabIndex = 12;
            this.customerChkBxSignIn.TabStop = true;
            this.customerChkBxSignIn.Text = "Customer";
            this.customerChkBxSignIn.UseVisualStyleBackColor = true;
            // 
            // partnerChkBxSignIn
            // 
            this.partnerChkBxSignIn.AutoSize = true;
            this.partnerChkBxSignIn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partnerChkBxSignIn.Location = new System.Drawing.Point(112, 5);
            this.partnerChkBxSignIn.Name = "partnerChkBxSignIn";
            this.partnerChkBxSignIn.Size = new System.Drawing.Size(144, 24);
            this.partnerChkBxSignIn.TabIndex = 13;
            this.partnerChkBxSignIn.Text = "Delivery Partner";
            this.partnerChkBxSignIn.UseVisualStyleBackColor = true;
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.Black;
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signInBtn.Location = new System.Drawing.Point(522, 354);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(75, 37);
            this.signInBtn.TabIndex = 14;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            this.signInBtn.MouseEnter += new System.EventHandler(this.signInBtn_MouseHover);
            this.signInBtn.MouseLeave += new System.EventHandler(this.signInBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerChkBxSignIn);
            this.panel1.Controls.Add(this.partnerChkBxSignIn);
            this.panel1.Location = new System.Drawing.Point(440, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 33);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 29);
            this.header.TabIndex = 16;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageActive = null;
            this.exit.Location = new System.Drawing.Point(765, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 17;
            this.exit.TabStop = false;
            this.exit.Zoom = 20;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(387, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 302);
            this.panel2.TabIndex = 17;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partnerChkBx);
            this.Controls.Add(this.customerChkBx);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.vehicleTB);
            this.Controls.Add(this.creditCard);
            this.Controls.Add(this.locationTB);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.passwordSignIn);
            this.Controls.Add(this.userNameSignIn);
            this.Controls.Add(this.passwordSignUp);
            this.Controls.Add(this.userNameSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameSignUp;
        private System.Windows.Forms.TextBox passwordSignUp;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox locationTB;
        private System.Windows.Forms.TextBox creditCard;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.RadioButton customerChkBx;
        private System.Windows.Forms.RadioButton partnerChkBx;
        private System.Windows.Forms.TextBox vehicleTB;
        private System.Windows.Forms.TextBox userNameSignIn;
        private System.Windows.Forms.TextBox passwordSignIn;
        private System.Windows.Forms.RadioButton customerChkBxSignIn;
        private System.Windows.Forms.RadioButton partnerChkBxSignIn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
    }
}