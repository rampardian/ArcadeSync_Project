using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeSync_Project.Controls
{
    public partial class MainSchedForm : MaterialForm
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";

        public MainSchedForm()
        {
            InitializeComponent();
            this.Load += MainSchedForm_Load;
            inventorydgv.SelectionChanged += inventorydgv_SelectionChanged;
        }

        private void LoadInventory()
        {
            using var conn = new OleDbConnection(connStr);
            var adapter = new OleDbDataAdapter("SELECT MachineID, MachineName, Status FROM ArcadeInventory", conn);
            var table = new DataTable();
            adapter.Fill(table);
            inventorydgv.DataSource = table;
        }

        private void MainSchedForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        public void LoadSelectedMaintenance(DataGridViewRow row)
        {
            mainIDtxtbx.Text = row.Cells["Main_ID"].Value.ToString();
            schedMachIDtxtbx.Text = row.Cells["MachineID"].Value.ToString();
            schedMachNamtxtbx.Text = row.Cells["MachineName"].Value.ToString();
            startScheddtp.Value = Convert.ToDateTime(row.Cells["MainDate_Start"].Value);
            endScheddtp.Value = Convert.ToDateTime(row.Cells["MainDate_End"].Value);
            Typecmbbx.Text = row.Cells["Main_Type"].Value.ToString();
            statuscmbxb.Text = row.Cells["Status"].Value.ToString();
            SchedDetailstxtbx.Text = row.Cells["Details"].Value.ToString();
        }

        private void recordSchedbtn_Click(object sender, EventArgs e)
        {
            using var conn = new OleDbConnection(connStr);
            conn.Open();

            var statusCmd = new OleDbCommand("SELECT Status FROM ArcadeInventory WHERE MachineID = ?", conn);
            statusCmd.Parameters.AddWithValue(null, int.Parse(schedMachIDtxtbx.Text));
            var currentStatus = statusCmd.ExecuteScalar()?.ToString();

            if (currentStatus == "Rented")
            {
                MessageBox.Show("This machine is currently rented and cannot be scheduled for maintenance.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            var cmd = new OleDbCommand(@"INSERT INTO Maintenance (MachineID, MachineName, MainDate_Start, MainDate_End, Main_Type, [Status], Details) VALUES (?, ?, ?, ?, ?, ?, ?)", conn);

            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(schedMachIDtxtbx.Text);
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = schedMachNamtxtbx.Text;
            cmd.Parameters.Add("?", OleDbType.Date).Value = startScheddtp.Value;
            cmd.Parameters.Add("?", OleDbType.Date).Value = endScheddtp.Value;
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = Typecmbbx.Text;
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = statuscmbxb.Text;
            cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = SchedDetailstxtbx.Text;

            cmd.ExecuteNonQuery();
            UpdateMachineStatus(conn);
            MessageBox.Show("Maintenance scheduled.");
        }

        private void updateSchedbtn_Click(object sender, EventArgs e)
        {
            using var conn = new OleDbConnection(connStr);
            conn.Open();

            var statusCmd = new OleDbCommand("SELECT Status FROM ArcadeInventory WHERE MachineID = ?", conn);
            statusCmd.Parameters.AddWithValue(null, int.Parse(schedMachIDtxtbx.Text));
            var currentStatus = statusCmd.ExecuteScalar()?.ToString();

            if (currentStatus == "Rented")
            {
                MessageBox.Show("This machine is currently rented and cannot be scheduled for maintenance.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cmd = new OleDbCommand(@"INSERT INTO Maintenance 
                (MachineID, MachineName, MainDate_Start, MainDate_End, Main_Type, [Status], Details)
                VALUES (?, ?, ?, ?, ?, ?, ?)", conn);

            cmd.Parameters.AddWithValue(null, int.Parse(schedMachIDtxtbx.Text));
            cmd.Parameters.AddWithValue(null, schedMachNamtxtbx.Text);
            cmd.Parameters.AddWithValue(null, startScheddtp.Value);
            cmd.Parameters.AddWithValue(null, endScheddtp.Value);
            cmd.Parameters.AddWithValue(null, Typecmbbx.Text);
            cmd.Parameters.AddWithValue(null, statuscmbxb.Text);
            cmd.Parameters.AddWithValue(null, SchedDetailstxtbx.Text);

            cmd.ExecuteNonQuery();
            UpdateMachineStatus(conn);
            MessageBox.Show("Maintenance scheduled.");
        }

        private void UpdateMachineStatus(OleDbConnection conn)
        {
            var checkCmd = new OleDbCommand("SELECT Status FROM ArcadeInventory WHERE MachineID = ?", conn);
            checkCmd.Parameters.AddWithValue(null, int.Parse(schedMachIDtxtbx.Text));
            var currentStatus = checkCmd.ExecuteScalar()?.ToString();

            if (currentStatus != "Maintenance")
            {
                var updateCmd = new OleDbCommand("UPDATE ArcadeInventory SET Status = 'Maintenance' WHERE MachineID = ?", conn);
                updateCmd.Parameters.AddWithValue(null, int.Parse(schedMachIDtxtbx.Text));
                updateCmd.ExecuteNonQuery();
            }
        }

        private void inventorydgv_SelectionChanged(object sender, EventArgs e)
        {
            if (inventorydgv.SelectedRows.Count == 0) return;
            string selectedID = inventorydgv.SelectedRows[0].Cells["MachineID"].Value.ToString();

            using var conn = new OleDbConnection(connStr);
            conn.Open();
            var cmd = new OleDbCommand("SELECT ArcadeImage FROM ArcadeInventory WHERE MachineID = ?", conn);
            cmd.Parameters.AddWithValue(null, int.Parse(selectedID));

            var result = cmd.ExecuteScalar();
            if (result != null && result is byte[] imageBytes)
            {
                using var ms = new MemoryStream(imageBytes);
                machImagepic.Image = Image.FromStream(ms);
                machImagepic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                machImagepic.Image = null;
            }
        }
    }
}
