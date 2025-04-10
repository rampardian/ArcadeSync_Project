namespace ArcadeSync_Project.Controls
{
    partial class InventoryControl
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            inventorydgv = new DataGridView();
            label4 = new Label();
            statuscmbbx = new MaterialSkin.Controls.MaterialComboBox();
            machIDtxtbx = new MaterialSkin.Controls.MaterialTextBox();
            machNametxtbx = new MaterialSkin.Controls.MaterialTextBox();
            locationtxtbx = new MaterialSkin.Controls.MaterialTextBox();
            updateMachbtn = new MaterialSkin.Controls.MaterialButton();
            removeMachbtn = new MaterialSkin.Controls.MaterialButton();
            addMachbtn = new MaterialSkin.Controls.MaterialButton();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            label6 = new Label();
            searchMachbtn = new MaterialSkin.Controls.MaterialButton();
            label5 = new Label();
            insertArcPicbtn = new MaterialSkin.Controls.MaterialButton();
            machinePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)inventorydgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)machinePictureBox).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 552);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 19;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 497);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 17;
            label2.Text = "Machine Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 441);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 16;
            label1.Text = "MachineID:";
            // 
            // inventorydgv
            // 
            inventorydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventorydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventorydgv.Location = new Point(30, 30);
            inventorydgv.Name = "inventorydgv";
            inventorydgv.RowHeadersWidth = 51;
            inventorydgv.Size = new Size(687, 380);
            inventorydgv.TabIndex = 13;
            inventorydgv.CellClick += inventorydgv_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 609);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 24;
            label4.Text = "Location: ";
            // 
            // statuscmbbx
            // 
            statuscmbbx.AutoResize = false;
            statuscmbbx.BackColor = Color.FromArgb(255, 255, 255);
            statuscmbbx.Depth = 0;
            statuscmbbx.DrawMode = DrawMode.OwnerDrawVariable;
            statuscmbbx.DropDownHeight = 174;
            statuscmbbx.DropDownStyle = ComboBoxStyle.DropDownList;
            statuscmbbx.DropDownWidth = 121;
            statuscmbbx.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            statuscmbbx.ForeColor = Color.FromArgb(222, 0, 0, 0);
            statuscmbbx.FormattingEnabled = true;
            statuscmbbx.IntegralHeight = false;
            statuscmbbx.ItemHeight = 43;
            statuscmbbx.Items.AddRange(new object[] { "In Use", "Rented", "Maintenance", "Stored" });
            statuscmbbx.Location = new Point(148, 540);
            statuscmbbx.MaxDropDownItems = 4;
            statuscmbbx.MouseState = MaterialSkin.MouseState.OUT;
            statuscmbbx.Name = "statuscmbbx";
            statuscmbbx.Size = new Size(322, 49);
            statuscmbbx.StartIndex = 0;
            statuscmbbx.TabIndex = 26;
            // 
            // machIDtxtbx
            // 
            machIDtxtbx.AnimateReadOnly = false;
            machIDtxtbx.BorderStyle = BorderStyle.None;
            machIDtxtbx.Depth = 0;
            machIDtxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            machIDtxtbx.LeadingIcon = null;
            machIDtxtbx.Location = new Point(148, 428);
            machIDtxtbx.MaxLength = 50;
            machIDtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            machIDtxtbx.Multiline = false;
            machIDtxtbx.Name = "machIDtxtbx";
            machIDtxtbx.Size = new Size(322, 50);
            machIDtxtbx.TabIndex = 27;
            machIDtxtbx.Text = "";
            machIDtxtbx.TrailingIcon = null;
            // 
            // machNametxtbx
            // 
            machNametxtbx.AnimateReadOnly = false;
            machNametxtbx.BorderStyle = BorderStyle.None;
            machNametxtbx.Depth = 0;
            machNametxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            machNametxtbx.LeadingIcon = null;
            machNametxtbx.Location = new Point(148, 484);
            machNametxtbx.MaxLength = 50;
            machNametxtbx.MouseState = MaterialSkin.MouseState.OUT;
            machNametxtbx.Multiline = false;
            machNametxtbx.Name = "machNametxtbx";
            machNametxtbx.Size = new Size(322, 50);
            machNametxtbx.TabIndex = 28;
            machNametxtbx.Text = "";
            machNametxtbx.TrailingIcon = null;
            // 
            // locationtxtbx
            // 
            locationtxtbx.AnimateReadOnly = false;
            locationtxtbx.BorderStyle = BorderStyle.None;
            locationtxtbx.Depth = 0;
            locationtxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            locationtxtbx.LeadingIcon = null;
            locationtxtbx.Location = new Point(148, 595);
            locationtxtbx.MaxLength = 50;
            locationtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            locationtxtbx.Multiline = false;
            locationtxtbx.Name = "locationtxtbx";
            locationtxtbx.Size = new Size(322, 50);
            locationtxtbx.TabIndex = 29;
            locationtxtbx.Text = "";
            locationtxtbx.TrailingIcon = null;
            // 
            // updateMachbtn
            // 
            updateMachbtn.AutoSize = false;
            updateMachbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateMachbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateMachbtn.Depth = 0;
            updateMachbtn.HighEmphasis = true;
            updateMachbtn.Icon = null;
            updateMachbtn.Location = new Point(559, 601);
            updateMachbtn.Margin = new Padding(4, 6, 4, 6);
            updateMachbtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateMachbtn.Name = "updateMachbtn";
            updateMachbtn.NoAccentTextColor = Color.Empty;
            updateMachbtn.Size = new Size(213, 36);
            updateMachbtn.TabIndex = 32;
            updateMachbtn.Text = "Update Machine Details";
            updateMachbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateMachbtn.UseAccentColor = false;
            updateMachbtn.UseVisualStyleBackColor = true;
            updateMachbtn.Click += updateMachbtn_Click;
            // 
            // removeMachbtn
            // 
            removeMachbtn.AutoSize = false;
            removeMachbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeMachbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeMachbtn.Depth = 0;
            removeMachbtn.HighEmphasis = true;
            removeMachbtn.Icon = null;
            removeMachbtn.Location = new Point(788, 601);
            removeMachbtn.Margin = new Padding(4, 6, 4, 6);
            removeMachbtn.MouseState = MaterialSkin.MouseState.HOVER;
            removeMachbtn.Name = "removeMachbtn";
            removeMachbtn.NoAccentTextColor = Color.Empty;
            removeMachbtn.Size = new Size(213, 36);
            removeMachbtn.TabIndex = 31;
            removeMachbtn.Text = "Remove Machine";
            removeMachbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            removeMachbtn.UseAccentColor = false;
            removeMachbtn.UseVisualStyleBackColor = true;
            removeMachbtn.Click += removeMachbtn_Click;
            // 
            // addMachbtn
            // 
            addMachbtn.AutoSize = false;
            addMachbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addMachbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addMachbtn.Depth = 0;
            addMachbtn.HighEmphasis = true;
            addMachbtn.Icon = null;
            addMachbtn.Location = new Point(559, 544);
            addMachbtn.Margin = new Padding(4, 6, 4, 6);
            addMachbtn.MouseState = MaterialSkin.MouseState.HOVER;
            addMachbtn.Name = "addMachbtn";
            addMachbtn.NoAccentTextColor = Color.Empty;
            addMachbtn.Size = new Size(213, 36);
            addMachbtn.TabIndex = 30;
            addMachbtn.Text = "Add Machine";
            addMachbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addMachbtn.UseAccentColor = false;
            addMachbtn.UseVisualStyleBackColor = true;
            addMachbtn.Click += addMachbtn_Click;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(677, 427);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(322, 50);
            materialTextBox2.TabIndex = 34;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(559, 441);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 33;
            label6.Text = "Search:";
            // 
            // searchMachbtn
            // 
            searchMachbtn.AutoSize = false;
            searchMachbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchMachbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchMachbtn.Depth = 0;
            searchMachbtn.HighEmphasis = true;
            searchMachbtn.Icon = null;
            searchMachbtn.Location = new Point(788, 544);
            searchMachbtn.Margin = new Padding(4, 6, 4, 6);
            searchMachbtn.MouseState = MaterialSkin.MouseState.HOVER;
            searchMachbtn.Name = "searchMachbtn";
            searchMachbtn.NoAccentTextColor = Color.Empty;
            searchMachbtn.Size = new Size(213, 36);
            searchMachbtn.TabIndex = 35;
            searchMachbtn.Text = "Search Machine";
            searchMachbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchMachbtn.UseAccentColor = false;
            searchMachbtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 497);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 36;
            label5.Text = "Picture:";
            // 
            // insertArcPicbtn
            // 
            insertArcPicbtn.AutoSize = false;
            insertArcPicbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            insertArcPicbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            insertArcPicbtn.Depth = 0;
            insertArcPicbtn.HighEmphasis = true;
            insertArcPicbtn.Icon = null;
            insertArcPicbtn.Location = new Point(677, 489);
            insertArcPicbtn.Margin = new Padding(4, 6, 4, 6);
            insertArcPicbtn.MouseState = MaterialSkin.MouseState.HOVER;
            insertArcPicbtn.Name = "insertArcPicbtn";
            insertArcPicbtn.NoAccentTextColor = Color.Empty;
            insertArcPicbtn.Size = new Size(324, 36);
            insertArcPicbtn.TabIndex = 37;
            insertArcPicbtn.Text = "Insert Image";
            insertArcPicbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            insertArcPicbtn.UseAccentColor = false;
            insertArcPicbtn.UseVisualStyleBackColor = true;
            insertArcPicbtn.Click += insertArcPicbtn_Click;
            // 
            // machinePictureBox
            // 
            machinePictureBox.Location = new Point(723, 30);
            machinePictureBox.Name = "machinePictureBox";
            machinePictureBox.Size = new Size(278, 380);
            machinePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            machinePictureBox.TabIndex = 38;
            machinePictureBox.TabStop = false;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(machinePictureBox);
            Controls.Add(insertArcPicbtn);
            Controls.Add(label5);
            Controls.Add(searchMachbtn);
            Controls.Add(materialTextBox2);
            Controls.Add(label6);
            Controls.Add(updateMachbtn);
            Controls.Add(removeMachbtn);
            Controls.Add(addMachbtn);
            Controls.Add(locationtxtbx);
            Controls.Add(machNametxtbx);
            Controls.Add(machIDtxtbx);
            Controls.Add(statuscmbbx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inventorydgv);
            Name = "InventoryControl";
            Size = new Size(1080, 665);
            Load += InventoryControl_Load;
            ((System.ComponentModel.ISupportInitialize)inventorydgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)machinePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView inventorydgv;
        private Label label4;
        private MaterialSkin.Controls.MaterialComboBox statuscmbbx;
        private MaterialSkin.Controls.MaterialTextBox machIDtxtbx;
        private MaterialSkin.Controls.MaterialTextBox machNametxtbx;
        private MaterialSkin.Controls.MaterialTextBox locationtxtbx;
        private MaterialSkin.Controls.MaterialButton updateMachbtn;
        private MaterialSkin.Controls.MaterialButton removeMachbtn;
        private MaterialSkin.Controls.MaterialButton addMachbtn;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private Label label6;
        private MaterialSkin.Controls.MaterialButton searchMachbtn;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton insertArcPicbtn;
        private PictureBox machinePictureBox;
    }
}
