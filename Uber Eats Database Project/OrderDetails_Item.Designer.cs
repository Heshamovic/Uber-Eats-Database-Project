namespace Uber_Eats_Database_Project
{
    partial class OrderDetails_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails_Item));
            this.RestLoc1 = new System.Windows.Forms.Label();
            this.RestName1 = new System.Windows.Forms.Label();
            this.Price1 = new System.Windows.Forms.Label();
            this.Discount1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Food_Name1 = new System.Windows.Forms.Label();
            this.No_of_items1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // RestLoc1
            // 
            this.RestLoc1.AutoSize = true;
            this.RestLoc1.Location = new System.Drawing.Point(318, 74);
            this.RestLoc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestLoc1.Name = "RestLoc1";
            this.RestLoc1.Size = new System.Drawing.Size(69, 20);
            this.RestLoc1.TabIndex = 45;
            this.RestLoc1.Text = "RestLoc";
            // 
            // RestName1
            // 
            this.RestName1.AutoSize = true;
            this.RestName1.Location = new System.Drawing.Point(177, 72);
            this.RestName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestName1.Name = "RestName1";
            this.RestName1.Size = new System.Drawing.Size(85, 20);
            this.RestName1.TabIndex = 39;
            this.RestName1.Text = "RestName";
            // 
            // Price1
            // 
            this.Price1.AutoSize = true;
            this.Price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price1.ForeColor = System.Drawing.Color.Firebrick;
            this.Price1.Location = new System.Drawing.Point(189, 112);
            this.Price1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(53, 20);
            this.Price1.TabIndex = 40;
            this.Price1.Text = "Price";
            // 
            // Discount1
            // 
            this.Discount1.AutoSize = true;
            this.Discount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount1.ForeColor = System.Drawing.Color.Firebrick;
            this.Discount1.Location = new System.Drawing.Point(308, 112);
            this.Discount1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Discount1.Name = "Discount1";
            this.Discount1.Size = new System.Drawing.Size(84, 20);
            this.Discount1.TabIndex = 42;
            this.Discount1.Text = "Discount";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(30, 37);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(106, 109);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 46;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // Food_Name1
            // 
            this.Food_Name1.AutoSize = true;
            this.Food_Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_Name1.Location = new System.Drawing.Point(166, 37);
            this.Food_Name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Food_Name1.Name = "Food_Name1";
            this.Food_Name1.Size = new System.Drawing.Size(123, 25);
            this.Food_Name1.TabIndex = 47;
            this.Food_Name1.Text = "Food Name";
            // 
            // No_of_items1
            // 
            this.No_of_items1.AutoSize = true;
            this.No_of_items1.Location = new System.Drawing.Point(477, 74);
            this.No_of_items1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.No_of_items1.Name = "No_of_items1";
            this.No_of_items1.Size = new System.Drawing.Size(99, 20);
            this.No_of_items1.TabIndex = 48;
            this.No_of_items1.Text = "No_of_items";
            // 
            // OrderDetails_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.No_of_items1);
            this.Controls.Add(this.Food_Name1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.RestLoc1);
            this.Controls.Add(this.Discount1);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.RestName1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderDetails_Item";
            this.Size = new System.Drawing.Size(699, 174);
            this.Load += new System.EventHandler(this.OrderDetails_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label RestLoc1;
        public System.Windows.Forms.Label RestName1;
        public System.Windows.Forms.Label Price1;
        public System.Windows.Forms.Label Discount1;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public System.Windows.Forms.Label Food_Name1;
        public System.Windows.Forms.Label No_of_items1;
    }
}
