namespace ArcadeSync_Project.Controls
{
    partial class MainSchedForm
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
            label3 = new Label();
            endScheddtp = new DateTimePicker();
            startScheddtp = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            updateSchedbtn = new MaterialSkin.Controls.MaterialButton();
            recordSchedbtn = new MaterialSkin.Controls.MaterialButton();
            label2 = new Label();
            label1 = new Label();
            SchedDetailstxtbx = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            schedMachIDtxtbx = new TextBox();
            schedMachNamtxtbx = new TextBox();
            Typecmbbx = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            statuscmbxb = new ComboBox();
            label8 = new Label();
            inventorydgv = new DataGridView();
            machImagepic = new PictureBox();
            mainIDtxtbx = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)inventorydgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)machImagepic).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(555, 502);
            label3.Name = "label3";
            label3.Size = new Size(262, 31);
            label3.TabIndex = 53;
            label3.Text = "Maintenance Schedule:";
            // 
            // endScheddtp
            // 
            endScheddtp.Location = new Point(655, 569);
            endScheddtp.Name = "endScheddtp";
            endScheddtp.Size = new Size(243, 27);
            endScheddtp.TabIndex = 52;
            // 
            // startScheddtp
            // 
            startScheddtp.Location = new Point(655, 536);
            startScheddtp.Name = "startScheddtp";
            startScheddtp.Size = new Size(243, 27);
            startScheddtp.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(555, 574);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 50;
            label5.Text = "Ending Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(555, 541);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 49;
            label4.Text = "Starting Date:";
            // 
            // updateSchedbtn
            // 
            updateSchedbtn.AutoSize = false;
            updateSchedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateSchedbtn.BackColor = Color.Transparent;
            updateSchedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateSchedbtn.Depth = 0;
            updateSchedbtn.ForeColor = Color.White;
            updateSchedbtn.HighEmphasis = true;
            updateSchedbtn.Icon = null;
            updateSchedbtn.Location = new Point(585, 843);
            updateSchedbtn.Margin = new Padding(4, 6, 4, 6);
            updateSchedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateSchedbtn.Name = "updateSchedbtn";
            updateSchedbtn.NoAccentTextColor = Color.Empty;
            updateSchedbtn.Size = new Size(138, 36);
            updateSchedbtn.TabIndex = 47;
            updateSchedbtn.Text = "Update Schedule";
            updateSchedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateSchedbtn.UseAccentColor = false;
            updateSchedbtn.UseVisualStyleBackColor = false;
            updateSchedbtn.Click += updateSchedbtn_Click;
            // 
            // recordSchedbtn
            // 
            recordSchedbtn.AutoSize = false;
            recordSchedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            recordSchedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            recordSchedbtn.Depth = 0;
            recordSchedbtn.HighEmphasis = true;
            recordSchedbtn.Icon = null;
            recordSchedbtn.Location = new Point(293, 843);
            recordSchedbtn.Margin = new Padding(4, 6, 4, 6);
            recordSchedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            recordSchedbtn.Name = "recordSchedbtn";
            recordSchedbtn.NoAccentTextColor = Color.Empty;
            recordSchedbtn.Size = new Size(138, 36);
            recordSchedbtn.TabIndex = 46;
            recordSchedbtn.Text = "Record Schedule";
            recordSchedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            recordSchedbtn.UseAccentColor = false;
            recordSchedbtn.UseVisualStyleBackColor = true;
            recordSchedbtn.Click += recordSchedbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 502);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 43;
            label2.Text = "Machine Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 469);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 42;
            label1.Text = "Machine ID:";
            // 
            // SchedDetailstxtbx
            // 
            SchedDetailstxtbx.BackColor = Color.FromArgb(255, 255, 255);
            SchedDetailstxtbx.BorderStyle = BorderStyle.None;
            SchedDetailstxtbx.Depth = 0;
            SchedDetailstxtbx.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            SchedDetailstxtbx.ForeColor = Color.FromArgb(222, 0, 0, 0);
            SchedDetailstxtbx.Location = new Point(20, 638);
            SchedDetailstxtbx.MouseState = MaterialSkin.MouseState.HOVER;
            SchedDetailstxtbx.Name = "SchedDetailstxtbx";
            SchedDetailstxtbx.Size = new Size(947, 181);
            SchedDetailstxtbx.TabIndex = 54;
            SchedDetailstxtbx.Text = "";
            // 
            // schedMachIDtxtbx
            // 
            schedMachIDtxtbx.Location = new Point(153, 466);
            schedMachIDtxtbx.Name = "schedMachIDtxtbx";
            schedMachIDtxtbx.Size = new Size(340, 27);
            schedMachIDtxtbx.TabIndex = 55;
            // 
            // schedMachNamtxtbx
            // 
            schedMachNamtxtbx.Location = new Point(153, 499);
            schedMachNamtxtbx.Name = "schedMachNamtxtbx";
            schedMachNamtxtbx.Size = new Size(340, 27);
            schedMachNamtxtbx.TabIndex = 56;
            // 
            // Typecmbbx
            // 
            Typecmbbx.FormattingEnabled = true;
            Typecmbbx.Items.AddRange(new object[] { "Routine CleanUp", "Hardware Repair", "Replacement", "Software Update" });
            Typecmbbx.Location = new Point(153, 532);
            Typecmbbx.Name = "Typecmbbx";
            Typecmbbx.Size = new Size(340, 28);
            Typecmbbx.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 535);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 58;
            label6.Text = "Maintenance Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 569);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 60;
            label7.Text = "Status:";
            // 
            // statuscmbxb
            // 
            statuscmbxb.FormattingEnabled = true;
            statuscmbxb.Items.AddRange(new object[] { "Completed", "Pending", "In Progress", "Cancelled", "Postponed" });
            statuscmbxb.Location = new Point(153, 566);
            statuscmbxb.Name = "statuscmbxb";
            statuscmbxb.Size = new Size(340, 28);
            statuscmbxb.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(439, 615);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 61;
            label8.Text = "Maintenance Details:";
            // 
            // inventorydgv
            // 
            inventorydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventorydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventorydgv.Location = new Point(22, 89);
            inventorydgv.Name = "inventorydgv";
            inventorydgv.RowHeadersWidth = 51;
            inventorydgv.Size = new Size(701, 371);
            inventorydgv.TabIndex = 62;
            inventorydgv.SelectionChanged += inventorydgv_SelectionChanged;
            // 
            // machImagepic
            // 
            machImagepic.Location = new Point(729, 89);
            machImagepic.Name = "machImagepic";
            machImagepic.Size = new Size(238, 371);
            machImagepic.TabIndex = 63;
            machImagepic.TabStop = false;
            // 
            // mainIDtxtbx
            // 
            mainIDtxtbx.Location = new Point(688, 466);
            mainIDtxtbx.Name = "mainIDtxtbx";
            mainIDtxtbx.Size = new Size(279, 27);
            mainIDtxtbx.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Location = new Point(555, 469);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 64;
            label9.Text = "Maintenance ID:";
            // 
            // MainSchedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 890);
            Controls.Add(mainIDtxtbx);
            Controls.Add(label9);
            Controls.Add(machImagepic);
            Controls.Add(inventorydgv);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(statuscmbxb);
            Controls.Add(label6);
            Controls.Add(Typecmbbx);
            Controls.Add(schedMachNamtxtbx);
            Controls.Add(schedMachIDtxtbx);
            Controls.Add(SchedDetailstxtbx);
            Controls.Add(label3);
            Controls.Add(endScheddtp);
            Controls.Add(startScheddtp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(updateSchedbtn);
            Controls.Add(recordSchedbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainSchedForm";
            Text = "Maintenance Schedule Form";
            Load += MainSchedForm_Load;
            ((System.ComponentModel.ISupportInitialize)inventorydgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)machImagepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DateTimePicker endScheddtp;
        private DateTimePicker startScheddtp;
        private Label label5;
        private Label label4;
        private MaterialSkin.Controls.MaterialButton updateSchedbtn;
        private MaterialSkin.Controls.MaterialButton recordSchedbtn;
        private MaterialSkin.Controls.MaterialTextBox SchedMachNamtxtbx;
        private MaterialSkin.Controls.MaterialTextBox SchedMachIDtxtbx;
        private Label label2;
        private Label label1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox SchedDetailstxtbx;
        private TextBox schedMachIDtxtbx;
        private TextBox schedMachNamtxtbx;
        private ComboBox Typecmbbx;
        private Label label6;
        private Label label7;
        private ComboBox statuscmbxb;
        private Label label8;
        private DataGridView inventorydgv;
        private PictureBox machImagepic;
        private TextBox mainIDtxtbx;
        private Label label9;
    }
}