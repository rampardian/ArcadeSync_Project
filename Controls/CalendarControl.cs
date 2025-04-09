using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeSync_Project.Controls
{
    public partial class CalendarControl : UserControl
    {
        int month, year;
        public CalendarControl()
        {
            InitializeComponent();
        }

        private void CalendarControl_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearlabel.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // insert blank usercontrol to correct position

            for (int i = 1; i < dayoftheweek; i++)
            {
                BlankDayControl ucblank = new BlankDayControl();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                ActualDayControl ucdays = new ActualDayControl();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void nextMonthbtn_Click(object sender, EventArgs e)
        {
            // clear 
            daycontainer.Controls.Clear();
            //increment month
            month++;

            if(month == 13)
            {
                month = 1; 
                year++;
            }

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearlabel.Text = monthname + " " + year;

            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // insert blank usercontrol to correct position

            for (int i = 1; i < dayoftheweek; i++)
            {
                BlankDayControl ucblank = new BlankDayControl();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                ActualDayControl ucdays = new ActualDayControl();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void prevMonthbtn_Click(object sender, EventArgs e)
        {
            // clear 
            daycontainer.Controls.Clear();
            //decrement month
            month--;

            if (month == 0)
            {
                month = 12;
                year--;
            }

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearlabel.Text = monthname + " " + year;

            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // insert blank usercontrol to correct position

            for (int i = 1; i < dayoftheweek; i++)
            {
                BlankDayControl ucblank = new BlankDayControl();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                ActualDayControl ucdays = new ActualDayControl();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
