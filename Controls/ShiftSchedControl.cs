using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ArcadeSync_Project.Controls
{
    public partial class ShiftSchedControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";
        OleDbConnection conn;
        OleDbCommand cmd;
        DataSet ds;

        private int selectedScheduleID = -1;
        public ShiftSchedControl()
        {
            InitializeComponent();
        }
          
        private void ShiftSchedControl_Load(object sender, EventArgs e)
        {
            shiftdgv.DefaultCellStyle.ForeColor = Color.Black;
            shiftdgv.DefaultCellStyle.BackColor = Color.White;
            shiftdgv.DefaultCellStyle.SelectionForeColor = Color.White;
            shiftdgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            shiftdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            shiftdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            shiftdgv.EnableHeadersVisualStyles = false;

            startshiftdtp.Format = DateTimePickerFormat.Custom;
            startshiftdtp.CustomFormat = "MM/dd/yyyy hh:mm tt";

            LoadShifts();

            shiftdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shiftdgv.MultiSelect = false;
        }

        private void LoadShifts()
        {
            conn = new OleDbConnection(connStr);
            string query = "SELECT * FROM ShiftSched ORDER BY ShiftStart ASC";
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "ShiftSched");
            conn.Close();
            shiftdgv.DataSource = ds.Tables["ShiftSched"];
        }

        private void assignSchedbtn_Click(object sender, EventArgs e)
        {
            string id = ShiftEmpIDtxtbx.Text.Trim();
            string fullName = ShiftFNametxtbx.Text.Trim();
            string role = ShiftRoletxtbx.Text.Trim();
            DateTime start = startshiftdtp.Value;
            DateTime end = endshiftdtp.Value;

            if (id == "" || fullName == "" || role == "")
            {
                MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (start < DateTime.Now)
            {
                MessageBox.Show("Start of shift cannot be in the past.", "Invalid Shift Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (end <= start)
            {
                MessageBox.Show("Ending shift must be after starting shift.", "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn = new OleDbConnection(connStr);
            conn.Open();

            string insertQuery = "INSERT INTO ShiftSched (EmployeeID, FullName, Role, ShiftStart, ShiftEnd) VALUES (@id, @fullname, @role, @start, @end)";
            cmd = new OleDbCommand(insertQuery, conn);
            cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;
            cmd.Parameters.Add("@fullname", OleDbType.VarWChar).Value = fullName;
            cmd.Parameters.Add("@role", OleDbType.VarWChar).Value = role;
            cmd.Parameters.Add("@start", OleDbType.Date).Value = start;
            cmd.Parameters.Add("@end", OleDbType.Date).Value = end;

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Shift successfully assigned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadShifts();
        }

        private void shiftdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = shiftdgv.Rows[e.RowIndex];

                selectedScheduleID = Convert.ToInt32(row.Cells["ScheduleID"].Value);
                ShiftEmpIDtxtbx.Text = row.Cells["EmployeeID"].Value.ToString();
                ShiftFNametxtbx.Text = row.Cells["FullName"].Value.ToString();
                ShiftRoletxtbx.Text = row.Cells["Role"].Value.ToString();
                startshiftdtp.Value = Convert.ToDateTime(row.Cells["ShiftStart"].Value);
                endshiftdtp.Value = Convert.ToDateTime(row.Cells["ShiftEnd"].Value);
            }
        }

        private void removeSchedbtn_Click(object sender, EventArgs e)
        {
            if (selectedScheduleID == -1)
            {
                MessageBox.Show("Please select a schedule to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to remove this schedule?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();

                string deleteQuery = "DELETE FROM ShiftSched WHERE ScheduleID = @schedID";
                cmd = new OleDbCommand(deleteQuery, conn);
                cmd.Parameters.Add("@schedID", OleDbType.Integer).Value = selectedScheduleID;

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Schedule removed successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadShifts();
                selectedScheduleID = -1;
            }
        }

        private void updateSchedbtn_Click(object sender, EventArgs e)
        {
            if (selectedScheduleID == -1)
            {
                MessageBox.Show("Please select a schedule to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = ShiftEmpIDtxtbx.Text.Trim();
            string fullName = ShiftFNametxtbx.Text.Trim();
            string role = ShiftRoletxtbx.Text.Trim();
            DateTime start = startshiftdtp.Value;
            DateTime end = endshiftdtp.Value;

            if (id == "" || fullName == "" || role == "")
            {
                MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn = new OleDbConnection(connStr);
            conn.Open();

            string updateQuery = "UPDATE ShiftSched SET EmployeeID = @id, FullName = @fullname, Role = @role, ShiftStart = @start, ShiftEnd = @end WHERE ScheduleID = @schedID";
            cmd = new OleDbCommand(updateQuery, conn);
            cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;
            cmd.Parameters.Add("@fullname", OleDbType.VarWChar).Value = fullName;
            cmd.Parameters.Add("@role", OleDbType.VarWChar).Value = role;
            cmd.Parameters.Add("@start", OleDbType.Date).Value = start;
            cmd.Parameters.Add("@end", OleDbType.Date).Value = end;
            cmd.Parameters.Add("@schedID", OleDbType.Integer).Value = selectedScheduleID;

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Schedule updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadShifts();
        }
    }
}
