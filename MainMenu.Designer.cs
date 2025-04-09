namespace ArcadeSync_Project
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            MMTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            EmployeeMana = new TabPage();
            EmployManaPanel = new Panel();
            ShiftSched = new TabPage();
            ShiftSchedPanel = new Panel();
            RentalSys = new TabPage();
            RentalPanel = new Panel();
            Logs = new TabPage();
            CalenderPanel = new Panel();
            Inventory = new TabPage();
            InventoryPanel = new Panel();
            Registry = new TabPage();
            RegistryPanel = new Panel();
            Layout = new TabPage();
            LayoutPanel = new Panel();
            Analytics = new TabPage();
            imageList1 = new ImageList(components);
            AnalyticsPanel = new Panel();
            MMTabControl1.SuspendLayout();
            EmployeeMana.SuspendLayout();
            ShiftSched.SuspendLayout();
            RentalSys.SuspendLayout();
            Logs.SuspendLayout();
            Inventory.SuspendLayout();
            Registry.SuspendLayout();
            Layout.SuspendLayout();
            Analytics.SuspendLayout();
            SuspendLayout();
            // 
            // MMTabControl1
            // 
            MMTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MMTabControl1.Controls.Add(EmployeeMana);
            MMTabControl1.Controls.Add(ShiftSched);
            MMTabControl1.Controls.Add(RentalSys);
            MMTabControl1.Controls.Add(Logs);
            MMTabControl1.Controls.Add(Inventory);
            MMTabControl1.Controls.Add(Registry);
            MMTabControl1.Controls.Add(Layout);
            MMTabControl1.Controls.Add(Analytics);
            MMTabControl1.Depth = 0;
            MMTabControl1.ImageList = imageList1;
            MMTabControl1.Location = new Point(3, 64);
            MMTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            MMTabControl1.Multiline = true;
            MMTabControl1.Name = "MMTabControl1";
            MMTabControl1.SelectedIndex = 0;
            MMTabControl1.Size = new Size(1094, 714);
            MMTabControl1.TabIndex = 0;
            MMTabControl1.SelectedIndexChanged += MMTabControl1_SelectedIndexChanged;
            // 
            // EmployeeMana
            // 
            EmployeeMana.Controls.Add(EmployManaPanel);
            EmployeeMana.ImageKey = "timekeeping.png";
            EmployeeMana.Location = new Point(4, 74);
            EmployeeMana.Name = "EmployeeMana";
            EmployeeMana.Padding = new Padding(3);
            EmployeeMana.Size = new Size(1086, 636);
            EmployeeMana.TabIndex = 1;
            EmployeeMana.Text = "Timekeeping System";
            EmployeeMana.UseVisualStyleBackColor = true;
            // 
            // EmployManaPanel
            // 
            EmployManaPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployManaPanel.Location = new Point(3, 3);
            EmployManaPanel.Name = "EmployManaPanel";
            EmployManaPanel.Size = new Size(1080, 630);
            EmployManaPanel.TabIndex = 0;
            // 
            // ShiftSched
            // 
            ShiftSched.Controls.Add(ShiftSchedPanel);
            ShiftSched.ImageKey = "shiftsched.png";
            ShiftSched.Location = new Point(4, 74);
            ShiftSched.Name = "ShiftSched";
            ShiftSched.Size = new Size(1086, 636);
            ShiftSched.TabIndex = 2;
            ShiftSched.Text = "Shift Schedule";
            ShiftSched.UseVisualStyleBackColor = true;
            // 
            // ShiftSchedPanel
            // 
            ShiftSchedPanel.Dock = DockStyle.Fill;
            ShiftSchedPanel.Location = new Point(0, 0);
            ShiftSchedPanel.Name = "ShiftSchedPanel";
            ShiftSchedPanel.Size = new Size(1086, 636);
            ShiftSchedPanel.TabIndex = 0;
            // 
            // RentalSys
            // 
            RentalSys.Controls.Add(RentalPanel);
            RentalSys.ImageKey = "rental.png";
            RentalSys.Location = new Point(4, 74);
            RentalSys.Name = "RentalSys";
            RentalSys.Padding = new Padding(3);
            RentalSys.Size = new Size(1086, 636);
            RentalSys.TabIndex = 0;
            RentalSys.Text = "Arcade Rental";
            RentalSys.UseVisualStyleBackColor = true;
            // 
            // RentalPanel
            // 
            RentalPanel.Dock = DockStyle.Fill;
            RentalPanel.Location = new Point(3, 3);
            RentalPanel.Name = "RentalPanel";
            RentalPanel.Size = new Size(1080, 630);
            RentalPanel.TabIndex = 0;
            // 
            // Logs
            // 
            Logs.Controls.Add(CalenderPanel);
            Logs.ImageKey = "logreport.png";
            Logs.Location = new Point(4, 74);
            Logs.Name = "Logs";
            Logs.Size = new Size(1086, 636);
            Logs.TabIndex = 3;
            Logs.Text = "Log Report Calendar";
            Logs.UseVisualStyleBackColor = true;
            // 
            // CalenderPanel
            // 
            CalenderPanel.Dock = DockStyle.Fill;
            CalenderPanel.Location = new Point(0, 0);
            CalenderPanel.Name = "CalenderPanel";
            CalenderPanel.Size = new Size(1086, 636);
            CalenderPanel.TabIndex = 0;
            // 
            // Inventory
            // 
            Inventory.Controls.Add(InventoryPanel);
            Inventory.ImageKey = "inventory.png";
            Inventory.Location = new Point(4, 74);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(1086, 636);
            Inventory.TabIndex = 4;
            Inventory.Text = "Arcade Inventory";
            Inventory.UseVisualStyleBackColor = true;
            // 
            // InventoryPanel
            // 
            InventoryPanel.Dock = DockStyle.Fill;
            InventoryPanel.Location = new Point(0, 0);
            InventoryPanel.Name = "InventoryPanel";
            InventoryPanel.Size = new Size(1086, 636);
            InventoryPanel.TabIndex = 0;
            // 
            // Registry
            // 
            Registry.Controls.Add(RegistryPanel);
            Registry.ImageKey = "registry.png";
            Registry.Location = new Point(4, 74);
            Registry.Name = "Registry";
            Registry.Size = new Size(1086, 636);
            Registry.TabIndex = 5;
            Registry.Text = "Registry";
            Registry.UseVisualStyleBackColor = true;
            // 
            // RegistryPanel
            // 
            RegistryPanel.Dock = DockStyle.Fill;
            RegistryPanel.Location = new Point(0, 0);
            RegistryPanel.Name = "RegistryPanel";
            RegistryPanel.Size = new Size(1086, 636);
            RegistryPanel.TabIndex = 0;
            // 
            // Layout
            // 
            Layout.Controls.Add(LayoutPanel);
            Layout.ImageKey = "layout.png";
            Layout.Location = new Point(4, 74);
            Layout.Name = "Layout";
            Layout.Size = new Size(1086, 636);
            Layout.TabIndex = 6;
            Layout.Text = "Arcade Layout";
            Layout.UseVisualStyleBackColor = true;
            // 
            // LayoutPanel
            // 
            LayoutPanel.Dock = DockStyle.Fill;
            LayoutPanel.Location = new Point(0, 0);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.Size = new Size(1086, 636);
            LayoutPanel.TabIndex = 0;
            // 
            // Analytics
            // 
            Analytics.Controls.Add(AnalyticsPanel);
            Analytics.ImageKey = "analytics.png";
            Analytics.Location = new Point(4, 74);
            Analytics.Name = "Analytics";
            Analytics.Padding = new Padding(3);
            Analytics.Size = new Size(1086, 636);
            Analytics.TabIndex = 7;
            Analytics.Text = "Analytics";
            Analytics.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "rental.png");
            imageList1.Images.SetKeyName(1, "timekeeping.png");
            imageList1.Images.SetKeyName(2, "shiftsched.png");
            imageList1.Images.SetKeyName(3, "logreport.png");
            imageList1.Images.SetKeyName(4, "inventory.png");
            imageList1.Images.SetKeyName(5, "registry.png");
            imageList1.Images.SetKeyName(6, "select.png");
            imageList1.Images.SetKeyName(7, "layout.png");
            imageList1.Images.SetKeyName(8, "analytics.png");
            // 
            // AnalyticsPanel
            // 
            AnalyticsPanel.Dock = DockStyle.Fill;
            AnalyticsPanel.Location = new Point(3, 3);
            AnalyticsPanel.Name = "AnalyticsPanel";
            AnalyticsPanel.Size = new Size(1080, 630);
            AnalyticsPanel.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 781);
            Controls.Add(MMTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = MMTabControl1;
            DrawerWidth = 250;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ArcadeSync Main Menu";
            MMTabControl1.ResumeLayout(false);
            EmployeeMana.ResumeLayout(false);
            ShiftSched.ResumeLayout(false);
            RentalSys.ResumeLayout(false);
            Logs.ResumeLayout(false);
            Inventory.ResumeLayout(false);
            Registry.ResumeLayout(false);
            Layout.ResumeLayout(false);
            Analytics.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MMTabControl1;
        private TabPage RentalSys;
        private TabPage EmployeeMana;
        private TabPage ShiftSched;
        private TabPage Logs;
        private TabPage Inventory;
        private TabPage Registry;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Panel EmployManaPanel;
        private Panel ShiftSchedPanel;
        private Panel RentalPanel;
        private Panel CalenderPanel;
        private Panel InventoryPanel;
        private Panel RegistryPanel;
        private TabPage Layout;
        private Panel LayoutPanel;
        private TabPage Analytics;
        private Panel AnalyticsPanel;
    }
}