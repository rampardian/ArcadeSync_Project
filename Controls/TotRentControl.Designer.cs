namespace ArcadeSync_Project.Controls
{
    partial class TotRentControl
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
            label4 = new Label();
            TotalRentalgv = new DataGridView();
            label3 = new Label();
            dataRangeRentcmbbx = new ComboBox();
            showDatabtn = new MaterialSkin.Controls.MaterialButton();
            RentIncomePlot = new ScottPlot.WinForms.FormsPlot();
            label1 = new Label();
            StartRentaldtp = new DateTimePicker();
            DaysRentedPlot = new ScottPlot.WinForms.FormsPlot();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)TotalRentalgv).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 334);
            label4.Name = "label4";
            label4.Size = new Size(301, 20);
            label4.TabIndex = 56;
            label4.Text = "Total Rental Income (based on Data Range):";
            // 
            // TotalRentalgv
            // 
            TotalRentalgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TotalRentalgv.Location = new Point(544, 357);
            TotalRentalgv.Name = "TotalRentalgv";
            TotalRentalgv.RowHeadersWidth = 51;
            TotalRentalgv.Size = new Size(463, 216);
            TotalRentalgv.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 590);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 53;
            label3.Text = "Data Range:";
            // 
            // dataRangeRentcmbbx
            // 
            dataRangeRentcmbbx.FormattingEnabled = true;
            dataRangeRentcmbbx.Items.AddRange(new object[] { "Weekly", "Montly", "Yearly" });
            dataRangeRentcmbbx.Location = new Point(286, 613);
            dataRangeRentcmbbx.Name = "dataRangeRentcmbbx";
            dataRangeRentcmbbx.Size = new Size(250, 28);
            dataRangeRentcmbbx.TabIndex = 52;
            // 
            // showDatabtn
            // 
            showDatabtn.AutoSize = false;
            showDatabtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showDatabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showDatabtn.Depth = 0;
            showDatabtn.HighEmphasis = true;
            showDatabtn.Icon = null;
            showDatabtn.Location = new Point(857, 608);
            showDatabtn.Margin = new Padding(4, 6, 4, 6);
            showDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            showDatabtn.Name = "showDatabtn";
            showDatabtn.NoAccentTextColor = Color.Empty;
            showDatabtn.Size = new Size(150, 36);
            showDatabtn.TabIndex = 50;
            showDatabtn.Text = "Show Data";
            showDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            showDatabtn.UseAccentColor = false;
            showDatabtn.UseVisualStyleBackColor = true;
            // 
            // RentIncomePlot
            // 
            RentIncomePlot.DisplayScale = 1.25F;
            RentIncomePlot.Location = new Point(30, 30);
            RentIncomePlot.Name = "RentIncomePlot";
            RentIncomePlot.Size = new Size(977, 274);
            RentIncomePlot.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 590);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 49;
            label1.Text = "Starting Date:";
            // 
            // StartRentaldtp
            // 
            StartRentaldtp.Location = new Point(30, 614);
            StartRentaldtp.Name = "StartRentaldtp";
            StartRentaldtp.Size = new Size(250, 27);
            StartRentaldtp.TabIndex = 48;
            // 
            // DaysRentedPlot
            // 
            DaysRentedPlot.DisplayScale = 1.25F;
            DaysRentedPlot.Location = new Point(30, 357);
            DaysRentedPlot.Name = "DaysRentedPlot";
            DaysRentedPlot.Size = new Size(503, 216);
            DaysRentedPlot.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 334);
            label2.Name = "label2";
            label2.Size = new Size(288, 20);
            label2.TabIndex = 58;
            label2.Text = "Total Number of Days Rented: (Bar Graph)";
            // 
            // TotRentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(DaysRentedPlot);
            Controls.Add(label4);
            Controls.Add(TotalRentalgv);
            Controls.Add(label3);
            Controls.Add(dataRangeRentcmbbx);
            Controls.Add(showDatabtn);
            Controls.Add(RentIncomePlot);
            Controls.Add(label1);
            Controls.Add(StartRentaldtp);
            Name = "TotRentControl";
            Size = new Size(1080, 665);
            ((System.ComponentModel.ISupportInitialize)TotalRentalgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView TotalRentalgv;
        private Label label3;
        private ComboBox dataRangeRentcmbbx;
        private MaterialSkin.Controls.MaterialButton showDatabtn;
        private ScottPlot.WinForms.FormsPlot RentIncomePlot;
        private Label label1;
        private DateTimePicker StartRentaldtp;
        private ScottPlot.WinForms.FormsPlot DaysRentedPlot;
        private Label label2;
    }
}
