namespace Uber_Eats_Database_Project
{
    partial class UserOrderItem
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
            this.Order_Number = new System.Windows.Forms.Label();
            this.Order_Status = new System.Windows.Forms.Label();
            this.Show_Order_Items = new System.Windows.Forms.Button();
            this.Total_Price = new System.Windows.Forms.Label();
            this.Price_integer = new System.Windows.Forms.Label();
            this.Order_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Order_Number
            // 
            this.Order_Number.AutoSize = true;
            this.Order_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Number.Location = new System.Drawing.Point(14, 14);
            this.Order_Number.Name = "Order_Number";
            this.Order_Number.Size = new System.Drawing.Size(105, 16);
            this.Order_Number.TabIndex = 46;
            this.Order_Number.Text = "Order Number";
            // 
            // Order_Status
            // 
            this.Order_Status.AutoSize = true;
            this.Order_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Status.Location = new System.Drawing.Point(18, 46);
            this.Order_Status.Name = "Order_Status";
            this.Order_Status.Size = new System.Drawing.Size(94, 16);
            this.Order_Status.TabIndex = 47;
            this.Order_Status.Text = "Order Status";
            // 
            // Show_Order_Items
            // 
            this.Show_Order_Items.BackColor = System.Drawing.Color.Black;
            this.Show_Order_Items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_Order_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_Order_Items.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Order_Items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Show_Order_Items.Location = new System.Drawing.Point(298, 67);
            this.Show_Order_Items.Name = "Show_Order_Items";
            this.Show_Order_Items.Size = new System.Drawing.Size(178, 32);
            this.Show_Order_Items.TabIndex = 48;
            this.Show_Order_Items.Text = "Show Order Items";
            this.Show_Order_Items.UseVisualStyleBackColor = false;
            this.Show_Order_Items.Click += new System.EventHandler(this.Show_Order_Items_Click);
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSize = true;
            this.Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price.ForeColor = System.Drawing.Color.Firebrick;
            this.Total_Price.Location = new System.Drawing.Point(337, 11);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(126, 25);
            this.Total_Price.TabIndex = 49;
            this.Total_Price.Text = "Total Price";
            // 
            // Price_integer
            // 
            this.Price_integer.AutoSize = true;
            this.Price_integer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_integer.ForeColor = System.Drawing.Color.Firebrick;
            this.Price_integer.Location = new System.Drawing.Point(361, 41);
            this.Price_integer.Name = "Price_integer";
            this.Price_integer.Size = new System.Drawing.Size(82, 13);
            this.Price_integer.TabIndex = 50;
            this.Price_integer.Text = "Price_integer";
            // 
            // Order_Time
            // 
            this.Order_Time.AutoSize = true;
            this.Order_Time.Location = new System.Drawing.Point(22, 81);
            this.Order_Time.Name = "Order_Time";
            this.Order_Time.Size = new System.Drawing.Size(59, 13);
            this.Order_Time.TabIndex = 51;
            this.Order_Time.Text = "Order Time";
            // 
            // UserOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Order_Time);
            this.Controls.Add(this.Price_integer);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.Show_Order_Items);
            this.Controls.Add(this.Order_Status);
            this.Controls.Add(this.Order_Number);
            this.Name = "UserOrderItem";
            this.Size = new System.Drawing.Size(480, 108);
            this.Load += new System.EventHandler(this.UserOrderItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Order_Number;
        public System.Windows.Forms.Label Order_Status;
        public System.Windows.Forms.Button Show_Order_Items;
        public System.Windows.Forms.Label Total_Price;
        public System.Windows.Forms.Label Price_integer;
        public System.Windows.Forms.Label Order_Time;
    }
}
