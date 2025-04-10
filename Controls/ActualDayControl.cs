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
        public CalendarControl ParentCalendar { get; set; }
        private DateTime _date;

        public ActualDayControl()
        {
            InitializeComponent();
        }

        public void SetDate(int day, int month, int year)
        {
            _date = new DateTime(year, month, day);
            daylbl.Text = day.ToString();
        }

        private void ActualDayControl_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            daylbl.Text = numday+"";
        }

        private void materialCard1_Click(object sender, EventArgs e)
        {

            if (ParentCalendar != null)
            {
                ParentCalendar.OpenLogForm(_date);
            }
        }
    }
}
