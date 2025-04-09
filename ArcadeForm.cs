using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeSync_Project
{
    public class ArcadeForm : Form
    {
        public ArcadeForm()
        {
            InitializeComponent();
            InitializeArcadeForm(); // Separate method for custom settings
        }

        private void InitializeArcadeForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ArcadeForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ArcadeForm";
            this.ResumeLayout(false);
        }
    }
}
