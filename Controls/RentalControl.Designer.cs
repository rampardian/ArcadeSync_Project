namespace ArcadeSync_Project.Controls
{
    partial class RentalControl
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
            startRentdtp = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            EmployNamRenttxtbx = new TextBox();
            EmpIDRenttxtbx = new TextBox();
            rentaldgv = new DataGridView();
            endRentdtp = new DateTimePicker();
            label4 = new Label();
            RenterPhonetxtbx = new TextBox();
            label5 = new Label();
            RentVenuetxtbx = new TextBox();
            RenterNamtxtbx = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label8 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)rentaldgv).BeginInit();
            SuspendLayout();
            // 
            // startRentdtp
            // 
            startRentdtp.Location = new Point(588, 520);
            startRentdtp.Name = "startRentdtp";
            startRentdtp.Size = new Size(413, 27);
            startRentdtp.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 522);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 17;
            label2.Text = "Employee Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 489);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 16;
            label1.Text = "Employee ID:";
            // 
            // EmployNamRenttxtbx
            // 
            EmployNamRenttxtbx.Location = new Point(152, 519);
            EmployNamRenttxtbx.Name = "EmployNamRenttxtbx";
            EmployNamRenttxtbx.Size = new Size(246, 27);
            EmployNamRenttxtbx.TabIndex = 15;
            // 
            // EmpIDRenttxtbx
            // 
            EmpIDRenttxtbx.Location = new Point(152, 486);
            EmpIDRenttxtbx.Name = "EmpIDRenttxtbx";
            EmpIDRenttxtbx.Size = new Size(246, 27);
            EmpIDRenttxtbx.TabIndex = 14;
            // 
            // rentaldgv
            // 
            rentaldgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentaldgv.Location = new Point(30, 30);
            rentaldgv.Name = "rentaldgv";
            rentaldgv.RowHeadersWidth = 51;
            rentaldgv.Size = new Size(971, 434);
            rentaldgv.TabIndex = 13;
            // 
            // endRentdtp
            // 
            endRentdtp.Location = new Point(588, 557);
            endRentdtp.Name = "endRentdtp";
            endRentdtp.Size = new Size(413, 27);
            endRentdtp.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 587);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 25;
            label4.Text = "Phone Number:";
            // 
            // RenterPhonetxtbx
            // 
            RenterPhonetxtbx.Location = new Point(152, 585);
            RenterPhonetxtbx.Name = "RenterPhonetxtbx";
            RenterPhonetxtbx.Size = new Size(246, 27);
            RenterPhonetxtbx.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 620);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 27;
            label5.Text = "Rent Venue:";
            // 
            // RentVenuetxtbx
            // 
            RentVenuetxtbx.Location = new Point(152, 618);
            RentVenuetxtbx.Name = "RentVenuetxtbx";
            RentVenuetxtbx.Size = new Size(246, 27);
            RentVenuetxtbx.TabIndex = 26;
            // 
            // RenterNamtxtbx
            // 
            RenterNamtxtbx.Location = new Point(152, 552);
            RenterNamtxtbx.Name = "RenterNamtxtbx";
            RenterNamtxtbx.Size = new Size(246, 27);
            RenterNamtxtbx.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 554);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 19;
            label6.Text = "Renter Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 522);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 28;
            label3.Text = "Rent Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(447, 559);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 29;
            label7.Text = "Return Date:";
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(658, 608);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(343, 45);
            materialButton1.TabIndex = 30;
            materialButton1.Text = "Payment and Transaction";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(447, 489);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 32;
            label8.Text = "Rental Event Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(588, 487);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 27);
            textBox1.TabIndex = 31;
            // 
            // RentalControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(materialButton1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(RentVenuetxtbx);
            Controls.Add(label4);
            Controls.Add(RenterPhonetxtbx);
            Controls.Add(endRentdtp);
            Controls.Add(startRentdtp);
            Controls.Add(label6);
            Controls.Add(RenterNamtxtbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmployNamRenttxtbx);
            Controls.Add(EmpIDRenttxtbx);
            Controls.Add(rentaldgv);
            Name = "RentalControl";
            Size = new Size(1080, 665);
            Load += RentalControl_Load;
            ((System.ComponentModel.ISupportInitialize)rentaldgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker startRentdtp;
        private Label label2;
        private Label label1;
        private TextBox EmployNamRenttxtbx;
        private TextBox EmpIDRenttxtbx;
        private DataGridView rentaldgv;
        private DateTimePicker endRentdtp;
        private Label label4;
        private TextBox RenterPhonetxtbx;
        private Label label5;
        private TextBox RentVenuetxtbx;
        private TextBox RenterNamtxtbx;
        private Label label6;
        private Label label3;
        private Label label7;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label8;
        private TextBox textBox1;
    }
}
