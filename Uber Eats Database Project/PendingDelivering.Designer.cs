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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingDelivering));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OrdersGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.foodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bought = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CancelDeliveryBtn = new System.Windows.Forms.Button();
            this.OrderDeliveredBtn = new System.Windows.Forms.Button();
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
            this.OrdersGV.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.OrdersGV.HeaderBgColor = System.Drawing.Color.MintCream;
            this.OrdersGV.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.OrdersGV.Location = new System.Drawing.Point(0, 29);
            this.OrdersGV.MinimumSize = new System.Drawing.Size(800, 0);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersGV.RowHeadersVisible = false;
            this.OrdersGV.Size = new System.Drawing.Size(800, 357);
            this.OrdersGV.TabIndex = 29;
            this.OrdersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGV_CellContentClick);
            // 
            // foodname
            // 
            this.foodname.FillWeight = 75F;
            this.foodname.HeaderText = "Food";
            this.foodname.Name = "foodname";
            this.foodname.ReadOnly = true;
            this.foodname.ToolTipText = "Food Name";
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
            this.NoItems.ToolTipText = "Number of meals Delivered";
            // 
            // Bought
            // 
            this.Bought.FalseValue = "false";
            this.Bought.FillWeight = 45F;
            this.Bought.HeaderText = "Bought";
            this.Bought.Name = "Bought";
            this.Bought.ToolTipText = "Check only if you bought total number of meals required";
            this.Bought.TrueValue = "true";
            // 
            // CancelDeliveryBtn
            // 
            this.CancelDeliveryBtn.BackColor = System.Drawing.Color.Black;
            this.CancelDeliveryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelDeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDeliveryBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDeliveryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelDeliveryBtn.Image = global::Uber_Eats_Database_Project.Properties.Resources.cancel__1_;
            this.CancelDeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelDeliveryBtn.Location = new System.Drawing.Point(400, 383);
            this.CancelDeliveryBtn.Name = "CancelDeliveryBtn";
            this.CancelDeliveryBtn.Size = new System.Drawing.Size(400, 67);
            this.CancelDeliveryBtn.TabIndex = 33;
            this.CancelDeliveryBtn.Text = "       Cancel Delivrey     ";
            this.CancelDeliveryBtn.UseCompatibleTextRendering = true;
            this.CancelDeliveryBtn.UseVisualStyleBackColor = false;
            this.CancelDeliveryBtn.Click += new System.EventHandler(this.CancelDeliveryBtn_Click);
            this.CancelDeliveryBtn.MouseEnter += new System.EventHandler(this.CancelDeliveryBtn_MouseEnter);
            this.CancelDeliveryBtn.MouseLeave += new System.EventHandler(this.CancelDeliveryBtn_MouseLeave);
            // 
            // OrderDeliveredBtn
            // 
            this.OrderDeliveredBtn.BackColor = System.Drawing.Color.Black;
            this.OrderDeliveredBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderDeliveredBtn.Enabled = false;
            this.OrderDeliveredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderDeliveredBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDeliveredBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderDeliveredBtn.Image = global::Uber_Eats_Database_Project.Properties.Resources.check;
            this.OrderDeliveredBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderDeliveredBtn.Location = new System.Drawing.Point(0, 383);
            this.OrderDeliveredBtn.Name = "OrderDeliveredBtn";
            this.OrderDeliveredBtn.Size = new System.Drawing.Size(394, 67);
            this.OrderDeliveredBtn.TabIndex = 32;
            this.OrderDeliveredBtn.Text = "        Order Delivered";
            this.OrderDeliveredBtn.UseCompatibleTextRendering = true;
            this.OrderDeliveredBtn.UseVisualStyleBackColor = false;
            this.OrderDeliveredBtn.Click += new System.EventHandler(this.OrderDeliveredBtn_Click);
            this.OrderDeliveredBtn.MouseEnter += new System.EventHandler(this.OrderDeliveredBtn_MouseEnter);
            this.OrderDeliveredBtn.MouseLeave += new System.EventHandler(this.OrderDeliveredBtn_MouseLeave);
            // 
            // PendingDelivering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelDeliveryBtn);
            this.Controls.Add(this.OrderDeliveredBtn);
            this.Controls.Add(this.OrdersGV);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PendingDelivering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button OrderDeliveredBtn;
        private System.Windows.Forms.Button CancelDeliveryBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bought;
    }
}