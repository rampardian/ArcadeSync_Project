namespace ArcadeSync_Project.Controls
{
    partial class RentTransaction
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
            amounttxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            label2 = new Label();
            rentChangetxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            arcadePicpanel = new Panel();
            ArcNamelbl = new Label();
            payMethodtxtbx = new MaterialSkin.Controls.MaterialComboBox();
            rentNotestxtbx = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            label4 = new Label();
            label5 = new Label();
            rentalCosttxtbx = new MaterialSkin.Controls.MaterialTextBox();
            recordTransactbtn = new MaterialSkin.Controls.MaterialButton();
            cancelTransactbtn = new MaterialSkin.Controls.MaterialButton();
            label6 = new Label();
            SuspendLayout();
            // 
            // amounttxtbx
            // 
            amounttxtbx.AnimateReadOnly = false;
            amounttxtbx.BorderStyle = BorderStyle.None;
            amounttxtbx.Depth = 0;
            amounttxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            amounttxtbx.LeadingIcon = null;
            amounttxtbx.Location = new Point(173, 212);
            amounttxtbx.MaxLength = 50;
            amounttxtbx.MouseState = MaterialSkin.MouseState.OUT;
            amounttxtbx.Multiline = false;
            amounttxtbx.Name = "amounttxtbx";
            amounttxtbx.Size = new Size(327, 50);
            amounttxtbx.TabIndex = 0;
            amounttxtbx.Text = "";
            amounttxtbx.TrailingIcon = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 225);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Amount Paid";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 281);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Change Due";
            // 
            // rentChangetxtbx
            // 
            rentChangetxtbx.AnimateReadOnly = false;
            rentChangetxtbx.BorderStyle = BorderStyle.None;
            rentChangetxtbx.Depth = 0;
            rentChangetxtbx.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            rentChangetxtbx.LeadingIcon = null;
            rentChangetxtbx.Location = new Point(173, 268);
            rentChangetxtbx.MaxLength = 50;
            rentChangetxtbx.MouseState = MaterialSkin.MouseState.OUT;
            rentChangetxtbx.Multiline = false;
            rentChangetxtbx.Name = "rentChangetxtbx";
            rentChangetxtbx.Size = new Size(327, 50);
            rentChangetxtbx.TabIndex = 3;
            rentChangetxtbx.Text = "";
            rentChangetxtbx.TrailingIcon = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 339);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 6;
            label3.Text = "Payment Method";
            // 
            // arcadePicpanel
            // 
            arcadePicpanel.Location = new Point(521, 115);
            arcadePicpanel.Name = "arcadePicpanel";
            arcadePicpanel.Size = new Size(250, 384);
            arcadePicpanel.TabIndex = 7;
            // 
            // ArcNamelbl
            // 
            ArcNamelbl.AutoSize = true;
            ArcNamelbl.Location = new Point(596, 82);
            ArcNamelbl.Name = "ArcNamelbl";
            ArcNamelbl.Size = new Size(96, 20);
            ArcNamelbl.TabIndex = 8;
            ArcNamelbl.Text = "ArcadeName";
            // 
            // payMethodtxtbx
            // 
            payMethodtxtbx.AutoResize = false;
            payMethodtxtbx.BackColor = Color.FromArgb(255, 255, 255);
            payMethodtxtbx.Depth = 0;
            payMethodtxtbx.DrawMode = DrawMode.OwnerDrawVariable;
            payMethodtxtbx.DropDownHeight = 174;
            payMethodtxtbx.DropDownStyle = ComboBoxStyle.DropDownList;
            payMethodtxtbx.DropDownWidth = 121;
            payMethodtxtbx.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            payMethodtxtbx.ForeColor = Color.FromArgb(222, 0, 0, 0);
            payMethodtxtbx.FormattingEnabled = true;
            payMethodtxtbx.IntegralHeight = false;
            payMethodtxtbx.ItemHeight = 43;
            payMethodtxtbx.Items.AddRange(new object[] { "Cash", "Gcash", "Card", "Bank Transfer" });
            payMethodtxtbx.Location = new Point(173, 324);
            payMethodtxtbx.MaxDropDownItems = 4;
            payMethodtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            payMethodtxtbx.Name = "payMethodtxtbx";
            payMethodtxtbx.Size = new Size(327, 49);
            payMethodtxtbx.StartIndex = 0;
            payMethodtxtbx.TabIndex = 9;
            // 
            // rentNotestxtbx
            // 
            rentNotestxtbx.BackColor = Color.FromArgb(255, 255, 255);
            rentNotestxtbx.BorderStyle = BorderStyle.None;
            rentNotestxtbx.Depth = 0;
            rentNotestxtbx.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            rentNotestxtbx.ForeColor = Color.FromArgb(222, 0, 0, 0);
            rentNotestxtbx.Location = new Point(173, 379);
            rentNotestxtbx.MouseState = MaterialSkin.MouseState.HOVER;
            rentNotestxtbx.Name = "rentNotestxtbx";
            rentNotestxtbx.Size = new Size(327, 120);
            rentNotestxtbx.TabIndex = 10;
            rentNotestxtbx.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 420);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 11;
            label4.Text = "Additional Notes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 169);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 13;
            label5.Text = "Total Rental Cost:";
            // 
            // rentalCosttxtbx
            // 
            rentalCosttxtbx.AnimateReadOnly = false;
            rentalCosttxtbx.BorderStyle = BorderStyle.None;
            rentalCosttxtbx.Depth = 0;
            rentalCosttxtbx.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            rentalCosttxtbx.LeadingIcon = null;
            rentalCosttxtbx.Location = new Point(173, 156);
            rentalCosttxtbx.MaxLength = 50;
            rentalCosttxtbx.MouseState = MaterialSkin.MouseState.OUT;
            rentalCosttxtbx.Multiline = false;
            rentalCosttxtbx.Name = "rentalCosttxtbx";
            rentalCosttxtbx.Size = new Size(327, 50);
            rentalCosttxtbx.TabIndex = 12;
            rentalCosttxtbx.Text = "";
            rentalCosttxtbx.TrailingIcon = null;
            // 
            // recordTransactbtn
            // 
            recordTransactbtn.AutoSize = false;
            recordTransactbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            recordTransactbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            recordTransactbtn.Depth = 0;
            recordTransactbtn.HighEmphasis = true;
            recordTransactbtn.Icon = null;
            recordTransactbtn.Location = new Point(458, 537);
            recordTransactbtn.Margin = new Padding(4, 6, 4, 6);
            recordTransactbtn.MouseState = MaterialSkin.MouseState.HOVER;
            recordTransactbtn.Name = "recordTransactbtn";
            recordTransactbtn.NoAccentTextColor = Color.Empty;
            recordTransactbtn.Size = new Size(313, 45);
            recordTransactbtn.TabIndex = 31;
            recordTransactbtn.Text = "Print and Record Transaction";
            recordTransactbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            recordTransactbtn.UseAccentColor = false;
            recordTransactbtn.UseVisualStyleBackColor = true;
            // 
            // cancelTransactbtn
            // 
            cancelTransactbtn.AutoSize = false;
            cancelTransactbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelTransactbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelTransactbtn.Depth = 0;
            cancelTransactbtn.HighEmphasis = true;
            cancelTransactbtn.Icon = null;
            cancelTransactbtn.Location = new Point(24, 537);
            cancelTransactbtn.Margin = new Padding(4, 6, 4, 6);
            cancelTransactbtn.MouseState = MaterialSkin.MouseState.HOVER;
            cancelTransactbtn.Name = "cancelTransactbtn";
            cancelTransactbtn.NoAccentTextColor = Color.Empty;
            cancelTransactbtn.Size = new Size(313, 45);
            cancelTransactbtn.TabIndex = 32;
            cancelTransactbtn.Text = "Cancel Transaction";
            cancelTransactbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelTransactbtn.UseAccentColor = false;
            cancelTransactbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 82);
            label6.Name = "label6";
            label6.Size = new Size(462, 46);
            label6.TabIndex = 33;
            label6.Text = "Enter rental payment below";
            // 
            // RentTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 606);
            Controls.Add(label6);
            Controls.Add(cancelTransactbtn);
            Controls.Add(recordTransactbtn);
            Controls.Add(label5);
            Controls.Add(rentalCosttxtbx);
            Controls.Add(label4);
            Controls.Add(rentNotestxtbx);
            Controls.Add(payMethodtxtbx);
            Controls.Add(ArcNamelbl);
            Controls.Add(arcadePicpanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rentChangetxtbx);
            Controls.Add(label1);
            Controls.Add(amounttxtbx);
            Name = "RentTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent Transaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox amounttxtbx;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox rentChangetxtbx;
        private Label label3;
        private Panel arcadePicpanel;
        private Label ArcNamelbl;
        private MaterialSkin.Controls.MaterialComboBox payMethodtxtbx;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rentNotestxtbx;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox rentalCosttxtbx;
        private MaterialSkin.Controls.MaterialButton recordTransactbtn;
        private MaterialSkin.Controls.MaterialButton cancelTransactbtn;
        private Label label6;
    }
}