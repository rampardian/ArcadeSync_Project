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
    public partial class MainSchedControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";

        public MainSchedControl()
        {
            InitializeComponent();
            LoadMaintenanceTable();

            MainScheddgv.DefaultCellStyle.ForeColor = Color.Black;
            MainScheddgv.DefaultCellStyle.BackColor = Color.White;
            MainScheddgv.DefaultCellStyle.SelectionForeColor = Color.White;
            MainScheddgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            MainScheddgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            MainScheddgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            MainScheddgv.EnableHeadersVisualStyles = false;
        }

        private void LoadMaintenanceTable()
        {
            using var conn = new OleDbConnection(connStr);
            var adapter = new OleDbDataAdapter("SELECT * FROM Maintenance", conn);
            var table = new DataTable();
            adapter.Fill(table);
            MainScheddgv.DataSource = table;
        }

        private void MainSchedFormbtn_Click(object sender, EventArgs e)
        {
            MainSchedForm form = new MainSchedForm();

            if (MainScheddgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = MainScheddgv.SelectedRows[0];
                form.LoadSelectedMaintenance(row);
            }

            form.FormClosed += (s, args) => LoadMaintenanceTable();
            form.Show();
        }

        private void deleteSchedbtn_Click(object sender, EventArgs e)
        {
            if (MainScheddgv.SelectedRows.Count == 0)
            {
                return;
            }

            var id = MainScheddgv.SelectedRows[0].Cells["Main_ID"].Value;
            using var conn = new OleDbConnection(connStr);
            conn.Open();
            var cmd = new OleDbCommand("DELETE FROM Maintenance WHERE Main_ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            LoadMaintenanceTable();
            MessageBox.Show("Schedule deleted.");
        }
    }
}
