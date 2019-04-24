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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogoutBtn = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.CartBtn = new System.Windows.Forms.Button();
            this.MenusBtn = new System.Windows.Forms.Button();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DAccountBtn = new System.Windows.Forms.Button();
            this.DeliveredOrdersBtn = new System.Windows.Forms.Button();
            this.PendingOrdersBtn = new System.Windows.Forms.Button();
            this.UsernameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.testBtn = new System.Windows.Forms.Button();
            this.CurrentOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
||||||| 18d1669... adding bunifu framework
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CustomerMenuBtn = new MetroFramework.Controls.MetroTile();
            this.Cart = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.CustomerOrdersBtn = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
||||||| 18d1669... adding bunifu framework
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
=======
>>>>>>> parent of 18d1669... adding bunifu framework
||||||| 18d1669... adding bunifu framework
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
=======
>>>>>>> parent of 18d1669... adding bunifu framework
            this.CustomerMenuBtn = new MetroFramework.Controls.MetroTile();
            this.Cart = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.CustomerOrdersBtn = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> parent of 18d1669... adding bunifu framework
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // LogoutBtn
            // 
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.Location = new System.Drawing.Point(236, 262);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(77, 73);
            this.LogoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.TabStop = false;
            this.LogoutBtn.Click += new System.EventHandler(this.Logout_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.CloseBtn);
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(541, 29);
            this.header.TabIndex = 17;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(504, 2);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 27);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 26;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 20;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
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
            // 
            // AccountBtn
            // 
            this.AccountBtn.BackColor = System.Drawing.Color.Black;
            this.AccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AccountBtn.Location = new System.Drawing.Point(340, 73);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(124, 55);
            this.AccountBtn.TabIndex = 18;
            this.AccountBtn.Text = "Account";
            this.AccountBtn.UseVisualStyleBackColor = false;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            this.AccountBtn.MouseEnter += new System.EventHandler(this.AccountBtn_MouseEnter);
            this.AccountBtn.MouseLeave += new System.EventHandler(this.AccountBtn_MouseLeave);
            // 
            // CartBtn
            // 
            this.CartBtn.BackColor = System.Drawing.Color.Black;
            this.CartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CartBtn.Location = new System.Drawing.Point(82, 185);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(124, 55);
            this.CartBtn.TabIndex = 19;
            this.CartBtn.Text = "View Cart";
            this.CartBtn.UseVisualStyleBackColor = false;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            this.CartBtn.MouseEnter += new System.EventHandler(this.CartBtn_MouseEnter);
            this.CartBtn.MouseLeave += new System.EventHandler(this.CartBtn_MouseLeave);
            // 
            // MenusBtn
            // 
            this.MenusBtn.BackColor = System.Drawing.Color.Black;
            this.MenusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenusBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenusBtn.Location = new System.Drawing.Point(82, 73);
            this.MenusBtn.Name = "MenusBtn";
            this.MenusBtn.Size = new System.Drawing.Size(124, 55);
            this.MenusBtn.TabIndex = 20;
            this.MenusBtn.Text = "Menus";
            this.MenusBtn.UseVisualStyleBackColor = false;
            this.MenusBtn.Click += new System.EventHandler(this.MenusBtn_Click);
            this.MenusBtn.MouseEnter += new System.EventHandler(this.MenusBtn_MouseEnter);
            this.MenusBtn.MouseLeave += new System.EventHandler(this.MenusBtn_MouseLeave);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.BackColor = System.Drawing.Color.Black;
            this.OrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersBtn.Location = new System.Drawing.Point(340, 185);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(124, 55);
            this.OrdersBtn.TabIndex = 21;
            this.OrdersBtn.Text = "My Orders";
            this.OrdersBtn.UseVisualStyleBackColor = false;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            this.OrdersBtn.MouseEnter += new System.EventHandler(this.OrdersBtn_MouseEnter);
            this.OrdersBtn.MouseLeave += new System.EventHandler(this.OrdersBtn_MouseLeave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // DAccountBtn
            // 
            this.DAccountBtn.BackColor = System.Drawing.Color.Black;
            this.DAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DAccountBtn.Enabled = false;
            this.DAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DAccountBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAccountBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DAccountBtn.Location = new System.Drawing.Point(310, 73);
            this.DAccountBtn.Name = "DAccountBtn";
            this.DAccountBtn.Size = new System.Drawing.Size(179, 55);
            this.DAccountBtn.TabIndex = 22;
            this.DAccountBtn.Text = "Account";
            this.DAccountBtn.UseVisualStyleBackColor = false;
            this.DAccountBtn.Visible = false;
            this.DAccountBtn.Click += new System.EventHandler(this.DAccountBtn_Click);
            this.DAccountBtn.MouseEnter += new System.EventHandler(this.DAccountBtn_MouseEnter);
            this.DAccountBtn.MouseLeave += new System.EventHandler(this.DAccountBtn_MouseLeave);
            // 
            // DeliveredOrdersBtn
            // 
            this.DeliveredOrdersBtn.BackColor = System.Drawing.Color.Black;
            this.DeliveredOrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeliveredOrdersBtn.Enabled = false;
            this.DeliveredOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveredOrdersBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveredOrdersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliveredOrdersBtn.Location = new System.Drawing.Point(310, 185);
            this.DeliveredOrdersBtn.Name = "DeliveredOrdersBtn";
            this.DeliveredOrdersBtn.Size = new System.Drawing.Size(179, 55);
            this.DeliveredOrdersBtn.TabIndex = 24;
            this.DeliveredOrdersBtn.Text = "Delivered Orders";
            this.DeliveredOrdersBtn.UseVisualStyleBackColor = false;
            this.DeliveredOrdersBtn.Visible = false;
            this.DeliveredOrdersBtn.Click += new System.EventHandler(this.DeliveredOrdersBtn_Click);
            this.DeliveredOrdersBtn.MouseEnter += new System.EventHandler(this.DeliveredOrdersBtn_MouseEnter);
            this.DeliveredOrdersBtn.MouseLeave += new System.EventHandler(this.DeliveredOrdersBtn_MouseLeave);
            // 
            // PendingOrdersBtn
            // 
            this.PendingOrdersBtn.BackColor = System.Drawing.Color.Black;
            this.PendingOrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PendingOrdersBtn.Enabled = false;
            this.PendingOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PendingOrdersBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingOrdersBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PendingOrdersBtn.Location = new System.Drawing.Point(53, 186);
            this.PendingOrdersBtn.Name = "PendingOrdersBtn";
            this.PendingOrdersBtn.Size = new System.Drawing.Size(177, 55);
            this.PendingOrdersBtn.TabIndex = 23;
            this.PendingOrdersBtn.Text = "Pending Orders";
            this.PendingOrdersBtn.UseVisualStyleBackColor = false;
            this.PendingOrdersBtn.Visible = false;
            this.PendingOrdersBtn.Click += new System.EventHandler(this.PendingOrdersBtn_Click);
            this.PendingOrdersBtn.MouseEnter += new System.EventHandler(this.PendingOrdersBtn_MouseEnter);
            this.PendingOrdersBtn.MouseLeave += new System.EventHandler(this.PendingOrdersBtn_MouseLeave);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(79, 45);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 25;
            this.UsernameLabel.Text = "Welcome, ";
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.Color.Black;
            this.testBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testBtn.Location = new System.Drawing.Point(365, 262);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(124, 55);
            this.testBtn.TabIndex = 26;
            this.testBtn.Text = "Test Report";
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // CurrentOrderBtn
            // 
            this.CurrentOrderBtn.BackColor = System.Drawing.Color.Black;
            this.CurrentOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentOrderBtn.Enabled = false;
            this.CurrentOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentOrderBtn.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentOrderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurrentOrderBtn.Location = new System.Drawing.Point(53, 73);
            this.CurrentOrderBtn.Name = "CurrentOrderBtn";
            this.CurrentOrderBtn.Size = new System.Drawing.Size(177, 55);
            this.CurrentOrderBtn.TabIndex = 27;
            this.CurrentOrderBtn.Text = "Current Order";
            this.CurrentOrderBtn.UseVisualStyleBackColor = false;
            this.CurrentOrderBtn.Visible = false;
            this.CurrentOrderBtn.Click += new System.EventHandler(this.CurrentOrderBtn_Click);
            this.CurrentOrderBtn.MouseEnter += new System.EventHandler(this.CurrentOrderBtn_MouseEnter);
            this.CurrentOrderBtn.MouseLeave += new System.EventHandler(this.CurrentOrderBtn_MouseLeave);
||||||| 18d1669... adding bunifu framework
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
<<<<<<< HEAD
=======
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
<<<<<<< HEAD
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
>>>>>>> parent of 18d1669... adding bunifu framework
||||||| 18d1669... adding bunifu framework
=======
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
>>>>>>> parent of 18d1669... adding bunifu framework
||||||| 18d1669... adding bunifu framework
=======
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
>>>>>>> parent of 18d1669... adding bunifu framework
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 347);
            this.ControlBox = false;
            this.Controls.Add(this.CurrentOrderBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DeliveredOrdersBtn);
            this.Controls.Add(this.PendingOrdersBtn);
            this.Controls.Add(this.DAccountBtn);
            this.Controls.Add(this.OrdersBtn);
            this.Controls.Add(this.MenusBtn);
            this.Controls.Add(this.CartBtn);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.LogoutBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).EndInit();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LogoutBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton exit;
        private System.Windows.Forms.Button OrdersBtn;
        private System.Windows.Forms.Button MenusBtn;
        private System.Windows.Forms.Button CartBtn;
        private System.Windows.Forms.Button AccountBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button DeliveredOrdersBtn;
        private System.Windows.Forms.Button PendingOrdersBtn;
        private System.Windows.Forms.Button DAccountBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel UsernameLabel;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button CurrentOrderBtn;
    }
}