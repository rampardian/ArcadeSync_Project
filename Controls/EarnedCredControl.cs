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
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;


namespace ArcadeSync_Project.Controls
{
    public partial class EarnedCredControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";
        

        public EarnedCredControl()
        {
            InitializeComponent();
            showDatabtn.Click += showDatabtn_Click;
            Load += EarnedCredControl_Load;

            StartEarndtp.ValueChanged += (s, e) => LoadAnalytics();
            dataRangecmbbx.SelectedIndexChanged += (s, e) => LoadAnalytics();

            TotalEarnedgv.DefaultCellStyle.BackColor = Color.White;
            TotalEarnedgv.DefaultCellStyle.ForeColor = Color.Black;
            TotalEarnedgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            TotalEarnedgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }



        private void EarnedCredControl_Load(object sender, EventArgs e)
        {
            dataRangecmbbx.SelectedIndex = 0;
            LoadAnalytics();

            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.Black;
                }
            }
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.Black;
                }
            }
            dataRangecmbbx.SelectedIndex = 0;
            LoadAnalytics();
        }

        private void showDatabtn_Click(object sender, EventArgs e)
        {
            var dataForm = new EarnedCredDataForm();
            dataForm.ShowDialog();
        }

        private void LoadAnalytics()
        {
            DateTime startDate = StartEarndtp.Value.Date;
            int rangeDays = GetRangeDays();
            DateTime endDate = startDate.AddDays(rangeDays);

            string query = "SELECT MachineName, CreditsEarned, DateAnalytics FROM EarnedCredAnalytics WHERE DateAnalytics BETWEEN @start AND @end";
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

            LoadLineGraph(dt);
            LoadDataGrid(dt);
        }

        private int GetRangeDays()
        {
            string range = dataRangecmbbx.SelectedItem?.ToString() ?? "Weekly"; 
            return range switch
            {
                "Weekly" => 7,
                "Montly" => 30,
                "Yearly" => 365,
                _ => 7,
            };
        }
        
        private void LoadDataGrid(DataTable dt)
        {
            var result = dt.AsEnumerable()
                .GroupBy(row => row["MachineName"].ToString())
                .Select(g => new
                {
                    MachineName = g.Key,
                    TotalCredits = g.Sum(r => Convert.ToInt32(r["CreditsEarned"]))
                })
                .ToList();

            TotalEarnedgv.DataSource = result;
        }

        private void LoadLineGraph(DataTable dt)    
        {
            var model = new PlotModel 
            { 
                Title = "Earned Credits Over Time",
                TextColor = OxyColors.Black,
                PlotAreaBorderColor = OxyColors.Gray,
                Background = OxyColors.White
            };
            model.Axes.Add(new DateTimeAxis 
            { 
                Position = AxisPosition.Bottom, 
                StringFormat = "MM-dd", 
                Title = "Date",
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                AxislineColor = OxyColors.Black,
                TicklineColor = OxyColors.Black
            });


            var yAxis = new LinearAxis 
            { 
                Position = AxisPosition.Left, 
                Title = "Credits Earned", 
            };

            double min = 0, max = 0, step = 0;
            switch (dataRangecmbbx.SelectedItem.ToString()) 
            {
                case "Weekly": min = 500; max = 5000; step = 500; break;
                case "Montly": min = 2000; max = 20000; step = 2000; break;
                case "Yearly": min = 24000; max = 240000; step = 24000; break;
            }

            yAxis.Minimum = min;
            yAxis.Maximum = max;
            yAxis.MajorStep = step;
            model.Axes.Add(yAxis);

            var grouped = dt.AsEnumerable().GroupBy(r => r["MachineName"].ToString());
            foreach (var group in grouped)
            {
                var series = new LineSeries { Title = group.Key, MarkerType = MarkerType.Circle, MarkerSize = 3 };
                foreach (var row in group)
                {
                    var date = Convert.ToDateTime(row["DateAnalytics"]);
                    var credits = Convert.ToDouble(row["CreditsEarned"]);
                    series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), credits));
                }
                model.Series.Add(series);
            }

            // Render to image
            var exporter = new PngExporter { Width = earnedCredPicBx.Width, Height = earnedCredPicBx.Height };
            using var bmp = exporter.ExportToBitmap(model);
            if (earnedCredPicBx.Image != null)
            {
                earnedCredPicBx.Image.Dispose();
            }
            earnedCredPicBx.Image = new Bitmap(bmp);
        }


    }
}
