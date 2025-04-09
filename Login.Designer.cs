namespace ArcadeSync_Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernametxtbx = new MaterialSkin.Controls.MaterialTextBox2();
            loginbtn = new Button();
            pwshowcheckbx = new MaterialSkin.Controls.MaterialCheckbox();
            label1 = new Label();
            label2 = new Label();
            passwordtxtbx = new MaterialSkin.Controls.MaterialMaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            connectionbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // usernametxtbx
            // 
            usernametxtbx.AnimateReadOnly = false;
            usernametxtbx.BackgroundImageLayout = ImageLayout.None;
            usernametxtbx.CharacterCasing = CharacterCasing.Normal;
            usernametxtbx.Depth = 0;
            usernametxtbx.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            usernametxtbx.HideSelection = true;
            usernametxtbx.Hint = "Username";
            usernametxtbx.LeadingIcon = null;
            usernametxtbx.Location = new Point(26, 373);
            usernametxtbx.MaxLength = 32767;
            usernametxtbx.MouseState = MaterialSkin.MouseState.OUT;
            usernametxtbx.Name = "usernametxtbx";
            usernametxtbx.PasswordChar = '\0';
            usernametxtbx.PrefixSuffixText = null;
            usernametxtbx.ReadOnly = false;
            usernametxtbx.RightToLeft = RightToLeft.No;
            usernametxtbx.SelectedText = "";
            usernametxtbx.SelectionLength = 0;
            usernametxtbx.SelectionStart = 0;
            usernametxtbx.ShortcutsEnabled = true;
            usernametxtbx.Size = new Size(312, 48);
            usernametxtbx.TabIndex = 1;
            usernametxtbx.TabStop = false;
            usernametxtbx.TextAlign = HorizontalAlignment.Left;
            usernametxtbx.TrailingIcon = null;
            usernametxtbx.UseSystemPasswordChar = false;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.CornflowerBlue;
            loginbtn.ForeColor = Color.Black;
            loginbtn.Location = new Point(26, 585);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(312, 38);
            loginbtn.TabIndex = 3;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // pwshowcheckbx
            // 
            pwshowcheckbx.AutoSize = true;
            pwshowcheckbx.Depth = 0;
            pwshowcheckbx.Location = new Point(26, 524);
            pwshowcheckbx.Margin = new Padding(0);
            pwshowcheckbx.MouseLocation = new Point(-1, -1);
            pwshowcheckbx.MouseState = MaterialSkin.MouseState.HOVER;
            pwshowcheckbx.Name = "pwshowcheckbx";
            pwshowcheckbx.ReadOnly = false;
            pwshowcheckbx.Ripple = true;
            pwshowcheckbx.Size = new Size(149, 37);
            pwshowcheckbx.TabIndex = 4;
            pwshowcheckbx.Text = "Show Password";
            pwshowcheckbx.UseVisualStyleBackColor = true;
            pwshowcheckbx.CheckedChanged += pwshowcheckbx_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 317);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 5;
            label1.Text = "Get Started!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 256);
            label2.Name = "label2";
            label2.Size = new Size(338, 30);
            label2.TabIndex = 6;
            label2.Text = "Welcome to ArcadeSync";
            // 
            // passwordtxtbx
            // 
            passwordtxtbx.AllowPromptAsInput = true;
            passwordtxtbx.AnimateReadOnly = false;
            passwordtxtbx.AsciiOnly = false;
            passwordtxtbx.BackgroundImageLayout = ImageLayout.None;
            passwordtxtbx.BeepOnError = false;
            passwordtxtbx.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            passwordtxtbx.Depth = 0;
            passwordtxtbx.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordtxtbx.HidePromptOnLeave = false;
            passwordtxtbx.HideSelection = true;
            passwordtxtbx.Hint = "Password";
            passwordtxtbx.InsertKeyMode = InsertKeyMode.Default;
            passwordtxtbx.LeadingIcon = null;
            passwordtxtbx.Location = new Point(26, 448);
            passwordtxtbx.Mask = "";
            passwordtxtbx.MaxLength = 32767;
            passwordtxtbx.MouseState = MaterialSkin.MouseState.OUT;
            passwordtxtbx.Name = "passwordtxtbx";
            passwordtxtbx.PasswordChar = '*';
            passwordtxtbx.PrefixSuffixText = null;
            passwordtxtbx.PromptChar = '_';
            passwordtxtbx.ReadOnly = false;
            passwordtxtbx.RejectInputOnFirstFailure = false;
            passwordtxtbx.ResetOnPrompt = true;
            passwordtxtbx.ResetOnSpace = true;
            passwordtxtbx.RightToLeft = RightToLeft.No;
            passwordtxtbx.SelectedText = "";
            passwordtxtbx.SelectionLength = 0;
            passwordtxtbx.SelectionStart = 0;
            passwordtxtbx.ShortcutsEnabled = true;
            passwordtxtbx.Size = new Size(312, 48);
            passwordtxtbx.SkipLiterals = true;
            passwordtxtbx.TabIndex = 8;
            passwordtxtbx.TabStop = false;
            passwordtxtbx.TextAlign = HorizontalAlignment.Left;
            passwordtxtbx.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            passwordtxtbx.TrailingIcon = null;
            passwordtxtbx.UseSystemPasswordChar = false;
            passwordtxtbx.ValidatingType = null;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(370, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(475, 591);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // connectionbtn
            // 
            connectionbtn.BackColor = Color.CornflowerBlue;
            connectionbtn.ForeColor = Color.Black;
            connectionbtn.Location = new Point(444, 585);
            connectionbtn.Name = "connectionbtn";
            connectionbtn.Size = new Size(312, 38);
            connectionbtn.TabIndex = 11;
            connectionbtn.Text = "Connection Test";
            connectionbtn.UseVisualStyleBackColor = false;
            connectionbtn.Click += connectionbtn_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 644);
            Controls.Add(connectionbtn);
            Controls.Add(pictureBox2);
            Controls.Add(passwordtxtbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pwshowcheckbx);
            Controls.Add(loginbtn);
            Controls.Add(usernametxtbx);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Padding = new Padding(4, 74, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 usernametxtbx;
        private Button loginbtn;
        private MaterialSkin.Controls.MaterialCheckbox pwshowcheckbx;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialMaskedTextBox passwordtxtbx;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button connectionbtn;
    }
}
