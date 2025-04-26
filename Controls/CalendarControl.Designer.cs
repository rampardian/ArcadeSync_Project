namespace ArcadeSync_Project.Controls
{
    partial class CalendarControl
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
            daycontainer = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            prevMonthbtn = new MaterialSkin.Controls.MaterialButton();
            nextMonthbtn = new MaterialSkin.Controls.MaterialButton();
            monthYearlabel = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(30, 93);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(971, 569);
            daycontainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 70);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 4;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 70);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 70);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Wednesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 70);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 6;
            label4.Text = "Tuesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(752, 70);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 9;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(607, 70);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 8;
            label6.Text = "Thursday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(876, 70);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 10;
            label7.Text = "Saturday";
            // 
            // prevMonthbtn
            // 
            prevMonthbtn.AutoSize = false;
            prevMonthbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            prevMonthbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            prevMonthbtn.Depth = 0;
            prevMonthbtn.HighEmphasis = true;
            prevMonthbtn.Icon = null;
            prevMonthbtn.Location = new Point(717, 21);
            prevMonthbtn.Margin = new Padding(4, 6, 4, 6);
            prevMonthbtn.MouseState = MaterialSkin.MouseState.HOVER;
            prevMonthbtn.Name = "prevMonthbtn";
            prevMonthbtn.NoAccentTextColor = Color.Empty;
            prevMonthbtn.Size = new Size(138, 36);
            prevMonthbtn.TabIndex = 21;
            prevMonthbtn.Text = "Previous Month";
            prevMonthbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prevMonthbtn.UseAccentColor = false;
            prevMonthbtn.UseVisualStyleBackColor = true;
            prevMonthbtn.Click += prevMonthbtn_Click;
            // 
            // nextMonthbtn
            // 
            nextMonthbtn.AutoSize = false;
            nextMonthbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextMonthbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextMonthbtn.Depth = 0;
            nextMonthbtn.HighEmphasis = true;
            nextMonthbtn.Icon = null;
            nextMonthbtn.Location = new Point(863, 21);
            nextMonthbtn.Margin = new Padding(4, 6, 4, 6);
            nextMonthbtn.MouseState = MaterialSkin.MouseState.HOVER;
            nextMonthbtn.Name = "nextMonthbtn";
            nextMonthbtn.NoAccentTextColor = Color.Empty;
            nextMonthbtn.Size = new Size(138, 36);
            nextMonthbtn.TabIndex = 20;
            nextMonthbtn.Text = "Next Month";
            nextMonthbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextMonthbtn.UseAccentColor = false;
            nextMonthbtn.UseVisualStyleBackColor = true;
            nextMonthbtn.Click += nextMonthbtn_Click;
            // 
            // monthYearlabel
            // 
            monthYearlabel.AutoSize = true;
            monthYearlabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthYearlabel.Location = new Point(408, 11);
            monthYearlabel.Name = "monthYearlabel";
            monthYearlabel.Size = new Size(205, 46);
            monthYearlabel.TabIndex = 22;
            monthYearlabel.Text = "Month Year";
            // 
            // CalendarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(monthYearlabel);
            Controls.Add(prevMonthbtn);
            Controls.Add(nextMonthbtn);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(daycontainer);
            Name = "CalendarControl";
            Size = new Size(1080, 665);
            Load += CalendarControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaterialSkin.Controls.MaterialButton prevMonthbtn;
        private MaterialSkin.Controls.MaterialButton nextMonthbtn;
        private Label monthYearlabel;
    }
}
