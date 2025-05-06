namespace ArcadeSync_Project.Controls
{
    partial class MainSchedControl
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
            MainScheddgv = new DataGridView();
            MainSchedFormbtn = new MaterialSkin.Controls.MaterialButton();
            deleteSchedbtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)MainScheddgv).BeginInit();
            SuspendLayout();
            // 
            // MainScheddgv
            // 
            MainScheddgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MainScheddgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainScheddgv.Location = new Point(30, 30);
            MainScheddgv.Name = "MainScheddgv";
            MainScheddgv.RowHeadersWidth = 51;
            MainScheddgv.Size = new Size(971, 516);
            MainScheddgv.TabIndex = 39;
            // 
            // MainSchedFormbtn
            // 
            MainSchedFormbtn.AutoSize = false;
            MainSchedFormbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainSchedFormbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            MainSchedFormbtn.Depth = 0;
            MainSchedFormbtn.HighEmphasis = true;
            MainSchedFormbtn.Icon = null;
            MainSchedFormbtn.Location = new Point(30, 586);
            MainSchedFormbtn.Margin = new Padding(4, 6, 4, 6);
            MainSchedFormbtn.MouseState = MaterialSkin.MouseState.HOVER;
            MainSchedFormbtn.Name = "MainSchedFormbtn";
            MainSchedFormbtn.NoAccentTextColor = Color.Empty;
            MainSchedFormbtn.Size = new Size(343, 45);
            MainSchedFormbtn.TabIndex = 41;
            MainSchedFormbtn.Text = "Maintenance Schedule Form";
            MainSchedFormbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            MainSchedFormbtn.UseAccentColor = false;
            MainSchedFormbtn.UseVisualStyleBackColor = true;
            MainSchedFormbtn.Click += MainSchedFormbtn_Click;
            // 
            // deleteSchedbtn
            // 
            deleteSchedbtn.AutoSize = false;
            deleteSchedbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteSchedbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteSchedbtn.Depth = 0;
            deleteSchedbtn.HighEmphasis = true;
            deleteSchedbtn.Icon = null;
            deleteSchedbtn.Location = new Point(658, 586);
            deleteSchedbtn.Margin = new Padding(4, 6, 4, 6);
            deleteSchedbtn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteSchedbtn.Name = "deleteSchedbtn";
            deleteSchedbtn.NoAccentTextColor = Color.Empty;
            deleteSchedbtn.Size = new Size(343, 45);
            deleteSchedbtn.TabIndex = 42;
            deleteSchedbtn.Text = "Delete Schedule";
            deleteSchedbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteSchedbtn.UseAccentColor = false;
            deleteSchedbtn.UseVisualStyleBackColor = true;
            deleteSchedbtn.Click += deleteSchedbtn_Click;
            // 
            // MainSchedControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteSchedbtn);
            Controls.Add(MainSchedFormbtn);
            Controls.Add(MainScheddgv);
            Name = "MainSchedControl";
            Size = new Size(1080, 665);
            ((System.ComponentModel.ISupportInitialize)MainScheddgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView MainScheddgv;
        private MaterialSkin.Controls.MaterialButton MainSchedFormbtn;
        private MaterialSkin.Controls.MaterialButton deleteSchedbtn;
    }
}
