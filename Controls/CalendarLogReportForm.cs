using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class CalendarLogReportForm : MaterialForm
    {
        private DateTime selectedDate;
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";
        private int? currentLogID = null;

        public CalendarLogReportForm(DateTime date)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700,  // Primary Color (Timezone Red)
                Primary.Red900,  // Dark Primary Color
                Primary.Red500,  // Light Primary Color
                Accent.Yellow700, // Accent Color (Timezone Yellow)
                TextShade.WHITE   // Text Color
            );

            selectedDate = date;
            datelbl.Text = date.ToString("MMMM dd, yyyy");
            LoadExistingReport();
        }

        private void LoadExistingReport()
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT * FROM Calendar WHERE DateLog = @date";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", selectedDate);

                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    currentLogID = Convert.ToInt32(reader["LogID"]);
                    LogEmployIDtxtbx.Text = reader["EmployeeID"].ToString();
                    LogEmployNamtxtbx.Text = reader["EmployeeName"].ToString();
                    LogReporttxtbx.Text = reader["LogReport"].ToString();
                }
                conn.Close();
            }
        }

        private void addRepbtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "INSERT INTO Calendar (DateLog, LogReport, EmployeeName, EmployeeID) VALUES (@date, @log, @name, @id)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", selectedDate);
                cmd.Parameters.AddWithValue("@log", LogReporttxtbx.Text);
                cmd.Parameters.AddWithValue("@name", LogEmployNamtxtbx.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(LogEmployIDtxtbx.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Log report added.");
                this.Close();
            }
        }

        private void updateRepbtn_Click(object sender, EventArgs e)
        {
            if (currentLogID == null)
            {
                MessageBox.Show("No report exists for this day.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "UPDATE Calendar SET LogReport = @log, EmployeeName = @name, EmployeeID = @id WHERE LogID = @logid";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@log", LogReporttxtbx.Text);
                cmd.Parameters.AddWithValue("@name", LogEmployNamtxtbx.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(LogEmployIDtxtbx.Text));
                cmd.Parameters.AddWithValue("@logid", currentLogID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Log report updated.");
                this.Close();
            }
        }

        private void removeRepbtn_Click(object sender, EventArgs e)
        {
            if (currentLogID == null)
            {
                MessageBox.Show("No log report to delete.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "DELETE FROM Calendar WHERE LogID = @id";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", currentLogID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Log report deleted.");
                this.Close();
            }
        }
    }
}
