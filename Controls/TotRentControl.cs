using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeSync_Project.Controls
{
    public partial class TotRentControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Jared Adlawan\\OneDrive\\ドキュメント\\ArcadeSync Database\\ArcadeSync.accdb";

        public TotRentControl()
        {
            InitializeComponent();

            StartRentaldtp.ValueChanged += StartRentaldtp_ValueChanged;
            dataRangeRentcmbbx.SelectedIndexChanged += DataRangeRentcmbbx_SelectedIndexChanged;
            dataRangeRentcmbbx.SelectedIndex = 0;
            LoadRentalData();
        }

        private void LoadRentalData()
        {
            DateTime startDate = StartRentaldtp.Value.Date;
            int rangeDays = GetRangeDays();
            DateTime endDate = startDate.AddDays(rangeDays);

            string query = "SELECT RentalMachine, RentDate, ReturnDate, RentalCost FROM Rental WHERE RentDate BETWEEN @start AND @end";
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@start", startDate);
                cmd.Parameters.AddWithValue("@end", endDate);
                using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            LoadRentalIncomeLineGraph(dt);
            LoadRentalDaysBarGraph(dt);
            LoadTotalRentalTable(dt);
        }

        private int GetRangeDays()
        {
            string range = dataRangeRentcmbbx.SelectedItem?.ToString() ?? "Weekly";
            return range switch
            {
                "Weekly" => 7,
                "Montly" => 30,
                "Yearly" => 365,
                _ => 7
            };
        }

        private void LoadRentalIncomeLineGraph(DataTable dt)
        {
            var model = new PlotModel
            {
                Title = "Rental Income Over Time",
                TextColor = OxyColors.Black,
                Background = OxyColors.White
            };

            model.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "MM-dd",
                Title = "Rent Date",
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                AxislineColor = OxyColors.Black,
                TicklineColor = OxyColors.Black
            });

            double min = 0, max = 0, step = 0;
            switch (dataRangeRentcmbbx.SelectedItem.ToString())
            {
                case "Weekly": min = 500; max = 5000; step = 500; break;
                case "Montly": min = 2000; max = 20000; step = 2000; break;
                case "Yearly": min = 24000; max = 240000; step = 24000; break;
            }

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Rental Income (₱)",
                Minimum = min,
                Maximum = max,
                MajorStep = step,
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                AxislineColor = OxyColors.Black,
                TicklineColor = OxyColors.Black
            });

            var grouped = dt.AsEnumerable().GroupBy(r => r["RentalMachine"].ToString());
            foreach (var group in grouped)
            {
                var series = new LineSeries 
                { 
                    Title = group.Key, 
                    MarkerType = MarkerType.Circle, 
                    MarkerSize = 3 
                };
                foreach (var row in group)
                {
                    DateTime date = Convert.ToDateTime(row["RentDate"]);
                    double income = Convert.ToDouble(row["RentalCost"]);
                    series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), income));
                }
                model.Series.Add(series);
            }

            var exporter = new PngExporter { Width = RentalPicBx.Width, Height = RentalPicBx.Height };
            using var bmp = exporter.ExportToBitmap(model);
            if (RentalPicBx.Image != null)
                RentalPicBx.Image.Dispose();
            RentalPicBx.Image = new Bitmap(bmp);
        }

        private void LoadRentalDaysBarGraph(DataTable dt)
        {
            var model = new PlotModel
            {
                Title = "Days Rented Per Machine",
                TextColor = OxyColors.Black,
                Background = OxyColors.White,
                
            };

            var daysData = dt.AsEnumerable()
                .GroupBy(r => r["RentalMachine"].ToString())
                .Select(g => new
                {
                    Machine = g.Key,
                    TotalDays = g.Sum(r => (Convert.ToDateTime(r["ReturnDate"]).Date - Convert.ToDateTime(r["RentDate"]).Date).Days)
                })
                .ToList();

            var barSeries = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                BarWidth = 0.4,
                FontSize = 12,
                ItemsSource = daysData.Select(d => new BarItem { Value = d.TotalDays }).ToList()
            };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left, //y-axis
                Key = "MachineAxis",
                ItemsSource = daysData,
                LabelField = "Machine",
                TextColor = OxyColors.Black,
                Title = "Machines",
                Font = "Segoe UI",
                FontSize = 12,
                TitleFontSize = 14
            };

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom, //x-axis
                Title = "Total Days",
                TextColor = OxyColors.Black,
                Font = "Segoe UI",
                FontSize = 12,
                TitleFontSize = 14
            });

            model.Axes.Add(categoryAxis);
            model.Series.Add(barSeries);

            var exporter = new PngExporter { Width = RentalBarPicBx.Width, Height = RentalBarPicBx.Height };
            using var bmp = exporter.ExportToBitmap(model);
            if (RentalBarPicBx.Image != null)
            {
                RentalBarPicBx.Image.Dispose();
            }
            RentalBarPicBx.Image = new Bitmap(bmp);
        }

        private void LoadTotalRentalTable(DataTable dt)
        {
            var summary = dt.AsEnumerable()
                .GroupBy(row => row["RentalMachine"].ToString())
                .Select(g => new
                {
                    Machine = g.Key,
                    TotalIncome = g.Sum(r => Convert.ToDecimal(r["RentalCost"]))
                })
                .ToList();

            TotalRentalgv.DataSource = summary;
        }

        private void StartRentaldtp_ValueChanged(object sender, EventArgs e)
        {
            LoadRentalData();
        }

        private void DataRangeRentcmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRentalData();
        }
    }
}
