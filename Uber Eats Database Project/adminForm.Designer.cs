namespace Uber_Eats_Database_Project
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CusineTypeUpdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RestaurantRatingUpdate = new System.Windows.Forms.NumericUpDown();
            this.RestaurantsNamesUpdate = new MetroFramework.Controls.MetroComboBox();
            this.RestaurantLocationUpdate = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cusineAdd = new System.Windows.Forms.TextBox();
            this.addRes = new System.Windows.Forms.TextBox();
            this.addResBtn = new System.Windows.Forms.Button();
            this.resLoc = new System.Windows.Forms.TextBox();
            this.ratingRest = new System.Windows.Forms.NumericUpDown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantRatingUpdate)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingRest)).BeginInit();
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
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.CloseBtn);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(892, 35);
            this.header.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Admin Tools";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(854, 5);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(27, 28);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 27;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 20;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.22625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.77375F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 431);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.CusineTypeUpdate, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.RestaurantRatingUpdate, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.RestaurantsNamesUpdate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RestaurantLocationUpdate, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 219);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.93258F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.06742F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(440, 209);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // CusineTypeUpdate
            // 
            this.CusineTypeUpdate.AutoSize = true;
            this.CusineTypeUpdate.Location = new System.Drawing.Point(135, 142);
            this.CusineTypeUpdate.Margin = new System.Windows.Forms.Padding(135, 12, 3, 0);
            this.CusineTypeUpdate.Name = "CusineTypeUpdate";
            this.CusineTypeUpdate.Size = new System.Drawing.Size(0, 21);
            this.CusineTypeUpdate.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(165, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(165, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Rating";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestaurantRatingUpdate
            // 
            this.RestaurantRatingUpdate.Location = new System.Drawing.Point(170, 97);
            this.RestaurantRatingUpdate.Margin = new System.Windows.Forms.Padding(170, 8, 3, 3);
            this.RestaurantRatingUpdate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RestaurantRatingUpdate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RestaurantRatingUpdate.Name = "RestaurantRatingUpdate";
            this.RestaurantRatingUpdate.Size = new System.Drawing.Size(120, 27);
            this.RestaurantRatingUpdate.TabIndex = 2;
            this.RestaurantRatingUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RestaurantRatingUpdate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RestaurantsNamesUpdate
            // 
            this.RestaurantsNamesUpdate.FormattingEnabled = true;
            this.RestaurantsNamesUpdate.ItemHeight = 23;
            this.RestaurantsNamesUpdate.Location = new System.Drawing.Point(135, 12);
            this.RestaurantsNamesUpdate.Margin = new System.Windows.Forms.Padding(135, 12, 3, 3);
            this.RestaurantsNamesUpdate.Name = "RestaurantsNamesUpdate";
            this.RestaurantsNamesUpdate.Size = new System.Drawing.Size(184, 29);
            this.RestaurantsNamesUpdate.TabIndex = 3;
            this.RestaurantsNamesUpdate.UseSelectable = true;
            this.RestaurantsNamesUpdate.SelectedValueChanged += new System.EventHandler(this.RestaurantsNamesUpdate_SelectedValueChanged);
            // 
            // RestaurantLocationUpdate
            // 
            this.RestaurantLocationUpdate.AutoSize = true;
            this.RestaurantLocationUpdate.Location = new System.Drawing.Point(135, 60);
            this.RestaurantLocationUpdate.Margin = new System.Windows.Forms.Padding(135, 12, 3, 0);
            this.RestaurantLocationUpdate.Name = "RestaurantLocationUpdate";
            this.RestaurantLocationUpdate.Size = new System.Drawing.Size(0, 21);
            this.RestaurantLocationUpdate.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cusineAdd, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.addRes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addResBtn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.resLoc, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ratingRest, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.93258F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.06742F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 210);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cusineAdd
            // 
            this.cusineAdd.ForeColor = System.Drawing.Color.DarkGray;
            this.cusineAdd.Location = new System.Drawing.Point(135, 137);
            this.cusineAdd.Margin = new System.Windows.Forms.Padding(135, 6, 3, 3);
            this.cusineAdd.Name = "cusineAdd";
            this.cusineAdd.Size = new System.Drawing.Size(184, 27);
            this.cusineAdd.TabIndex = 1;
            this.cusineAdd.Text = "Cusine Type";
            this.cusineAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addRes
            // 
            this.addRes.ForeColor = System.Drawing.Color.DarkGray;
            this.addRes.Location = new System.Drawing.Point(135, 12);
            this.addRes.Margin = new System.Windows.Forms.Padding(135, 12, 3, 3);
            this.addRes.Name = "addRes";
            this.addRes.Size = new System.Drawing.Size(184, 27);
            this.addRes.TabIndex = 0;
            this.addRes.Text = "Restaurant Name";
            this.addRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addResBtn
            // 
            this.addResBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.addResBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addResBtn.Location = new System.Drawing.Point(165, 173);
            this.addResBtn.Margin = new System.Windows.Forms.Padding(165, 3, 3, 3);
            this.addResBtn.Name = "addResBtn";
            this.addResBtn.Size = new System.Drawing.Size(127, 31);
            this.addResBtn.TabIndex = 1;
            this.addResBtn.Text = "Add Restaurant";
            this.addResBtn.UseVisualStyleBackColor = false;
            this.addResBtn.Click += new System.EventHandler(this.addResBtn_Click);
            // 
            // resLoc
            // 
            this.resLoc.ForeColor = System.Drawing.Color.DarkGray;
            this.resLoc.Location = new System.Drawing.Point(135, 57);
            this.resLoc.Margin = new System.Windows.Forms.Padding(135, 8, 3, 3);
            this.resLoc.Name = "resLoc";
            this.resLoc.Size = new System.Drawing.Size(184, 27);
            this.resLoc.TabIndex = 0;
            this.resLoc.Text = "Restaurant Location";
            this.resLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ratingRest
            // 
            this.ratingRest.Location = new System.Drawing.Point(170, 100);
            this.ratingRest.Margin = new System.Windows.Forms.Padding(170, 10, 3, 3);
            this.ratingRest.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingRest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratingRest.Name = "ratingRest";
            this.ratingRest.Size = new System.Drawing.Size(120, 27);
            this.ratingRest.TabIndex = 2;
            this.ratingRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ratingRest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantRatingUpdate)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingRest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox addRes;
        private System.Windows.Forms.Button addResBtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox cusineAdd;
        private System.Windows.Forms.TextBox resLoc;
        private System.Windows.Forms.NumericUpDown ratingRest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label CusineTypeUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown RestaurantRatingUpdate;
        private MetroFramework.Controls.MetroComboBox RestaurantsNamesUpdate;
        private System.Windows.Forms.Label RestaurantLocationUpdate;
    }
}