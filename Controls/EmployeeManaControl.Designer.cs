namespace ArcadeSync_Project
{
    partial class EmployeeManaControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManaControl));
            attendancedgv = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            datelbl = new Label();
            timelbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            empIDtxtbx = new MaterialSkin.Controls.MaterialTextBox();
            FullNametxtbx = new MaterialSkin.Controls.MaterialTextBox();
            passwordChecktxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            timeInbtn = new MaterialSkin.Controls.MaterialButton();
            timeOutbtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)attendancedgv).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // attendancedgv
            // 
            attendancedgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendancedgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendancedgv.Location = new Point(30, 30);
            attendancedgv.Name = "attendancedgv";
            attendancedgv.RowHeadersWidth = 51;
            attendancedgv.Size = new Size(972, 377);
            attendancedgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 449);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 516);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Full Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(datelbl);
            panel1.Controls.Add(timelbl);
            panel1.Location = new Point(538, 432);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 87);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(385, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // datelbl
            // 
            datelbl.AutoSize = true;
            datelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            datelbl.Location = new Point(22, 48);
            datelbl.Name = "datelbl";
            datelbl.Size = new Size(64, 31);
            datelbl.TabIndex = 1;
            datelbl.Text = "Date";
            // 
            // timelbl
            // 
            timelbl.AutoSize = true;
            timelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            timelbl.Location = new Point(22, 12);
            timelbl.Name = "timelbl";
            timelbl.Size = new Size(67, 31);
            timelbl.TabIndex = 0;
            timelbl.Text = "Time";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // empIDtxtbx
            // 
            empIDtxtbx.AnimateReadOnly = false;
            empIDtxtbx.BorderStyle = BorderStyle.None;
            empIDtxtbx.Depth = 0;
            empIDtxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            empIDtxtbx.LeadingIcon = null;
            empIDtxtbx.Location = new Point(133, 432);
            empIDtxtbx.MaxLength = 50;
            empIDtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            empIDtxtbx.Multiline = false;
            empIDtxtbx.Name = "empIDtxtbx";
            empIDtxtbx.Size = new Size(366, 50);
            empIDtxtbx.TabIndex = 9;
            empIDtxtbx.Text = "";
            empIDtxtbx.TrailingIcon = null;
            // 
            // FullNametxtbx
            // 
            FullNametxtbx.AnimateReadOnly = false;
            FullNametxtbx.BorderStyle = BorderStyle.None;
            FullNametxtbx.Depth = 0;
            FullNametxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            FullNametxtbx.LeadingIcon = null;
            FullNametxtbx.Location = new Point(133, 497);
            FullNametxtbx.MaxLength = 50;
            FullNametxtbx.MouseState = MaterialSkin.MouseState.OUT;
            FullNametxtbx.Multiline = false;
            FullNametxtbx.Name = "FullNametxtbx";
            FullNametxtbx.Size = new Size(366, 50);
            FullNametxtbx.TabIndex = 10;
            FullNametxtbx.Text = "";
            FullNametxtbx.TrailingIcon = null;
            // 
            // passwordChecktxtbx
            // 
            passwordChecktxtbx.AnimateReadOnly = false;
            passwordChecktxtbx.BorderStyle = BorderStyle.None;
            passwordChecktxtbx.Depth = 0;
            passwordChecktxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordChecktxtbx.LeadingIcon = null;
            passwordChecktxtbx.Location = new Point(133, 567);
            passwordChecktxtbx.MaxLength = 50;
            passwordChecktxtbx.MouseState = MaterialSkin.MouseState.OUT;
            passwordChecktxtbx.Multiline = false;
            passwordChecktxtbx.Name = "passwordChecktxtbx";
            passwordChecktxtbx.Size = new Size(366, 50);
            passwordChecktxtbx.TabIndex = 12;
            passwordChecktxtbx.Text = "";
            passwordChecktxtbx.TrailingIcon = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 586);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 11;
            label3.Text = "Password:";
            // 
            // timeInbtn
            // 
            timeInbtn.AutoSize = false;
            timeInbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timeInbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            timeInbtn.Depth = 0;
            timeInbtn.HighEmphasis = true;
            timeInbtn.Icon = null;
            timeInbtn.Location = new Point(538, 578);
            timeInbtn.Margin = new Padding(4, 6, 4, 6);
            timeInbtn.MouseState = MaterialSkin.MouseState.HOVER;
            timeInbtn.Name = "timeInbtn";
            timeInbtn.NoAccentTextColor = Color.Empty;
            timeInbtn.Size = new Size(209, 36);
            timeInbtn.TabIndex = 13;
            timeInbtn.Text = "Time In";
            timeInbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            timeInbtn.UseAccentColor = false;
            timeInbtn.UseVisualStyleBackColor = true;
            timeInbtn.Click += timeInbtn_Click;
            // 
            // timeOutbtn
            // 
            timeOutbtn.AutoSize = false;
            timeOutbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timeOutbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            timeOutbtn.Depth = 0;
            timeOutbtn.HighEmphasis = true;
            timeOutbtn.Icon = null;
            timeOutbtn.Location = new Point(793, 578);
            timeOutbtn.Margin = new Padding(4, 6, 4, 6);
            timeOutbtn.MouseState = MaterialSkin.MouseState.HOVER;
            timeOutbtn.Name = "timeOutbtn";
            timeOutbtn.NoAccentTextColor = Color.Empty;
            timeOutbtn.Size = new Size(209, 36);
            timeOutbtn.TabIndex = 14;
            timeOutbtn.Text = "Time Out";
            timeOutbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            timeOutbtn.UseAccentColor = false;
            timeOutbtn.UseVisualStyleBackColor = true;
            timeOutbtn.Click += timeOutbtn_Click;
            // 
            // EmployeeManaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeOutbtn);
            Controls.Add(timeInbtn);
            Controls.Add(passwordChecktxtbx);
            Controls.Add(label3);
            Controls.Add(FullNametxtbx);
            Controls.Add(empIDtxtbx);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(attendancedgv);
            Name = "EmployeeManaControl";
            Size = new Size(1080, 665);
            Load += EmployeeManaControl_Load;
            ((System.ComponentModel.ISupportInitialize)attendancedgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView attendancedgv;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label timelbl;
        private Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox empIDtxtbx;
        private MaterialSkin.Controls.MaterialTextBox FullNametxtbx;
        private MaterialSkin.Controls.MaterialTextBox passwordChecktxtbx;
        private Label label3;
        private MaterialSkin.Controls.MaterialButton timeInbtn;
        private MaterialSkin.Controls.MaterialButton timeOutbtn;
    }
}
