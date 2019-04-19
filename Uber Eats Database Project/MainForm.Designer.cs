namespace Uber_Eats_Database_Project
{
    partial class MainForm
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
            this.CustomerMenuBtn = new MetroFramework.Controls.MetroTile();
            this.Cart = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.CustomerOrdersBtn = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerMenuBtn
            // 
            this.CustomerMenuBtn.ActiveControl = null;
            this.CustomerMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerMenuBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CustomerMenuBtn.Location = new System.Drawing.Point(64, 51);
            this.CustomerMenuBtn.Name = "CustomerMenuBtn";
            this.CustomerMenuBtn.Size = new System.Drawing.Size(173, 65);
            this.CustomerMenuBtn.TabIndex = 0;
            this.CustomerMenuBtn.Text = "Menus";
            this.CustomerMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerMenuBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CustomerMenuBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.CustomerMenuBtn.UseSelectable = true;
            // 
            // Cart
            // 
            this.Cart.ActiveControl = null;
            this.Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cart.Location = new System.Drawing.Point(64, 164);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(173, 65);
            this.Cart.TabIndex = 1;
            this.Cart.Text = "Cart";
            this.Cart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Cart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Cart.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(310, 51);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(173, 65);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Account";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // CustomerOrdersBtn
            // 
            this.CustomerOrdersBtn.ActiveControl = null;
            this.CustomerOrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerOrdersBtn.Location = new System.Drawing.Point(310, 164);
            this.CustomerOrdersBtn.Name = "CustomerOrdersBtn";
            this.CustomerOrdersBtn.Size = new System.Drawing.Size(173, 65);
            this.CustomerOrdersBtn.TabIndex = 2;
            this.CustomerOrdersBtn.Text = "Orders";
            this.CustomerOrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomerOrdersBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CustomerOrdersBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.CustomerOrdersBtn.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Uber_Eats_Database_Project.Properties.Resources.exit_delete_close_remove_door_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 347);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.CustomerOrdersBtn);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.CustomerMenuBtn);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile CustomerMenuBtn;
        private MetroFramework.Controls.MetroTile Cart;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile CustomerOrdersBtn;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}