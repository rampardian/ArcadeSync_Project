namespace ArcadeSync_Project.Controls
{
    partial class CalendarLogReportForm
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
            LogReporttxtbx = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            LogEmployIDtxtbx = new MaterialSkin.Controls.MaterialTextBox();
            LogEmployNamtxtbx = new MaterialSkin.Controls.MaterialTextBox();
            updateRepbtn = new MaterialSkin.Controls.MaterialButton();
            addRepbtn = new MaterialSkin.Controls.MaterialButton();
            removeRepbtn = new MaterialSkin.Controls.MaterialButton();
            datelbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // LogReporttxtbx
            // 
            LogReporttxtbx.BackColor = Color.FromArgb(255, 255, 255);
            LogReporttxtbx.BorderStyle = BorderStyle.None;
            LogReporttxtbx.Depth = 0;
            LogReporttxtbx.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LogReporttxtbx.ForeColor = Color.FromArgb(222, 0, 0, 0);
            LogReporttxtbx.Location = new Point(40, 301);
            LogReporttxtbx.MouseState = MaterialSkin.MouseState.HOVER;
            LogReporttxtbx.Name = "LogReporttxtbx";
            LogReporttxtbx.Size = new Size(612, 228);
            LogReporttxtbx.TabIndex = 1;
            LogReporttxtbx.Text = "";
            // 
            // LogEmployIDtxtbx
            // 
            LogEmployIDtxtbx.AnimateReadOnly = false;
            LogEmployIDtxtbx.BorderStyle = BorderStyle.None;
            LogEmployIDtxtbx.Depth = 0;
            LogEmployIDtxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LogEmployIDtxtbx.LeadingIcon = null;
            LogEmployIDtxtbx.Location = new Point(180, 137);
            LogEmployIDtxtbx.MaxLength = 50;
            LogEmployIDtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            LogEmployIDtxtbx.Multiline = false;
            LogEmployIDtxtbx.Name = "LogEmployIDtxtbx";
            LogEmployIDtxtbx.Size = new Size(472, 50);
            LogEmployIDtxtbx.TabIndex = 7;
            LogEmployIDtxtbx.Text = "";
            LogEmployIDtxtbx.TrailingIcon = null;
            // 
            // LogEmployNamtxtbx
            // 
            LogEmployNamtxtbx.AnimateReadOnly = false;
            LogEmployNamtxtbx.BorderStyle = BorderStyle.None;
            LogEmployNamtxtbx.Depth = 0;
            LogEmployNamtxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LogEmployNamtxtbx.LeadingIcon = null;
            LogEmployNamtxtbx.Location = new Point(180, 193);
            LogEmployNamtxtbx.MaxLength = 50;
            LogEmployNamtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            LogEmployNamtxtbx.Multiline = false;
            LogEmployNamtxtbx.Name = "LogEmployNamtxtbx";
            LogEmployNamtxtbx.Size = new Size(472, 50);
            LogEmployNamtxtbx.TabIndex = 8;
            LogEmployNamtxtbx.Text = "";
            LogEmployNamtxtbx.TrailingIcon = null;
            // 
            // updateRepbtn
            // 
            updateRepbtn.AutoSize = false;
            updateRepbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateRepbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateRepbtn.Depth = 0;
            updateRepbtn.HighEmphasis = true;
            updateRepbtn.Icon = null;
            updateRepbtn.Location = new Point(263, 555);
            updateRepbtn.Margin = new Padding(4, 6, 4, 6);
            updateRepbtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateRepbtn.Name = "updateRepbtn";
            updateRepbtn.NoAccentTextColor = Color.Empty;
            updateRepbtn.Size = new Size(160, 36);
            updateRepbtn.TabIndex = 38;
            updateRepbtn.Text = "Update Log Report";
            updateRepbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateRepbtn.UseAccentColor = false;
            updateRepbtn.UseVisualStyleBackColor = true;
            updateRepbtn.Click += updateRepbtn_Click;
            // 
            // addRepbtn
            // 
            addRepbtn.AutoSize = false;
            addRepbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addRepbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addRepbtn.Depth = 0;
            addRepbtn.HighEmphasis = true;
            addRepbtn.Icon = null;
            addRepbtn.Location = new Point(95, 555);
            addRepbtn.Margin = new Padding(4, 6, 4, 6);
            addRepbtn.MouseState = MaterialSkin.MouseState.HOVER;
            addRepbtn.Name = "addRepbtn";
            addRepbtn.NoAccentTextColor = Color.Empty;
            addRepbtn.Size = new Size(160, 36);
            addRepbtn.TabIndex = 37;
            addRepbtn.Text = "Add Log Report";
            addRepbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addRepbtn.UseAccentColor = false;
            addRepbtn.UseVisualStyleBackColor = true;
            addRepbtn.Click += addRepbtn_Click;
            // 
            // removeRepbtn
            // 
            removeRepbtn.AutoSize = false;
            removeRepbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeRepbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeRepbtn.Depth = 0;
            removeRepbtn.HighEmphasis = true;
            removeRepbtn.Icon = null;
            removeRepbtn.Location = new Point(431, 555);
            removeRepbtn.Margin = new Padding(4, 6, 4, 6);
            removeRepbtn.MouseState = MaterialSkin.MouseState.HOVER;
            removeRepbtn.Name = "removeRepbtn";
            removeRepbtn.NoAccentTextColor = Color.Empty;
            removeRepbtn.Size = new Size(160, 36);
            removeRepbtn.TabIndex = 36;
            removeRepbtn.Text = "Remove Log Report";
            removeRepbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            removeRepbtn.UseAccentColor = false;
            removeRepbtn.UseVisualStyleBackColor = true;
            removeRepbtn.Click += removeRepbtn_Click;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datelbl.Location = new Point(40, 81);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(96, 38);
            datelbl.TabIndex = 43;
            datelbl.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 149);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 44;
            label1.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 204);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 45;
            label2.Text = "Employee Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 278);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 46;
            label3.Text = "Details:";
            // 
            // CalendarLogReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datelbl);
            Controls.Add(updateRepbtn);
            Controls.Add(addRepbtn);
            Controls.Add(removeRepbtn);
            Controls.Add(LogEmployNamtxtbx);
            Controls.Add(LogEmployIDtxtbx);
            Controls.Add(LogReporttxtbx);
            Name = "CalendarLogReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialMultiLineTextBox LogReporttxtbx;
        private MaterialSkin.Controls.MaterialTextBox LogEmployIDtxtbx;
        private MaterialSkin.Controls.MaterialTextBox LogEmployNamtxtbx;
        private MaterialSkin.Controls.MaterialButton updateRepbtn;
        private MaterialSkin.Controls.MaterialButton addRepbtn;
        private MaterialSkin.Controls.MaterialButton removeRepbtn;
        private Label datelbl;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}