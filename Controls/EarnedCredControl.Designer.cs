namespace ArcadeSync_Project.Controls
{
    partial class z
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            StartEarndtp = new DateTimePicker();
            showDatabtn = new MaterialSkin.Controls.MaterialButton();
            dataRangecmbbx = new ComboBox();
            label3 = new Label();
            TotalEarnedgv = new DataGridView();
            label4 = new Label();
            earnedCredPicBx = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TotalEarnedgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)earnedCredPicBx).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 455);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Starting Date:";
            // 
            // StartEarndtp
            // 
            StartEarndtp.Location = new Point(550, 479);
            StartEarndtp.Name = "StartEarndtp";
            StartEarndtp.Size = new Size(250, 27);
            StartEarndtp.TabIndex = 2;
            // 
            // showDatabtn
            // 
            showDatabtn.AutoSize = false;
            showDatabtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showDatabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showDatabtn.Depth = 0;
            showDatabtn.HighEmphasis = true;
            showDatabtn.Icon = null;
            showDatabtn.Location = new Point(869, 553);
            showDatabtn.Margin = new Padding(4, 6, 4, 6);
            showDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            showDatabtn.Name = "showDatabtn";
            showDatabtn.NoAccentTextColor = Color.Empty;
            showDatabtn.Size = new Size(150, 36);
            showDatabtn.TabIndex = 37;
            showDatabtn.Text = "Show Data";
            showDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            showDatabtn.UseAccentColor = false;
            showDatabtn.UseVisualStyleBackColor = true;
            showDatabtn.Click += showDatabtn_Click;
            // 
            // dataRangecmbbx
            // 
            dataRangecmbbx.FormattingEnabled = true;
            dataRangecmbbx.Items.AddRange(new object[] { "Weekly", "Montly", "Yearly" });
            dataRangecmbbx.Location = new Point(550, 558);
            dataRangecmbbx.Name = "dataRangecmbbx";
            dataRangecmbbx.Size = new Size(250, 28);
            dataRangecmbbx.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 535);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 43;
            label3.Text = "Data Range:";
            // 
            // TotalEarnedgv
            // 
            TotalEarnedgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TotalEarnedgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TotalEarnedgv.Location = new Point(30, 373);
            TotalEarnedgv.Name = "TotalEarnedgv";
            TotalEarnedgv.RowHeadersWidth = 51;
            TotalEarnedgv.Size = new Size(463, 216);
            TotalEarnedgv.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 350);
            label4.Name = "label4";
            label4.Size = new Size(302, 20);
            label4.TabIndex = 46;
            label4.Text = "Total Earned Credits (based on Data Range):";
            // 
            // earnedCredPicBx
            // 
            earnedCredPicBx.Location = new Point(30, 30);
            earnedCredPicBx.Name = "earnedCredPicBx";
            earnedCredPicBx.Size = new Size(989, 305);
            earnedCredPicBx.TabIndex = 47;
            earnedCredPicBx.TabStop = false;
            // 
            // EarnedCredControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(earnedCredPicBx);
            Controls.Add(label4);
            Controls.Add(TotalEarnedgv);
            Controls.Add(label3);
            Controls.Add(dataRangecmbbx);
            Controls.Add(showDatabtn);
            Controls.Add(label1);
            Controls.Add(StartEarndtp);
            Name = "EarnedCredControl";
            Size = new Size(1080, 665);
            ((System.ComponentModel.ISupportInitialize)TotalEarnedgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)earnedCredPicBx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker StartEarndtp;
        private MaterialSkin.Controls.MaterialButton showDatabtn;
        private ComboBox dataRangecmbbx;
        private Label label3;
        private DataGridView TotalEarnedgv;
        private Label label4;
        private PictureBox earnedCredPicBx;
    }
}
