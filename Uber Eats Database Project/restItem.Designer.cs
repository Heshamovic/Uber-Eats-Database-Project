namespace Uber_Eats_Database_Project
{
    partial class restItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restItem));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.restimg = new Bunifu.Framework.UI.BunifuCards();
            this.panel3 = new System.Windows.Forms.Panel();
            this.foodimg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.type = new System.Windows.Forms.Label();
            this.restimg.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodimg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 256);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // restimg
            // 
            this.restimg.BackColor = System.Drawing.Color.White;
            this.restimg.BorderRadius = 5;
            this.restimg.BottomSahddow = true;
            this.restimg.color = System.Drawing.Color.Transparent;
            this.restimg.Controls.Add(this.panel3);
            this.restimg.Controls.Add(this.panel2);
            this.restimg.Controls.Add(this.panel1);
            this.restimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restimg.LeftSahddow = false;
            this.restimg.Location = new System.Drawing.Point(3, 0);
            this.restimg.Name = "restimg";
            this.restimg.RightSahddow = true;
            this.restimg.ShadowDepth = 20;
            this.restimg.Size = new System.Drawing.Size(547, 256);
            this.restimg.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.foodimg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 200);
            this.panel3.TabIndex = 7;
            // 
            // foodimg
            // 
            this.foodimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodimg.Location = new System.Drawing.Point(0, 0);
            this.foodimg.Name = "foodimg";
            this.foodimg.Size = new System.Drawing.Size(547, 200);
            this.foodimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.foodimg.TabIndex = 4;
            this.foodimg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 31);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(495, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(154, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 3;
            this.name.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuRating1);
            this.panel1.Controls.Add(this.type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 25);
            this.panel1.TabIndex = 5;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(0, 0);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(200, 25);
            this.bunifuRating1.TabIndex = 0;
            this.bunifuRating1.Value = 1;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Dock = System.Windows.Forms.DockStyle.Right;
            this.type.Font = new System.Drawing.Font("Tahoma", 12F);
            this.type.Location = new System.Drawing.Point(496, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(51, 19);
            this.type.TabIndex = 2;
            this.type.Text = "label1";
            // 
            // restItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.restimg);
            this.Controls.Add(this.splitter1);
            this.Name = "restItem";
            this.Size = new System.Drawing.Size(550, 256);
            this.restimg.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodimg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private Bunifu.Framework.UI.BunifuCards restimg;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.PictureBox foodimg;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
    }
}
