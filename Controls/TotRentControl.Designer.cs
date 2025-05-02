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
            label2 = new Label();
            RentalPicBx = new PictureBox();
            label3 = new Label();
            dataRangeRentcmbbx = new ComboBox();
            label1 = new Label();
            StartRentaldtp = new DateTimePicker();
            RentalBarPicBx = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TotalRentalgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RentalPicBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RentalBarPicBx).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 350);
            label4.Name = "label4";
            label4.Size = new Size(301, 20);
            label4.TabIndex = 56;
            label4.Text = "Total Rental Income (based on Data Range):";
            // 
            // TotalRentalgv
            // 
            TotalRentalgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TotalRentalgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TotalRentalgv.Location = new Point(30, 373);
            TotalRentalgv.Name = "TotalRentalgv";
            TotalRentalgv.RowHeadersWidth = 51;
            TotalRentalgv.Size = new Size(463, 216);
            TotalRentalgv.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 350);
            label2.Name = "label2";
            label2.Size = new Size(288, 20);
            label2.TabIndex = 58;
            label2.Text = "Total Number of Days Rented: (Bar Graph)";
            // 
            // RentalPicBx
            // 
            RentalPicBx.Location = new Point(30, 30);
            RentalPicBx.Name = "RentalPicBx";
            RentalPicBx.Size = new Size(989, 305);
            RentalPicBx.TabIndex = 59;
            RentalPicBx.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 595);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 63;
            label3.Text = "Data Range:";
            // 
            // dataRangeRentcmbbx
            // 
            dataRangeRentcmbbx.FormattingEnabled = true;
            dataRangeRentcmbbx.Items.AddRange(new object[] { "Weekly", "Montly", "Yearly" });
            dataRangeRentcmbbx.Location = new Point(286, 618);
            dataRangeRentcmbbx.Name = "dataRangeRentcmbbx";
            dataRangeRentcmbbx.Size = new Size(207, 28);
            dataRangeRentcmbbx.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 595);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 61;
            label1.Text = "Starting Date:";
            // 
            // StartRentaldtp
            // 
            StartRentaldtp.Location = new Point(30, 619);
            StartRentaldtp.Name = "StartRentaldtp";
            StartRentaldtp.Size = new Size(250, 27);
            StartRentaldtp.TabIndex = 60;
            // 
            // RentalBarPicBx
            // 
            RentalBarPicBx.Location = new Point(499, 373);
            RentalBarPicBx.Name = "RentalBarPicBx";
            RentalBarPicBx.Size = new Size(508, 273);
            RentalBarPicBx.TabIndex = 64;
            RentalBarPicBx.TabStop = false;
            // 
            // TotRentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RentalBarPicBx);
            Controls.Add(label3);
            Controls.Add(dataRangeRentcmbbx);
            Controls.Add(label1);
            Controls.Add(StartRentaldtp);
            Controls.Add(RentalPicBx);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(TotalRentalgv);
            Name = "TotRentControl";
            Size = new Size(1080, 665);
            ((System.ComponentModel.ISupportInitialize)TotalRentalgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)RentalPicBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)RentalBarPicBx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView TotalRentalgv;
        private Label label2;
        private PictureBox RentalPicBx;
        private Label label3;
        private ComboBox dataRangeRentcmbbx;
        private Label label1;
        private DateTimePicker StartRentaldtp;
        private PictureBox RentalBarPicBx;
    }
}
