namespace ArcadeSync_Project.Controls
{
    partial class EarnedCredControl
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
            dateTimePicker1 = new DateTimePicker();
            dateRangecmbbx = new ComboBox();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            showDatabtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 590);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Starting Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 614);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateRangecmbbx
            // 
            dateRangecmbbx.FormattingEnabled = true;
            dateRangecmbbx.Items.AddRange(new object[] { "Weekly", "Montly", "Yearly" });
            dateRangecmbbx.Location = new Point(286, 613);
            dateRangecmbbx.Name = "dateRangecmbbx";
            dateRangecmbbx.Size = new Size(151, 28);
            dateRangecmbbx.TabIndex = 4;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(30, 30);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1004, 548);
            formsPlot1.TabIndex = 0;
            // 
            // showDatabtn
            // 
            showDatabtn.AutoSize = false;
            showDatabtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showDatabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showDatabtn.Depth = 0;
            showDatabtn.HighEmphasis = true;
            showDatabtn.Icon = null;
            showDatabtn.Location = new Point(884, 605);
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
            Controls.Add(formsPlot1);
            Controls.Add(dateRangecmbbx);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "AnalyticsControl";
            Size = new Size(1080, 665);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox dateRangecmbbx;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private MaterialSkin.Controls.MaterialButton showDatabtn;
    }
}
