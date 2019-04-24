namespace Uber_Eats_Database_Project
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pendingOrdersGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.foodGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).BeginInit();
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
            this.header.Controls.Add(this.close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1117, 36);
            this.header.TabIndex = 17;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1084, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 33);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 18;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pendingOrdersGrid
            // 
            this.pendingOrdersGrid.AllowUserToAddRows = false;
            this.pendingOrdersGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pendingOrdersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.pendingOrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pendingOrdersGrid.BackgroundColor = System.Drawing.Color.White;
            this.pendingOrdersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pendingOrdersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pendingOrdersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.pendingOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingOrdersGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pendingOrdersGrid.DoubleBuffered = true;
            this.pendingOrdersGrid.EnableHeadersVisualStyles = false;
            this.pendingOrdersGrid.HeaderBgColor = System.Drawing.Color.Black;
            this.pendingOrdersGrid.HeaderForeColor = System.Drawing.Color.White;
            this.pendingOrdersGrid.Location = new System.Drawing.Point(0, 36);
            this.pendingOrdersGrid.Name = "pendingOrdersGrid";
            this.pendingOrdersGrid.ReadOnly = true;
            this.pendingOrdersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.pendingOrdersGrid.RowTemplate.Height = 24;
            this.pendingOrdersGrid.Size = new System.Drawing.Size(1117, 431);
            this.pendingOrdersGrid.TabIndex = 18;
            this.pendingOrdersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pendingOrdersGrid_CellContentClick);
            // 
            // foodGrid
            // 
            this.foodGrid.AllowUserToAddRows = false;
            this.foodGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.foodGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.foodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodGrid.BackgroundColor = System.Drawing.Color.White;
            this.foodGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.foodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodGrid.DoubleBuffered = true;
            this.foodGrid.EnableHeadersVisualStyles = false;
            this.foodGrid.HeaderBgColor = System.Drawing.Color.Black;
            this.foodGrid.HeaderForeColor = System.Drawing.Color.White;
            this.foodGrid.Location = new System.Drawing.Point(0, 467);
            this.foodGrid.Name = "foodGrid";
            this.foodGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.foodGrid.RowTemplate.Height = 24;
            this.foodGrid.Size = new System.Drawing.Size(1117, 199);
            this.foodGrid.TabIndex = 19;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1117, 666);
            this.Controls.Add(this.foodGrid);
            this.Controls.Add(this.pendingOrdersGrid);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid pendingOrdersGrid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid foodGrid;
    }
}