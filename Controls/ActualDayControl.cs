using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeSync_Project.Controls
{
    public partial class ActualDayControl : UserControl
    {
        public ActualDayControl()
        {
            InitializeComponent();
        }

        private void ActualDayControl_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            daylbl.Text = numday+"";
        }
    }
}
