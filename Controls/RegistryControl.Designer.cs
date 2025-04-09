namespace ArcadeSync_Project.Controls
{
    partial class RegistryControl
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
            usernameRegistxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            fullNameRegistxtbx = new MaterialSkin.Controls.MaterialTextBox();
            empIDRegistxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label2 = new Label();
            label1 = new Label();
            registrydgv = new DataGridView();
            rolecmbbx = new MaterialSkin.Controls.MaterialComboBox();
            label4 = new Label();
            conNumRegistxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label5 = new Label();
            addressRegistxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label6 = new Label();
            Registerbtn = new MaterialSkin.Controls.MaterialButton();
            removeEmploybtn = new MaterialSkin.Controls.MaterialButton();
            updateEmploybtn = new MaterialSkin.Controls.MaterialButton();
            passwordCheckRegistxtbx = new MaterialSkin.Controls.MaterialTextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)registrydgv).BeginInit();
            SuspendLayout();
            // 
            // usernameRegistxtbx
            // 
            usernameRegistxtbx.AnimateReadOnly = false;
            usernameRegistxtbx.BorderStyle = BorderStyle.None;
            usernameRegistxtbx.Depth = 0;
            usernameRegistxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernameRegistxtbx.LeadingIcon = null;
            usernameRegistxtbx.Location = new Point(133, 536);
            usernameRegistxtbx.MaxLength = 50;
            usernameRegistxtbx.MouseState = MaterialSkin.MouseState.OUT;
            usernameRegistxtbx.Multiline = false;
            usernameRegistxtbx.Name = "usernameRegistxtbx";
            usernameRegistxtbx.Size = new Size(366, 50);
            usernameRegistxtbx.TabIndex = 23;
            usernameRegistxtbx.Text = "";
            usernameRegistxtbx.TrailingIcon = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 555);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 22;
            label3.Text = "Username:";
            // 
            // fullNameRegistxtbx
            // 
            fullNameRegistxtbx.AnimateReadOnly = false;
            fullNameRegistxtbx.BorderStyle = BorderStyle.None;
            fullNameRegistxtbx.Depth = 0;
            fullNameRegistxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullNameRegistxtbx.LeadingIcon = null;
            fullNameRegistxtbx.Location = new Point(133, 466);
            fullNameRegistxtbx.MaxLength = 50;
            fullNameRegistxtbx.MouseState = MaterialSkin.MouseState.OUT;
            fullNameRegistxtbx.Multiline = false;
            fullNameRegistxtbx.Name = "fullNameRegistxtbx";
            fullNameRegistxtbx.Size = new Size(366, 50);
            fullNameRegistxtbx.TabIndex = 21;
            fullNameRegistxtbx.Text = "";
            fullNameRegistxtbx.TrailingIcon = null;
            // 
            // empIDRegistxtbx
            // 
            empIDRegistxtbx.AnimateReadOnly = false;
            empIDRegistxtbx.BorderStyle = BorderStyle.None;
            empIDRegistxtbx.Depth = 0;
            empIDRegistxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            empIDRegistxtbx.LeadingIcon = null;
            empIDRegistxtbx.Location = new Point(133, 401);
            empIDRegistxtbx.MaxLength = 50;
            empIDRegistxtbx.MouseState = MaterialSkin.MouseState.OUT;
            empIDRegistxtbx.Multiline = false;
            empIDRegistxtbx.Name = "empIDRegistxtbx";
            empIDRegistxtbx.Size = new Size(366, 50);
            empIDRegistxtbx.TabIndex = 20;
            empIDRegistxtbx.Text = "";
            empIDRegistxtbx.TrailingIcon = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 485);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 15;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 418);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 14;
            label1.Text = "Employee ID:";
            // 
            // registrydgv
            // 
            registrydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registrydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrydgv.Location = new Point(30, 30);
            registrydgv.Name = "registrydgv";
            registrydgv.RowHeadersWidth = 51;
            registrydgv.Size = new Size(971, 364);
            registrydgv.TabIndex = 13;
            registrydgv.CellClick += registrydgv_CellClick;
            // 
            // rolecmbbx
            // 
            rolecmbbx.AutoResize = false;
            rolecmbbx.BackColor = Color.FromArgb(255, 255, 255);
            rolecmbbx.Depth = 0;
            rolecmbbx.DrawMode = DrawMode.OwnerDrawVariable;
            rolecmbbx.DropDownHeight = 174;
            rolecmbbx.DropDownStyle = ComboBoxStyle.DropDownList;
            rolecmbbx.DropDownWidth = 121;
            rolecmbbx.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            rolecmbbx.ForeColor = Color.FromArgb(222, 0, 0, 0);
            rolecmbbx.FormattingEnabled = true;
            rolecmbbx.IntegralHeight = false;
            rolecmbbx.ItemHeight = 43;
            rolecmbbx.Items.AddRange(new object[] { "Employee", "Manager" });
            rolecmbbx.Location = new Point(639, 402);
            rolecmbbx.MaxDropDownItems = 4;
            rolecmbbx.MouseState = MaterialSkin.MouseState.OUT;
            rolecmbbx.Name = "rolecmbbx";
            rolecmbbx.Size = new Size(362, 49);
            rolecmbbx.StartIndex = 0;
            rolecmbbx.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 418);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 27;
            label4.Text = "Role:";
            // 
            // conNumRegistxtbx
            // 
            conNumRegistxtbx.AnimateReadOnly = false;
            conNumRegistxtbx.BorderStyle = BorderStyle.None;
            conNumRegistxtbx.Depth = 0;
            conNumRegistxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            conNumRegistxtbx.LeadingIcon = null;
            conNumRegistxtbx.Location = new Point(635, 466);
            conNumRegistxtbx.MaxLength = 50;
            conNumRegistxtbx.MouseState = MaterialSkin.MouseState.OUT;
            conNumRegistxtbx.Multiline = false;
            conNumRegistxtbx.Name = "conNumRegistxtbx";
            conNumRegistxtbx.Size = new Size(366, 50);
            conNumRegistxtbx.TabIndex = 30;
            conNumRegistxtbx.Text = "";
            conNumRegistxtbx.TrailingIcon = null;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 485);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 29;
            label5.Text = "Contact Number:";
            // 
            // addressRegistxtbx
            // 
            addressRegistxtbx.AnimateReadOnly = false;
            addressRegistxtbx.BorderStyle = BorderStyle.None;
            addressRegistxtbx.Depth = 0;
            addressRegistxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            addressRegistxtbx.LeadingIcon = null;
            addressRegistxtbx.Location = new Point(635, 536);
            addressRegistxtbx.MaxLength = 50;
            addressRegistxtbx.MouseState = MaterialSkin.MouseState.OUT;
            addressRegistxtbx.Multiline = false;
            addressRegistxtbx.Name = "addressRegistxtbx";
            addressRegistxtbx.Size = new Size(366, 50);
            addressRegistxtbx.TabIndex = 32;
            addressRegistxtbx.Text = "";
            addressRegistxtbx.TrailingIcon = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 555);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 31;
            label6.Text = "Address: ";
            // 
            // Registerbtn
            // 
            Registerbtn.AutoSize = false;
            Registerbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Registerbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Registerbtn.Depth = 0;
            Registerbtn.HighEmphasis = true;
            Registerbtn.Icon = null;
            Registerbtn.Location = new Point(532, 621);
            Registerbtn.Margin = new Padding(4, 6, 4, 6);
            Registerbtn.MouseState = MaterialSkin.MouseState.HOVER;
            Registerbtn.Name = "Registerbtn";
            Registerbtn.NoAccentTextColor = Color.Empty;
            Registerbtn.Size = new Size(150, 36);
            Registerbtn.TabIndex = 34;
            Registerbtn.Text = "Register Employee";
            Registerbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Registerbtn.UseAccentColor = false;
            Registerbtn.UseVisualStyleBackColor = true;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // removeEmploybtn
            // 
            removeEmploybtn.AutoSize = false;
            removeEmploybtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeEmploybtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            removeEmploybtn.Depth = 0;
            removeEmploybtn.HighEmphasis = true;
            removeEmploybtn.Icon = null;
            removeEmploybtn.Location = new Point(848, 622);
            removeEmploybtn.Margin = new Padding(4, 6, 4, 6);
            removeEmploybtn.MouseState = MaterialSkin.MouseState.HOVER;
            removeEmploybtn.Name = "removeEmploybtn";
            removeEmploybtn.NoAccentTextColor = Color.Empty;
            removeEmploybtn.Size = new Size(150, 36);
            removeEmploybtn.TabIndex = 33;
            removeEmploybtn.Text = "Remove Employee";
            removeEmploybtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            removeEmploybtn.UseAccentColor = false;
            removeEmploybtn.UseVisualStyleBackColor = true;
            removeEmploybtn.Click += removeEmploybtn_Click;
            // 
            // updateEmploybtn
            // 
            updateEmploybtn.AutoSize = false;
            updateEmploybtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateEmploybtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateEmploybtn.Depth = 0;
            updateEmploybtn.HighEmphasis = true;
            updateEmploybtn.Icon = null;
            updateEmploybtn.Location = new Point(690, 622);
            updateEmploybtn.Margin = new Padding(4, 6, 4, 6);
            updateEmploybtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateEmploybtn.Name = "updateEmploybtn";
            updateEmploybtn.NoAccentTextColor = Color.Empty;
            updateEmploybtn.Size = new Size(150, 36);
            updateEmploybtn.TabIndex = 35;
            updateEmploybtn.Text = "Update Details";
            updateEmploybtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateEmploybtn.UseAccentColor = false;
            updateEmploybtn.UseVisualStyleBackColor = true;
            updateEmploybtn.Click += updateEmploybtn_Click;
            // 
            // passwordCheckRegistxtbx
            // 
            passwordCheckRegistxtbx.AnimateReadOnly = false;
            passwordCheckRegistxtbx.BorderStyle = BorderStyle.None;
            passwordCheckRegistxtbx.Depth = 0;
            passwordCheckRegistxtbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordCheckRegistxtbx.LeadingIcon = null;
            passwordCheckRegistxtbx.Location = new Point(133, 610);
            passwordCheckRegistxtbx.MaxLength = 50;
            passwordCheckRegistxtbx.MouseState = MaterialSkin.MouseState.OUT;
            passwordCheckRegistxtbx.Multiline = false;
            passwordCheckRegistxtbx.Name = "passwordCheckRegistxtbx";
            passwordCheckRegistxtbx.Size = new Size(366, 50);
            passwordCheckRegistxtbx.TabIndex = 37;
            passwordCheckRegistxtbx.Text = "";
            passwordCheckRegistxtbx.TrailingIcon = null;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 629);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 36;
            label7.Text = "Password:";
            // 
            // RegistryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(passwordCheckRegistxtbx);
            Controls.Add(label7);
            Controls.Add(updateEmploybtn);
            Controls.Add(Registerbtn);
            Controls.Add(removeEmploybtn);
            Controls.Add(addressRegistxtbx);
            Controls.Add(label6);
            Controls.Add(conNumRegistxtbx);
            Controls.Add(label5);
            Controls.Add(rolecmbbx);
            Controls.Add(label4);
            Controls.Add(usernameRegistxtbx);
            Controls.Add(label3);
            Controls.Add(fullNameRegistxtbx);
            Controls.Add(empIDRegistxtbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registrydgv);
            Name = "RegistryControl";
            Size = new Size(1080, 665);
            Load += RegistryControl_Load;
            ((System.ComponentModel.ISupportInitialize)registrydgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox usernameRegistxtbx;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox fullNameRegistxtbx;
        private MaterialSkin.Controls.MaterialTextBox empIDRegistxtbx;
        private Label label2;
        private Label label1;
        private DataGridView registrydgv;
        private MaterialSkin.Controls.MaterialComboBox rolecmbbx;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox conNumRegistxtbx;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox addressRegistxtbx;
        private Label label6;
        private MaterialSkin.Controls.MaterialButton Registerbtn;
        private MaterialSkin.Controls.MaterialButton removeEmploybtn;
        private MaterialSkin.Controls.MaterialButton updateEmploybtn;
        private MaterialSkin.Controls.MaterialTextBox passwordCheckRegistxtbx;
        private Label label7;
    }
}
