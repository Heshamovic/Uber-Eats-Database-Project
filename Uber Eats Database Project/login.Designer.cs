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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign In!";
            // 
            // userNameSignUp
            // 
            this.userNameSignUp.ForeColor = System.Drawing.Color.DarkGray;
            this.userNameSignUp.Location = new System.Drawing.Point(124, 97);
            this.userNameSignUp.Name = "userNameSignUp";
            this.userNameSignUp.Size = new System.Drawing.Size(175, 20);
            this.userNameSignUp.TabIndex = 1;
            this.userNameSignUp.Text = "Username*";
            this.userNameSignUp.Enter += new System.EventHandler(this.textBox1_Enter);
            this.userNameSignUp.Leave += new System.EventHandler(this.userNameSignUp_Leave);
            // 
            // passwordSignUp
            // 
            this.passwordSignUp.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordSignUp.Location = new System.Drawing.Point(124, 128);
            this.passwordSignUp.Name = "passwordSignUp";
            this.passwordSignUp.Size = new System.Drawing.Size(175, 20);
            this.passwordSignUp.TabIndex = 2;
            this.passwordSignUp.Text = "Password*";
            this.passwordSignUp.Enter += new System.EventHandler(this.passwordSignUp_Enter);
            this.passwordSignUp.Leave += new System.EventHandler(this.passwordSignUp_Leave);
            // 
            // fName
            // 
            this.fName.Enabled = false;
            this.fName.ForeColor = System.Drawing.Color.DarkGray;
            this.fName.Location = new System.Drawing.Point(125, 187);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(175, 20);
            this.fName.TabIndex = 3;
            this.fName.Text = "First Name";
            this.fName.Enter += new System.EventHandler(this.fName_Enter);
            this.fName.Leave += new System.EventHandler(this.fName_Leave);
            // 
            // lName
            // 
            this.lName.Enabled = false;
            this.lName.ForeColor = System.Drawing.Color.DarkGray;
            this.lName.Location = new System.Drawing.Point(125, 219);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(175, 20);
            this.lName.TabIndex = 4;
            this.lName.Text = "Last Name";
            this.lName.Enter += new System.EventHandler(this.lName_Enter);
            this.lName.Leave += new System.EventHandler(this.lName_Leave);
            // 
            // locationTB
            // 
            this.locationTB.Enabled = false;
            this.locationTB.ForeColor = System.Drawing.Color.DarkGray;
            this.locationTB.Location = new System.Drawing.Point(125, 251);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(175, 20);
            this.locationTB.TabIndex = 5;
            this.locationTB.Text = "Location";
            this.locationTB.Enter += new System.EventHandler(this.location_Enter);
            this.locationTB.Leave += new System.EventHandler(this.location_Leave);
            // 
            // creditCard
            // 
            this.creditCard.Enabled = false;
            this.creditCard.ForeColor = System.Drawing.Color.DarkGray;
            this.creditCard.Location = new System.Drawing.Point(125, 286);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(175, 20);
            this.creditCard.TabIndex = 6;
            this.creditCard.Text = "Credit Card";
            this.creditCard.TextChanged += new System.EventHandler(this.creditCard_TextChanged);
            this.creditCard.Enter += new System.EventHandler(this.creditCard_Enter);
            this.creditCard.Leave += new System.EventHandler(this.creditCard_Leave);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(166, 354);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 23);
            this.signUpBtn.TabIndex = 9;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // customerChkBx
            // 
            this.customerChkBx.AutoSize = true;
            this.customerChkBx.Location = new System.Drawing.Point(125, 154);
            this.customerChkBx.Name = "customerChkBx";
            this.customerChkBx.Size = new System.Drawing.Size(69, 17);
            this.customerChkBx.TabIndex = 7;
            this.customerChkBx.Text = "Customer";
            this.customerChkBx.UseVisualStyleBackColor = true;
            this.customerChkBx.CheckedChanged += new System.EventHandler(this.customerChkBx_CheckedChanged);
            // 
            // partnerChkBx
            // 
            this.partnerChkBx.AutoSize = true;
            this.partnerChkBx.Location = new System.Drawing.Point(200, 154);
            this.partnerChkBx.Name = "partnerChkBx";
            this.partnerChkBx.Size = new System.Drawing.Size(100, 17);
            this.partnerChkBx.TabIndex = 8;
            this.partnerChkBx.Text = "Delivery Partner";
            this.partnerChkBx.UseVisualStyleBackColor = true;
            // 
            // vehicleTB
            // 
            this.vehicleTB.Enabled = false;
            this.vehicleTB.ForeColor = System.Drawing.Color.DarkGray;
            this.vehicleTB.Location = new System.Drawing.Point(125, 318);
            this.vehicleTB.Name = "vehicleTB";
            this.vehicleTB.Size = new System.Drawing.Size(175, 20);
            this.vehicleTB.TabIndex = 5;
            this.vehicleTB.Text = "Vehicle";
            this.vehicleTB.Enter += new System.EventHandler(this.location_Enter);
            this.vehicleTB.Leave += new System.EventHandler(this.location_Leave);
            // 
            // userNameSignIn
            // 
            this.userNameSignIn.ForeColor = System.Drawing.Color.DarkGray;
            this.userNameSignIn.Location = new System.Drawing.Point(468, 97);
            this.userNameSignIn.Name = "userNameSignIn";
            this.userNameSignIn.Size = new System.Drawing.Size(175, 20);
            this.userNameSignIn.TabIndex = 10;
            this.userNameSignIn.Text = "Username*";
            this.userNameSignIn.Enter += new System.EventHandler(this.textBox1_Enter);
            this.userNameSignIn.Leave += new System.EventHandler(this.userNameSignUp_Leave);
            // 
            // passwordSignIn
            // 
            this.passwordSignIn.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordSignIn.Location = new System.Drawing.Point(468, 128);
            this.passwordSignIn.Name = "passwordSignIn";
            this.passwordSignIn.Size = new System.Drawing.Size(175, 20);
            this.passwordSignIn.TabIndex = 11;
            this.passwordSignIn.Text = "Password*";
            this.passwordSignIn.Enter += new System.EventHandler(this.passwordSignUp_Enter);
            this.passwordSignIn.Leave += new System.EventHandler(this.passwordSignUp_Leave);
            // 
            // customerChkBxSignIn
            // 
            this.customerChkBxSignIn.AutoSize = true;
            this.customerChkBxSignIn.Location = new System.Drawing.Point(9, 5);
            this.customerChkBxSignIn.Name = "customerChkBxSignIn";
            this.customerChkBxSignIn.Size = new System.Drawing.Size(69, 17);
            this.customerChkBxSignIn.TabIndex = 12;
            this.customerChkBxSignIn.Text = "Customer";
            this.customerChkBxSignIn.UseVisualStyleBackColor = true;
            // 
            // partnerChkBxSignIn
            // 
            this.partnerChkBxSignIn.AutoSize = true;
            this.partnerChkBxSignIn.Location = new System.Drawing.Point(84, 5);
            this.partnerChkBxSignIn.Name = "partnerChkBxSignIn";
            this.partnerChkBxSignIn.Size = new System.Drawing.Size(100, 17);
            this.partnerChkBxSignIn.TabIndex = 13;
            this.partnerChkBxSignIn.Text = "Delivery Partner";
            this.partnerChkBxSignIn.UseVisualStyleBackColor = true;
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(514, 187);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(75, 23);
            this.signInBtn.TabIndex = 14;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerChkBxSignIn);
            this.panel1.Controls.Add(this.partnerChkBxSignIn);
            this.panel1.Location = new System.Drawing.Point(459, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 33);
            this.panel1.TabIndex = 10;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}