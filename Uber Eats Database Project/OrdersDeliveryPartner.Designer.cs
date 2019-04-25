namespace Uber_Eats_Database_Project
{
    partial class OrdersDeliveryPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersDeliveryPartner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.orders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.food = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1308, 33);
            this.header.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageActive = null;
            this.exit.Location = new System.Drawing.Point(1270, -1);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 36);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 18;
            this.exit.TabStop = false;
            this.exit.Zoom = 20;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // orders
            // 
            this.orders.AllowUserToAddRows = false;
            this.orders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orders.BackgroundColor = System.Drawing.Color.White;
            this.orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.orders.DoubleBuffered = true;
            this.orders.EnableHeadersVisualStyles = false;
            this.orders.HeaderBgColor = System.Drawing.Color.Black;
            this.orders.HeaderForeColor = System.Drawing.Color.White;
            this.orders.Location = new System.Drawing.Point(0, 33);
            this.orders.MultiSelect = false;
            this.orders.Name = "orders";
            this.orders.ReadOnly = true;
            this.orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orders.RowTemplate.Height = 24;
            this.orders.Size = new System.Drawing.Size(1308, 375);
            this.orders.TabIndex = 1;
            this.orders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_CellContentDoubleClick);
            // 
            // food
            // 
            this.food.AllowUserToAddRows = false;
            this.food.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.food.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.food.BackgroundColor = System.Drawing.Color.White;
            this.food.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.food.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.food.Dock = System.Windows.Forms.DockStyle.Fill;
            this.food.DoubleBuffered = true;
            this.food.EnableHeadersVisualStyles = false;
            this.food.HeaderBgColor = System.Drawing.Color.Black;
            this.food.HeaderForeColor = System.Drawing.Color.White;
            this.food.Location = new System.Drawing.Point(0, 408);
            this.food.MultiSelect = false;
            this.food.Name = "food";
            this.food.ReadOnly = true;
            this.food.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.food.RowTemplate.Height = 24;
            this.food.Size = new System.Drawing.Size(1308, 218);
            this.food.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // OrdersDeliveryPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1308, 626);
            this.Controls.Add(this.food);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersDeliveryPartner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersDeliveryPartner";
            this.Load += new System.EventHandler(this.OrdersDeliveryPartner_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid food;
        private Bunifu.Framework.UI.BunifuCustomDataGrid orders;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}