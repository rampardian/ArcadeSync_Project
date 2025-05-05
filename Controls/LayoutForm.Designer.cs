namespace ArcadeSync_Project.Controls
{
    partial class LayoutForm
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
            Backbtn = new MaterialSkin.Controls.MaterialButton();
            label2 = new Label();
            LocMachNamtxtbx = new TextBox();
            label1 = new Label();
            LocMachIDtxtbx = new TextBox();
            updateLocbtn = new MaterialSkin.Controls.MaterialButton();
            Locationdgv = new DataGridView();
            Loccmbbx = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Locationdgv).BeginInit();
            SuspendLayout();
            // 
            // Backbtn
            // 
            Backbtn.AutoSize = false;
            Backbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Backbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Backbtn.Depth = 0;
            Backbtn.HighEmphasis = true;
            Backbtn.Icon = null;
            Backbtn.Location = new Point(613, 489);
            Backbtn.Margin = new Padding(4, 6, 4, 6);
            Backbtn.MouseState = MaterialSkin.MouseState.HOVER;
            Backbtn.Name = "Backbtn";
            Backbtn.NoAccentTextColor = Color.Empty;
            Backbtn.Size = new Size(150, 36);
            Backbtn.TabIndex = 60;
            Backbtn.Text = "Back to Graph";
            Backbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Backbtn.UseAccentColor = false;
            Backbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 462);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 55;
            label2.Text = "Machine Name:";
            // 
            // LocMachNamtxtbx
            // 
            LocMachNamtxtbx.Location = new Point(159, 459);
            LocMachNamtxtbx.Name = "LocMachNamtxtbx";
            LocMachNamtxtbx.Size = new Size(315, 27);
            LocMachNamtxtbx.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 422);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 53;
            label1.Text = "Machine ID:";
            // 
            // LocMachIDtxtbx
            // 
            LocMachIDtxtbx.Location = new Point(157, 422);
            LocMachIDtxtbx.Name = "LocMachIDtxtbx";
            LocMachIDtxtbx.Size = new Size(315, 27);
            LocMachIDtxtbx.TabIndex = 52;
            // 
            // updateLocbtn
            // 
            updateLocbtn.AutoSize = false;
            updateLocbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateLocbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateLocbtn.Depth = 0;
            updateLocbtn.HighEmphasis = true;
            updateLocbtn.Icon = null;
            updateLocbtn.Location = new Point(613, 429);
            updateLocbtn.Margin = new Padding(4, 6, 4, 6);
            updateLocbtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateLocbtn.Name = "updateLocbtn";
            updateLocbtn.NoAccentTextColor = Color.Empty;
            updateLocbtn.Size = new Size(150, 36);
            updateLocbtn.TabIndex = 51;
            updateLocbtn.Text = "Update Data";
            updateLocbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateLocbtn.UseAccentColor = false;
            updateLocbtn.UseVisualStyleBackColor = true;
            updateLocbtn.Click += updateLocbtn_Click;
            // 
            // Locationdgv
            // 
            Locationdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Locationdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Locationdgv.Location = new Point(28, 86);
            Locationdgv.Name = "Locationdgv";
            Locationdgv.RowHeadersWidth = 51;
            Locationdgv.Size = new Size(735, 288);
            Locationdgv.TabIndex = 48;
            Locationdgv.SelectionChanged += Locationdgv_SelectionChanged;
            // 
            // Loccmbbx
            // 
            Loccmbbx.FormattingEnabled = true;
            Loccmbbx.Items.AddRange(new object[] { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "Storage" });
            Loccmbbx.Location = new Point(159, 502);
            Loccmbbx.Name = "Loccmbbx";
            Loccmbbx.Size = new Size(315, 28);
            Loccmbbx.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 505);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 62;
            label3.Text = "Location:";
            // 
            // LayoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(label3);
            Controls.Add(Loccmbbx);
            Controls.Add(Backbtn);
            Controls.Add(label2);
            Controls.Add(LocMachNamtxtbx);
            Controls.Add(label1);
            Controls.Add(LocMachIDtxtbx);
            Controls.Add(updateLocbtn);
            Controls.Add(Locationdgv);
            Name = "LayoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Layout Form";
            Load += LayoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)Locationdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Backbtn;
        private Label label2;
        private TextBox LocMachNamtxtbx;
        private Label label1;
        private TextBox LocMachIDtxtbx;
        private MaterialSkin.Controls.MaterialButton updateLocbtn;
        private DataGridView Locationdgv;
        private ComboBox Loccmbbx;
        private Label label3;
    }
}