namespace Uber_Eats_Database_Project
{
    partial class resfooditem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resfooditem));
            this.foodimg = new System.Windows.Forms.PictureBox();
            this.restimg = new Bunifu.Framework.UI.BunifuCards();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resl = new System.Windows.Forms.Label();
            this.resn = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.topdish = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ing = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.price = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.foodimg)).BeginInit();
            this.restimg.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodimg
            // 
            this.foodimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodimg.Location = new System.Drawing.Point(0, 0);
            this.foodimg.Name = "foodimg";
            this.foodimg.Size = new System.Drawing.Size(561, 142);
            this.foodimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.foodimg.TabIndex = 4;
            this.foodimg.TabStop = false;
            this.foodimg.Click += new System.EventHandler(this.foodimg_Click);
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
            this.restimg.Size = new System.Drawing.Size(561, 198);
            this.restimg.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.foodimg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 142);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resl);
            this.panel2.Controls.Add(this.resn);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.topdish);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ing);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 31);
            this.panel2.TabIndex = 6;
            // 
            // resl
            // 
            this.resl.AutoSize = true;
            this.resl.Location = new System.Drawing.Point(154, 8);
            this.resl.Name = "resl";
            this.resl.Size = new System.Drawing.Size(35, 13);
            this.resl.TabIndex = 7;
            this.resl.Text = "label5";
            // 
            // resn
            // 
            this.resn.AutoSize = true;
            this.resn.Location = new System.Drawing.Point(96, 8);
            this.resn.Name = "resn";
            this.resn.Size = new System.Drawing.Size(27, 13);
            this.resn.TabIndex = 6;
            this.resn.Text = "resn";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(465, 8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(510, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // topdish
            // 
            this.topdish.AutoSize = true;
            this.topdish.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topdish.Location = new System.Drawing.Point(3, 3);
            this.topdish.Name = "topdish";
            this.topdish.Size = new System.Drawing.Size(69, 18);
            this.topdish.TabIndex = 2;
            this.topdish.Text = "Top Dish";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "INGREDIANTS : ";
            // 
            // ing
            // 
            this.ing.AutoSize = true;
            this.ing.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ing.Location = new System.Drawing.Point(324, 3);
            this.ing.Name = "ing";
            this.ing.Size = new System.Drawing.Size(54, 18);
            this.ing.TabIndex = 0;
            this.ing.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.discount);
            this.panel1.Controls.Add(this.bunifuRating1);
            this.panel1.Controls.Add(this.price);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 25);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(135, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 18);
            this.name.TabIndex = 1;
            this.name.Text = "label2";
            // 
            // discount
            // 
            this.discount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(346, 0);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(54, 18);
            this.discount.TabIndex = 3;
            this.discount.Text = "label1";
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(0, 0);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(107, 23);
            this.bunifuRating1.TabIndex = 0;
            this.bunifuRating1.Value = 1;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Dock = System.Windows.Forms.DockStyle.Right;
            this.price.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(505, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(54, 18);
            this.price.TabIndex = 2;
            this.price.Text = "label1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 198);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // resfooditem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.restimg);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 20);
            this.Name = "resfooditem";
            this.Size = new System.Drawing.Size(564, 198);
            ((System.ComponentModel.ISupportInitialize)(this.foodimg)).EndInit();
            this.restimg.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox foodimg;
        private Bunifu.Framework.UI.BunifuCards restimg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label discount;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label topdish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label resl;
        private System.Windows.Forms.Label resn;
    }
}
