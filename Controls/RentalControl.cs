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
    public partial class RentalControl : UserControl
    {
        public RentalControl()
        {
            InitializeComponent();
        }

        private void RentalControl_Load(object sender, EventArgs e)
        {
            rentaldgv.DefaultCellStyle.ForeColor = Color.Black;
            rentaldgv.DefaultCellStyle.BackColor = Color.White;
            rentaldgv.DefaultCellStyle.SelectionForeColor = Color.White;
            rentaldgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            rentaldgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            rentaldgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            rentaldgv.EnableHeadersVisualStyles = false;
        }
    }
}
