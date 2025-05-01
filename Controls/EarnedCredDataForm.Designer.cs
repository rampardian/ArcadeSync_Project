namespace ArcadeSync_Project.Controls
{
    partial class EarnedCredDataForm
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
            DataAnadgv = new DataGridView();
            updateDatabtn = new MaterialSkin.Controls.MaterialButton();
            addDatabtn = new MaterialSkin.Controls.MaterialButton();
            deleteDatabtn = new MaterialSkin.Controls.MaterialButton();
            DataMachIDtxtbx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DataMachNamtxtbx = new TextBox();
            label3 = new Label();
            creditstxtbx = new TextBox();
            DateAnadtp = new DateTimePicker();
            label4 = new Label();
            backtoGraphbtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)DataAnadgv).BeginInit();
            SuspendLayout();
            // 
            // DataAnadgv
            // 
            DataAnadgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataAnadgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataAnadgv.Location = new Point(28, 86);
            DataAnadgv.Name = "DataAnadgv";
            DataAnadgv.RowHeadersWidth = 51;
            DataAnadgv.Size = new Size(735, 288);
            DataAnadgv.TabIndex = 0;
            // 
            // updateDatabtn
            // 
            updateDatabtn.AutoSize = false;
            updateDatabtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateDatabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateDatabtn.Depth = 0;
            updateDatabtn.HighEmphasis = true;
            updateDatabtn.Icon = null;
            updateDatabtn.Location = new Point(603, 439);
            updateDatabtn.Margin = new Padding(4, 6, 4, 6);
            updateDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateDatabtn.Name = "updateDatabtn";
            updateDatabtn.NoAccentTextColor = Color.Empty;
            updateDatabtn.Size = new Size(150, 36);
            updateDatabtn.TabIndex = 38;
            updateDatabtn.Text = "Update Data";
            updateDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateDatabtn.UseAccentColor = false;
            updateDatabtn.UseVisualStyleBackColor = true;
            updateDatabtn.Click += updateDatabtn_Click;
            // 
            // addDatabtn
            // 
            addDatabtn.AutoSize = false;
            addDatabtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addDatabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addDatabtn.Depth = 0;
            addDatabtn.HighEmphasis = true;
            addDatabtn.Icon = null;
            addDatabtn.Location = new Point(603, 391);
            addDatabtn.Margin = new Padding(4, 6, 4, 6);
            addDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            addDatabtn.Name = "addDatabtn";
            addDatabtn.NoAccentTextColor = Color.Empty;
            addDatabtn.Size = new Size(150, 36);
            addDatabtn.TabIndex = 37;
            addDatabtn.Text = "Add Data";
            addDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addDatabtn.UseAccentColor = false;
            addDatabtn.UseVisualStyleBackColor = true;
            addDatabtn.Click += addDatabtn_Click;
            // 
            // deleteDatabtn
            // 
            deleteDatabtn.AutoSize = false;
            deleteDatabtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteDatabtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteDatabtn.Depth = 0;
            deleteDatabtn.HighEmphasis = true;
            deleteDatabtn.Icon = null;
            deleteDatabtn.Location = new Point(603, 487);
            deleteDatabtn.Margin = new Padding(4, 6, 4, 6);
            deleteDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteDatabtn.Name = "deleteDatabtn";
            deleteDatabtn.NoAccentTextColor = Color.Empty;
            deleteDatabtn.Size = new Size(150, 36);
            deleteDatabtn.TabIndex = 36;
            deleteDatabtn.Text = "Delete Data";
            deleteDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteDatabtn.UseAccentColor = false;
            deleteDatabtn.UseVisualStyleBackColor = true;
            deleteDatabtn.Click += deleteDatabtn_Click;
            // 
            // DataMachIDtxtbx
            // 
            DataMachIDtxtbx.Location = new Point(157, 439);
            DataMachIDtxtbx.Name = "DataMachIDtxtbx";
            DataMachIDtxtbx.Size = new Size(315, 27);
            DataMachIDtxtbx.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 439);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 40;
            label1.Text = "Machine ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 479);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 42;
            label2.Text = "Machine Name:";
            // 
            // DataMachNamtxtbx
            // 
            DataMachNamtxtbx.Location = new Point(159, 476);
            DataMachNamtxtbx.Name = "DataMachNamtxtbx";
            DataMachNamtxtbx.Size = new Size(315, 27);
            DataMachNamtxtbx.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 523);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 44;
            label3.Text = "Earned Credits";
            // 
            // creditstxtbx
            // 
            creditstxtbx.Location = new Point(159, 520);
            creditstxtbx.Name = "creditstxtbx";
            creditstxtbx.Size = new Size(315, 27);
            creditstxtbx.TabIndex = 43;
            // 
            // DateAnadtp
            // 
            DateAnadtp.Location = new Point(159, 394);
            DateAnadtp.Name = "DateAnadtp";
            DateAnadtp.Size = new Size(313, 27);
            DateAnadtp.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 399);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 46;
            label4.Text = "Operation Date:";
            // 
            // backtoGraphbtn
            // 
            backtoGraphbtn.AutoSize = false;
            backtoGraphbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backtoGraphbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            backtoGraphbtn.Depth = 0;
            backtoGraphbtn.HighEmphasis = true;
            backtoGraphbtn.Icon = null;
            backtoGraphbtn.Location = new Point(603, 535);
            backtoGraphbtn.Margin = new Padding(4, 6, 4, 6);
            backtoGraphbtn.MouseState = MaterialSkin.MouseState.HOVER;
            backtoGraphbtn.Name = "backtoGraphbtn";
            backtoGraphbtn.NoAccentTextColor = Color.Empty;
            backtoGraphbtn.Size = new Size(150, 36);
            backtoGraphbtn.TabIndex = 47;
            backtoGraphbtn.Text = "Back to Graph";
            backtoGraphbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            backtoGraphbtn.UseAccentColor = false;
            backtoGraphbtn.UseVisualStyleBackColor = true;
            backtoGraphbtn.Click += backtoGraphbtn_Click;
            // 
            // EarnedCredDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(backtoGraphbtn);
            Controls.Add(label4);
            Controls.Add(DateAnadtp);
            Controls.Add(label3);
            Controls.Add(creditstxtbx);
            Controls.Add(label2);
            Controls.Add(DataMachNamtxtbx);
            Controls.Add(label1);
            Controls.Add(DataMachIDtxtbx);
            Controls.Add(updateDatabtn);
            Controls.Add(addDatabtn);
            Controls.Add(deleteDatabtn);
            Controls.Add(DataAnadgv);
            Name = "EarnedCredDataForm";
            Text = "Earned Credits Data Form";
            ((System.ComponentModel.ISupportInitialize)DataAnadgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataAnadgv;
        private MaterialSkin.Controls.MaterialButton updateDatabtn;
        private MaterialSkin.Controls.MaterialButton addDatabtn;
        private MaterialSkin.Controls.MaterialButton deleteDatabtn;
        private TextBox DataMachIDtxtbx;
        private Label label1;
        private Label label2;
        private TextBox DataMachNamtxtbx;
        private Label label3;
        private TextBox creditstxtbx;
        private DateTimePicker DateAnadtp;
        private Label label4;
        private MaterialSkin.Controls.MaterialButton backtoGraphbtn;
    }
}