namespace ArcadeSync_Project.Controls
{
    partial class AnalyticsControl
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateRangecmbbx = new ComboBox();
            showDatabtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(30, 30);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1004, 548);
            formsPlot1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 617);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 593);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Starting Date:";
            // 
            // dateRangecmbbx
            // 
            dateRangecmbbx.FormattingEnabled = true;
            dateRangecmbbx.Items.AddRange(new object[] { "Weekly", "Montly", "Yearly" });
            dateRangecmbbx.Location = new Point(286, 616);
            dateRangecmbbx.Name = "dateRangecmbbx";
            dateRangecmbbx.Size = new Size(151, 28);
            dateRangecmbbx.TabIndex = 4;
            // 
            // showDatabtn
            // 
            showDatabtn.AutoSize = false;
            showDatabtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showDatabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showDatabtn.Depth = 0;
            showDatabtn.HighEmphasis = true;
            showDatabtn.Icon = null;
            showDatabtn.Location = new Point(884, 608);
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
            // AnalyticsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(showDatabtn);
            Controls.Add(dateRangecmbbx);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(formsPlot1);
            Name = "AnalyticsControl";
            Size = new Size(1080, 665);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox dateRangecmbbx;
        private MaterialSkin.Controls.MaterialButton showDatabtn;
    }
}
