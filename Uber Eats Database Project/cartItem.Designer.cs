namespace Uber_Eats_Database_Project
{
    partial class cartItem
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
        public void InitializeComponent()
        {
            this.FoodName = new System.Windows.Forms.Label();
            this.RestName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.NoOfItems = new System.Windows.Forms.NumericUpDown();
            this.Remove = new System.Windows.Forms.Button();
            this.RestLoc = new System.Windows.Forms.Label();
            this.FoodImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodName
            // 
            this.FoodName.AutoSize = true;
            this.FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodName.Location = new System.Drawing.Point(113, 19);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(85, 16);
            this.FoodName.TabIndex = 0;
            this.FoodName.Text = "FoodName";
            // 
            // RestName
            // 
            this.RestName.AutoSize = true;
            this.RestName.Location = new System.Drawing.Point(122, 42);
            this.RestName.Name = "RestName";
            this.RestName.Size = new System.Drawing.Size(57, 13);
            this.RestName.TabIndex = 1;
            this.RestName.Text = "RestName";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Firebrick;
            this.Price.Location = new System.Drawing.Point(122, 68);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(36, 13);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.ForeColor = System.Drawing.Color.Firebrick;
            this.Discount.Location = new System.Drawing.Point(233, 68);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(57, 13);
            this.Discount.TabIndex = 5;
            this.Discount.Text = "Discount";
            // 
            // NoOfItems
            // 
            this.NoOfItems.Location = new System.Drawing.Point(363, 19);
            this.NoOfItems.Name = "NoOfItems";
            this.NoOfItems.Size = new System.Drawing.Size(105, 20);
            this.NoOfItems.TabIndex = 8;
            this.NoOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Black;
            this.Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remove.Location = new System.Drawing.Point(363, 52);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(105, 29);
            this.Remove.TabIndex = 36;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // RestLoc
            // 
            this.RestLoc.AutoSize = true;
            this.RestLoc.Location = new System.Drawing.Point(233, 42);
            this.RestLoc.Name = "RestLoc";
            this.RestLoc.Size = new System.Drawing.Size(47, 13);
            this.RestLoc.TabIndex = 37;
            this.RestLoc.Text = "RestLoc";
            // 
            // FoodImage
            // 
            this.FoodImage.Location = new System.Drawing.Point(14, 17);
            this.FoodImage.Name = "FoodImage";
            this.FoodImage.Size = new System.Drawing.Size(71, 71);
            this.FoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FoodImage.TabIndex = 38;
            this.FoodImage.TabStop = false;
            // 
            // cartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.FoodImage);
            this.Controls.Add(this.RestLoc);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.NoOfItems);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.RestName);
            this.Controls.Add(this.FoodName);
            this.Name = "cartItem";
            this.Size = new System.Drawing.Size(494, 102);
            ((System.ComponentModel.ISupportInitialize)(this.NoOfItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label FoodName;
        public System.Windows.Forms.Label RestName;
        public System.Windows.Forms.Label Price;
        public System.Windows.Forms.Label Discount;
        public System.Windows.Forms.NumericUpDown NoOfItems;
        public System.Windows.Forms.Button Remove;
        public System.Windows.Forms.Label RestLoc;
        public System.Windows.Forms.PictureBox FoodImage;
    }
}
