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
using ScottPlot;
using ScottPlot.WinForms;
using ScottPlot.TickGenerators;
using ScottPlot.Colormaps;

namespace ArcadeSync_Project.Controls
{
    public partial class AnalyticsControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";


        public AnalyticsControl()
        {
            InitializeComponent();

            showDatabtn.Click += showDatabtn_Click;
        }

        private void showDatabtn_Click(object sender, EventArgs e)
        {
            using (var form = new AnalyticsDataForm())
            {
                form.ShowDialog(); 
            }

            if (dateRangecmbbx.SelectedItem == null)
            {
                MessageBox.Show("Please select a date range.");
                return;
            }

            DateTime startDate = dateTimePicker1.Value.Date;
            string range = dateRangecmbbx.SelectedItem.ToString();
            LoadGraph(startDate, range);
        }

        private void LoadGraph(DateTime startDate, string range)
        {
            DateTime endDate = range switch
            {
                "Weekly" => startDate.AddDays(6),
                "Monthly" => startDate.AddMonths(1).AddDays(-1),
                "Yearly" => startDate.AddYears(1).AddDays(-1),
                _ => startDate.AddDays(6)
            };

            List<double> xData = new();
            List<double> yData = new();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT DateAnalytics, CreditsEarned FROM Analytics WHERE DateAnalytics BETWEEN @start AND @end";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", startDate);
                cmd.Parameters.AddWithValue("@end", endDate);

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime date = Convert.ToDateTime(reader["DateAnalytics"]);
                    double credits = Convert.ToDouble(reader["CreditsEarned"]);

                    xData.Add(date.ToOADate());
                    yData.Add(credits);
                }
                conn.Close();
            }

            var plt = formsPlot1.Plot;
            plt.Clear();

            if (xData.Count > 0)
            {
                var xs = xData.ToArray();
                var ys = yData.ToArray();

                plt.Add.Scatter(xs, ys);
                plt.Axes.DateTimeTicksBottom();

                // Set Y limits only, but preserve X range
                double xMin = xs.Min();
                double xMax = xs.Max();
                double yMin = 0;
                double yMax = ys.Max() + 250;

                plt.Axes.SetLimits(xMin, xMax, yMin, yMax);
            }
            else
            {
                plt.Add.Text("No data in selected range", 0, 0);
            }


            plt.Title($"Credits Earned ({range})");
            formsPlot1.Refresh();
        }
    }
}
