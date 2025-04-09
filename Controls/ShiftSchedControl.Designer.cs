namespace ArcadeSync_Project.Controls
{
    partial class ShiftSchedControl
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
            shiftdgv = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            startshiftdtp = new DateTimePicker();
            ShiftRoletxtbx = new MaterialSkin.Controls.MaterialTextBox();
            ShiftFNametxtbx = new MaterialSkin.Controls.MaterialTextBox();
            ShiftEmpIDtxtbx = new MaterialSkin.Controls.MaterialTextBox();
            toolTip1 = new ToolTip(components);
            updateSchedbtn = new MaterialSkin.Controls.MaterialButton();
            assignSchedbtn = new MaterialSkin.Controls.MaterialButton();
            removeSchedbtn = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            label5 = new Label();
            endshiftdtp = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)shiftdgv).BeginInit();
            SuspendLayout();
            // 
            // shiftdgv
            // 
            shiftdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            shiftdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shiftdgv.Location = new Point(30, 30);
            shiftdgv.Name = "shiftdgv";
            shiftdgv.RowHeadersWidth = 51;
            shiftdgv.Size = new Size(971, 402);
            shiftdgv.TabIndex = 0;
            shiftdgv.CellClick += shiftdgv_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 532);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 474);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 6;
            label1.Text = "Employee ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 606);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 9;
            label3.Text = "Role:";
            // 
            // startshiftdtp
            // 
            startshiftdtp.CustomFormat = "MM/dd/yyyy hh:mm tt";
            startshiftdtp.Format = DateTimePickerFormat.Custom;
            startshiftdtp.Location = new Point(656, 469);
            startshiftdtp.Name = "startshiftdtp";
            startshiftdtp.Size = new Size(345, 27);
            startshiftdtp.TabIndex = 12;
            // 
            // ShiftRoletxtbx
            // 
            ShiftRoletxtbx.AnimateReadOnly = false;
            ShiftRoletxtbx.BorderStyle = BorderStyle.None;
            ShiftRoletxtbx.Depth = 0;
            ShiftRoletxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ShiftRoletxtbx.LeadingIcon = null;
            ShiftRoletxtbx.Location = new Point(133, 592);
            ShiftRoletxtbx.MaxLength = 50;
            ShiftRoletxtbx.MouseState = MaterialSkin.MouseState.OUT;
            ShiftRoletxtbx.Multiline = false;
            ShiftRoletxtbx.Name = "ShiftRoletxtbx";
            ShiftRoletxtbx.Size = new Size(366, 50);
            ShiftRoletxtbx.TabIndex = 15;
            ShiftRoletxtbx.Text = "";
            ShiftRoletxtbx.TrailingIcon = null;
            // 
            // ShiftFNametxtbx
            // 
            ShiftFNametxtbx.AnimateReadOnly = false;
            ShiftFNametxtbx.BorderStyle = BorderStyle.None;
            ShiftFNametxtbx.Depth = 0;
            ShiftFNametxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ShiftFNametxtbx.LeadingIcon = null;
            ShiftFNametxtbx.Location = new Point(133, 522);
            ShiftFNametxtbx.MaxLength = 50;
            ShiftFNametxtbx.MouseState = MaterialSkin.MouseState.OUT;
            ShiftFNametxtbx.Multiline = false;
            ShiftFNametxtbx.Name = "ShiftFNametxtbx";
            ShiftFNametxtbx.Size = new Size(366, 50);
            ShiftFNametxtbx.TabIndex = 14;
            ShiftFNametxtbx.Text = "";
            ShiftFNametxtbx.TrailingIcon = null;
            // 
            // ShiftEmpIDtxtbx
            // 
            ShiftEmpIDtxtbx.AnimateReadOnly = false;
            ShiftEmpIDtxtbx.BorderStyle = BorderStyle.None;
            ShiftEmpIDtxtbx.Depth = 0;
            ShiftEmpIDtxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ShiftEmpIDtxtbx.LeadingIcon = null;
            ShiftEmpIDtxtbx.Location = new Point(133, 457);
            ShiftEmpIDtxtbx.MaxLength = 50;
            ShiftEmpIDtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            ShiftEmpIDtxtbx.Multiline = false;
            ShiftEmpIDtxtbx.Name = "ShiftEmpIDtxtbx";
            ShiftEmpIDtxtbx.Size = new Size(366, 50);
            ShiftEmpIDtxtbx.TabIndex = 13;
            ShiftEmpIDtxtbx.Text = "";
            ShiftEmpIDtxtbx.TrailingIcon = null;
            // 
            // updateSchedbtn
            // 
            updateSchedbtn.AutoSize = false;
            updateSchedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateSchedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateSchedbtn.Depth = 0;
            updateSchedbtn.HighEmphasis = true;
            updateSchedbtn.Icon = null;
            updateSchedbtn.Location = new Point(863, 598);
            updateSchedbtn.Margin = new Padding(4, 6, 4, 6);
            updateSchedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateSchedbtn.Name = "updateSchedbtn";
            updateSchedbtn.NoAccentTextColor = Color.Empty;
            updateSchedbtn.Size = new Size(138, 36);
            updateSchedbtn.TabIndex = 17;
            updateSchedbtn.Text = "Update Schedule";
            updateSchedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateSchedbtn.UseAccentColor = false;
            updateSchedbtn.UseVisualStyleBackColor = true;
            updateSchedbtn.Click += updateSchedbtn_Click;
            // 
            // assignSchedbtn
            // 
            assignSchedbtn.AutoSize = false;
            assignSchedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            assignSchedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            assignSchedbtn.Depth = 0;
            assignSchedbtn.HighEmphasis = true;
            assignSchedbtn.Icon = null;
            assignSchedbtn.Location = new Point(571, 598);
            assignSchedbtn.Margin = new Padding(4, 6, 4, 6);
            assignSchedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            assignSchedbtn.Name = "assignSchedbtn";
            assignSchedbtn.NoAccentTextColor = Color.Empty;
            assignSchedbtn.Size = new Size(138, 36);
            assignSchedbtn.TabIndex = 16;
            assignSchedbtn.Text = "Assign Schedule";
            assignSchedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            assignSchedbtn.UseAccentColor = false;
            assignSchedbtn.UseVisualStyleBackColor = true;
            assignSchedbtn.Click += assignSchedbtn_Click;
            // 
            // removeSchedbtn
            // 
            removeSchedbtn.AutoSize = false;
            removeSchedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeSchedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeSchedbtn.Depth = 0;
            removeSchedbtn.HighEmphasis = true;
            removeSchedbtn.Icon = null;
            removeSchedbtn.Location = new Point(717, 598);
            removeSchedbtn.Margin = new Padding(4, 6, 4, 6);
            removeSchedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            removeSchedbtn.Name = "removeSchedbtn";
            removeSchedbtn.NoAccentTextColor = Color.Empty;
            removeSchedbtn.Size = new Size(138, 36);
            removeSchedbtn.TabIndex = 18;
            removeSchedbtn.Text = "Remove schedule";
            removeSchedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            removeSchedbtn.UseAccentColor = false;
            removeSchedbtn.UseVisualStyleBackColor = true;
            removeSchedbtn.Click += removeSchedbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 474);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 19;
            label4.Text = "Starting Shift:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 532);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 21;
            label5.Text = "Ending Shift:";
            // 
            // endshiftdtp
            // 
            endshiftdtp.CustomFormat = "MM/dd/yyyy hh:mm tt";
            endshiftdtp.Format = DateTimePickerFormat.Custom;
            endshiftdtp.Location = new Point(656, 527);
            endshiftdtp.Name = "endshiftdtp";
            endshiftdtp.Size = new Size(345, 27);
            endshiftdtp.TabIndex = 20;
            // 
            // ShiftSchedControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(endshiftdtp);
            Controls.Add(label4);
            Controls.Add(removeSchedbtn);
            Controls.Add(updateSchedbtn);
            Controls.Add(assignSchedbtn);
            Controls.Add(ShiftRoletxtbx);
            Controls.Add(ShiftFNametxtbx);
            Controls.Add(ShiftEmpIDtxtbx);
            Controls.Add(startshiftdtp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(shiftdgv);
            Name = "ShiftSchedControl";
            Size = new Size(1080, 665);
            Load += ShiftSchedControl_Load;
            ((System.ComponentModel.ISupportInitialize)shiftdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView shiftdgv;
        private Label label2;
        private Label label1;
        private Label label3;
        private DateTimePicker startshiftdtp;
        private MaterialSkin.Controls.MaterialTextBox ShiftRoletxtbx;
        private MaterialSkin.Controls.MaterialTextBox ShiftFNametxtbx;
        private MaterialSkin.Controls.MaterialTextBox ShiftEmpIDtxtbx;
        private ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialButton updateSchedbtn;
        private MaterialSkin.Controls.MaterialButton assignSchedbtn;
        private MaterialSkin.Controls.MaterialButton removeSchedbtn;
        private Label label4;
        private Label label5;
        private DateTimePicker endshiftdtp;
    }
}
