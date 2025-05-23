﻿using MaterialSkin;
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
    public partial class EarnedCredDataForm : MaterialForm
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";

        public EarnedCredDataForm()
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

            DataAnadgv.DefaultCellStyle.BackColor = Color.White;
            DataAnadgv.DefaultCellStyle.ForeColor = Color.Black;
            DataAnadgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            DataAnadgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            LoadAnalyticsData();

        }

        private void LoadAnalyticsData()
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT * FROM EarnedCredAnalytics";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                DataAnadgv.DataSource = dt;
            }
        }

        private void addDatabtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "INSERT INTO EarnedCredAnalytics (MachineID, MachineName, CreditsEarned, DateAnalytics) VALUES (@id, @name, @credits, @date)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", DataMachIDtxtbx.Text);
                cmd.Parameters.AddWithValue("@name", DataMachNamtxtbx.Text);
                cmd.Parameters.AddWithValue("@credits", Convert.ToDouble(creditstxtbx.Text));
                cmd.Parameters.AddWithValue("@date", DateAnadtp.Value.Date);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAnalyticsData();
        }

        private void updateDatabtn_Click(object sender, EventArgs e)
        {
            if (DataAnadgv.CurrentRow == null) return;

            int id = Convert.ToInt32(DataAnadgv.CurrentRow.Cells["AnalyticsID"].Value);

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "UPDATE EarnedCredAnalytics SET MachineID = @id, MachineName = @name, CreditsEarned = @credits, DateAnalytics = @date WHERE AnalyticsID = @aid";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", DataMachIDtxtbx.Text);
                cmd.Parameters.AddWithValue("@name", DataMachNamtxtbx.Text);
                cmd.Parameters.AddWithValue("@credits", Convert.ToDouble(creditstxtbx.Text));
                cmd.Parameters.AddWithValue("@date", DateAnadtp.Value.Date);
                cmd.Parameters.AddWithValue("@aid", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAnalyticsData();
        }

        private void deleteDatabtn_Click(object sender, EventArgs e)
        {
            if (DataAnadgv.CurrentRow == null)
            {
                return;
            }


            if (DataAnadgv.SelectedRows.Count > 0)
            {
                var cellValue = DataAnadgv.SelectedRows[0].Cells["AnalyticsID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    using (OleDbConnection conn = new OleDbConnection(connStr))
                    {
                        string query = "DELETE FROM EarnedCredAnalytics WHERE AnalyticsID = @id";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    LoadAnalyticsData();
                }
                else
                {
                    MessageBox.Show("Invalid or missing AnalyticsID. Please select a valid row.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backtoGraphbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
