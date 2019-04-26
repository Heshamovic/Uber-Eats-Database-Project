namespace Uber_Eats_Database_Project
{
    partial class Order_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_details));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.Order_detail_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Order_Details_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_detail_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.Order_detail_close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 29);
            this.header.TabIndex = 35;
            // 
            // Order_detail_close
            // 
            this.Order_detail_close.BackColor = System.Drawing.Color.Transparent;
            this.Order_detail_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Order_detail_close.Image = ((System.Drawing.Image)(resources.GetObject("Order_detail_close.Image")));
            this.Order_detail_close.ImageActive = null;
            this.Order_detail_close.Location = new System.Drawing.Point(763, 2);
            this.Order_detail_close.Margin = new System.Windows.Forms.Padding(2);
            this.Order_detail_close.Name = "Order_detail_close";
            this.Order_detail_close.Size = new System.Drawing.Size(26, 27);
            this.Order_detail_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Order_detail_close.TabIndex = 30;
            this.Order_detail_close.TabStop = false;
            this.Order_detail_close.Zoom = 20;
            this.Order_detail_close.Click += new System.EventHandler(this.Order_detail_close_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Order_Details_Panel
            // 
            this.Order_Details_Panel.AutoScroll = true;
            this.Order_Details_Panel.BackColor = System.Drawing.Color.SteelBlue;
            this.Order_Details_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Order_Details_Panel.Location = new System.Drawing.Point(0, 29);
            this.Order_Details_Panel.Name = "Order_Details_Panel";
            this.Order_Details_Panel.Size = new System.Drawing.Size(541, 421);
            this.Order_Details_Panel.TabIndex = 37;
            // 
            // Order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Order_Details_Panel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_details";
            this.Text = "Order_details";
            this.Load += new System.EventHandler(this.Order_details_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Order_detail_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.FlowLayoutPanel Order_Details_Panel;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton Order_detail_close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}