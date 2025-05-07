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
    public partial class RentalControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";

        public RentalControl()
        {
            InitializeComponent();
        }

        private void RentalControl_Load(object sender, EventArgs e)
        {
            rentaldgv.DefaultCellStyle.ForeColor = Color.Black;
            rentaldgv.DefaultCellStyle.BackColor = Color.White;
            rentaldgv.DefaultCellStyle.SelectionForeColor = Color.White;
            rentaldgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            rentaldgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            rentaldgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            rentaldgv.EnableHeadersVisualStyles = false;

            infoRentdgv.DefaultCellStyle.ForeColor = Color.Black;
            infoRentdgv.DefaultCellStyle.BackColor = Color.White;
            infoRentdgv.DefaultCellStyle.SelectionForeColor = Color.White;
            infoRentdgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            infoRentdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            infoRentdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            infoRentdgv.EnableHeadersVisualStyles = false;


            LoadRentalData();


            LoadAvailableMachines();
        }

        private void LoadRentalData()
        {
            using var conn = new OleDbConnection(connStr);
            var adapter = new OleDbDataAdapter("SELECT * FROM Rental", conn);
            var table = new DataTable();
            adapter.Fill(table);
            infoRentdgv.DataSource = table;
        }

        private void LoadAvailableMachines()
        {
            string query = "SELECT MachineID, MachineName, Status, Location FROM ArcadeInventory";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                rentaldgv.DataSource = dt;
            }
        }

        private void RentPayTransactbtn_Click(object sender, EventArgs e)
        {
            if (rentaldgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a machine from the table first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = rentaldgv.SelectedRows[0];
            string machineID = row.Cells["MachineID"].Value.ToString();
            string machineName = row.Cells["MachineName"].Value.ToString();

            DateTime rentDate = startRentdtp.Value.Date;
            DateTime returnDate = endRentdtp.Value.Date;

            RentTransaction transactForm = new RentTransaction(
                machineID,
                machineName,
                rentDate,
                returnDate,
                rentIDtxtbx.Text,
                EventNametxtbx.Text,
                RentMachinetxtbx.Text,
                EmpIDRenttxtbx.Text,
                EmployNamRenttxtbx.Text,
                RenterNamtxtbx.Text,
                RenterPhonetxtbx.Text,
                RentVenuetxtbx.Text
            );
            transactForm.ShowDialog();
        }

        private void rentaldgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || rentaldgv.Rows[e.RowIndex].IsNewRow)
            {
                return;
            }

            string machineID = rentaldgv.Rows[e.RowIndex].Cells["MachineID"].Value.ToString();

            string query = "SELECT ArcadeImage FROM ArcadeInventory WHERE MachineID = @id";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", machineID);
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != DBNull.Value && result != null)
                {
                    byte[] imgData = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        rentMachinePictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    rentMachinePictureBox.Image = null;
                }
            }
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            if (rentaldgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row from the rental list to return a machine.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string machineID = rentaldgv.SelectedRows[0].Cells["MachineID"].Value.ToString();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string updateQuery = "UPDATE ArcadeInventory SET Status = 'Stored', Location = 'Storage' WHERE MachineID = ?";
                using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue(null, machineID);
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("Machine has been returned. Status set to 'Stored' and location updated to 'Storage'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAvailableMachines(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Machine ID may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
