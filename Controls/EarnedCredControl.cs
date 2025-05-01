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
    public partial class EarnedCredControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";


        public EarnedCredControl()
        {
            InitializeComponent();
            showDatabtn.Click += showDatabtn_Click;

            Load += EarnedCredControl_Load;

        }

        private void EarnedCredControl_Load(object sender, EventArgs e)
        {
            dataRangecmbbx.SelectedIndex = 0;
            LoadAnalytics();
        }



        private void showDatabtn_Click(object sender, EventArgs e)
        {
            var dataForm = new EarnedCredDataForm();
            dataForm.ShowDialog();
            LoadAnalytics();
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


            LoadDataGrid(dt);
        }

        private int GetRangeDays()
        {
            string range = dataRangecmbbx.SelectedItem.ToString();
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
    }
}
