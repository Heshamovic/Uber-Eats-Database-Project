namespace Uber_Eats_Database_Project
{
    partial class restaurants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restaurants));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.resturant = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.top_dish = new System.Windows.Forms.PictureBox();
            this.res_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.res_type = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.res_rating = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.header.SuspendLayout();
            this.resturant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top_dish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageActive = null;
            this.exit.Location = new System.Drawing.Point(765, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 17;
            this.exit.TabStop = false;
            this.exit.Zoom = 20;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 29);
            this.header.TabIndex = 35;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // resturant
            // 
            this.resturant.BackColor = System.Drawing.Color.White;
            this.resturant.BorderRadius = 5;
            this.resturant.BottomSahddow = true;
            this.resturant.color = System.Drawing.Color.Black;
            this.resturant.Controls.Add(this.res_rating);
            this.resturant.Controls.Add(this.res_type);
            this.resturant.Controls.Add(this.res_name);
            this.resturant.Controls.Add(this.top_dish);
            this.resturant.LeftSahddow = false;
            this.resturant.Location = new System.Drawing.Point(105, 70);
            this.resturant.Name = "resturant";
            this.resturant.RightSahddow = true;
            this.resturant.ShadowDepth = 20;
            this.resturant.Size = new System.Drawing.Size(589, 170);
            this.resturant.TabIndex = 36;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(342, 31);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 23);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "restaurants";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top_dish
            // 
            this.top_dish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_dish.Location = new System.Drawing.Point(0, 5);
            this.top_dish.Name = "top_dish";
            this.top_dish.Size = new System.Drawing.Size(587, 162);
            this.top_dish.TabIndex = 1;
            this.top_dish.TabStop = false;
            this.top_dish.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // res_name
            // 
            this.res_name.AutoSize = true;
            this.res_name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_name.Location = new System.Drawing.Point(483, 5);
            this.res_name.Name = "res_name";
            this.res_name.Size = new System.Drawing.Size(104, 23);
            this.res_name.TabIndex = 38;
            this.res_name.Text = "restaurants";
            this.res_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res_type
            // 
            this.res_type.AutoSize = true;
            this.res_type.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_type.Location = new System.Drawing.Point(-4, 5);
            this.res_type.Name = "res_type";
            this.res_type.Size = new System.Drawing.Size(104, 23);
            this.res_type.TabIndex = 39;
            this.res_type.Text = "restaurants";
            this.res_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // res_rating
            // 
            this.res_rating.AutoSize = true;
            this.res_rating.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_rating.Location = new System.Drawing.Point(237, 144);
            this.res_rating.Name = "res_rating";
            this.res_rating.Size = new System.Drawing.Size(104, 23);
            this.res_rating.TabIndex = 40;
            this.res_rating.Text = "restaurants";
            this.res_rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(720, 413);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(80, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 38;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // restaurants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.resturant);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "restaurants";
            this.Text = "restaurants";
            this.Load += new System.EventHandler(this.restaurants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.header.ResumeLayout(false);
            this.resturant.ResumeLayout(false);
            this.resturant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top_dish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards resturant;
        private System.Windows.Forms.PictureBox top_dish;
        private Bunifu.Framework.UI.BunifuCustomLabel res_rating;
        private Bunifu.Framework.UI.BunifuCustomLabel res_type;
        private Bunifu.Framework.UI.BunifuCustomLabel res_name;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}