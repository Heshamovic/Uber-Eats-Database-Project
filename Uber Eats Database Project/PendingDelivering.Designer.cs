namespace Uber_Eats_Database_Project
{
    partial class PendingDelivering
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingDelivering));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OrdersGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderDeliveredBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CancelDeliveryBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.foodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bought = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
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
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 29);
            this.header.TabIndex = 28;
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
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // OrdersGV
            // 
            this.OrdersGV.AllowUserToAddRows = false;
            this.OrdersGV.AllowUserToDeleteRows = false;
            this.OrdersGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OrdersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrdersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.OrdersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodname,
            this.RestName,
            this.RestLoc,
            this.NoItems,
            this.Bought});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrdersGV.DoubleBuffered = true;
            this.OrdersGV.EnableHeadersVisualStyles = false;
            this.OrdersGV.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.OrdersGV.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.OrdersGV.Location = new System.Drawing.Point(0, 29);
            this.OrdersGV.MinimumSize = new System.Drawing.Size(800, 0);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersGV.Size = new System.Drawing.Size(800, 336);
            this.OrdersGV.TabIndex = 29;
            this.OrdersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGV_CellContentClick);
            // 
            // OrderDeliveredBtn
            // 
            this.OrderDeliveredBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OrderDeliveredBtn.BackColor = System.Drawing.Color.Black;
            this.OrderDeliveredBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrderDeliveredBtn.BorderRadius = 0;
            this.OrderDeliveredBtn.ButtonText = "Order Delivered";
            this.OrderDeliveredBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderDeliveredBtn.DisabledColor = System.Drawing.Color.DimGray;
            this.OrderDeliveredBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderDeliveredBtn.Enabled = false;
            this.OrderDeliveredBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDeliveredBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.OrderDeliveredBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("OrderDeliveredBtn.Iconimage")));
            this.OrderDeliveredBtn.Iconimage_right = null;
            this.OrderDeliveredBtn.Iconimage_right_Selected = null;
            this.OrderDeliveredBtn.Iconimage_Selected = null;
            this.OrderDeliveredBtn.IconMarginLeft = 30;
            this.OrderDeliveredBtn.IconMarginRight = 0;
            this.OrderDeliveredBtn.IconRightVisible = true;
            this.OrderDeliveredBtn.IconRightZoom = 0D;
            this.OrderDeliveredBtn.IconVisible = true;
            this.OrderDeliveredBtn.IconZoom = 100D;
            this.OrderDeliveredBtn.IsTab = false;
            this.OrderDeliveredBtn.Location = new System.Drawing.Point(0, 365);
            this.OrderDeliveredBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OrderDeliveredBtn.Name = "OrderDeliveredBtn";
            this.OrderDeliveredBtn.Normalcolor = System.Drawing.Color.Black;
            this.OrderDeliveredBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.OrderDeliveredBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.OrderDeliveredBtn.selected = false;
            this.OrderDeliveredBtn.Size = new System.Drawing.Size(400, 85);
            this.OrderDeliveredBtn.TabIndex = 30;
            this.OrderDeliveredBtn.Text = "Order Delivered";
            this.OrderDeliveredBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrderDeliveredBtn.Textcolor = System.Drawing.Color.White;
            this.OrderDeliveredBtn.TextFont = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDeliveredBtn.Click += new System.EventHandler(this.OrderDeliveredBtn_Click);
            // 
            // CancelDeliveryBtn
            // 
            this.CancelDeliveryBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CancelDeliveryBtn.BackColor = System.Drawing.Color.Black;
            this.CancelDeliveryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelDeliveryBtn.BorderRadius = 0;
            this.CancelDeliveryBtn.ButtonText = "Cancel Delivery";
            this.CancelDeliveryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelDeliveryBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CancelDeliveryBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelDeliveryBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDeliveryBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CancelDeliveryBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("CancelDeliveryBtn.Iconimage")));
            this.CancelDeliveryBtn.Iconimage_right = null;
            this.CancelDeliveryBtn.Iconimage_right_Selected = null;
            this.CancelDeliveryBtn.Iconimage_Selected = null;
            this.CancelDeliveryBtn.IconMarginLeft = 30;
            this.CancelDeliveryBtn.IconMarginRight = 0;
            this.CancelDeliveryBtn.IconRightVisible = true;
            this.CancelDeliveryBtn.IconRightZoom = 0D;
            this.CancelDeliveryBtn.IconVisible = true;
            this.CancelDeliveryBtn.IconZoom = 100D;
            this.CancelDeliveryBtn.IsTab = false;
            this.CancelDeliveryBtn.Location = new System.Drawing.Point(400, 365);
            this.CancelDeliveryBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelDeliveryBtn.Name = "CancelDeliveryBtn";
            this.CancelDeliveryBtn.Normalcolor = System.Drawing.Color.Black;
            this.CancelDeliveryBtn.OnHovercolor = System.Drawing.Color.Red;
            this.CancelDeliveryBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CancelDeliveryBtn.selected = false;
            this.CancelDeliveryBtn.Size = new System.Drawing.Size(400, 85);
            this.CancelDeliveryBtn.TabIndex = 31;
            this.CancelDeliveryBtn.Text = "Cancel Delivery";
            this.CancelDeliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelDeliveryBtn.Textcolor = System.Drawing.Color.White;
            this.CancelDeliveryBtn.TextFont = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // foodname
            // 
            this.foodname.FillWeight = 75F;
            this.foodname.HeaderText = "Food";
            this.foodname.Name = "foodname";
            this.foodname.ReadOnly = true;
            // 
            // RestName
            // 
            this.RestName.FillWeight = 75F;
            this.RestName.HeaderText = "Restaurant";
            this.RestName.Name = "RestName";
            this.RestName.ReadOnly = true;
            // 
            // RestLoc
            // 
            this.RestLoc.FillWeight = 280F;
            this.RestLoc.HeaderText = "Restaurant Location";
            this.RestLoc.Name = "RestLoc";
            this.RestLoc.ReadOnly = true;
            // 
            // NoItems
            // 
            this.NoItems.FillWeight = 25F;
            this.NoItems.HeaderText = "#";
            this.NoItems.Name = "NoItems";
            this.NoItems.ReadOnly = true;
            // 
            // Bought
            // 
            this.Bought.FalseValue = "false";
            this.Bought.FillWeight = 45F;
            this.Bought.HeaderText = "Bought";
            this.Bought.Name = "Bought";
            this.Bought.TrueValue = "true";
            // 
            // PendingDelivering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelDeliveryBtn);
            this.Controls.Add(this.OrderDeliveredBtn);
            this.Controls.Add(this.OrdersGV);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PendingDelivering";
            this.Text = "PendingDelivering";
            this.Load += new System.EventHandler(this.PendingDelivering_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid OrdersGV;
        private Bunifu.Framework.UI.BunifuFlatButton CancelDeliveryBtn;
        private Bunifu.Framework.UI.BunifuFlatButton OrderDeliveredBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bought;
    }
}