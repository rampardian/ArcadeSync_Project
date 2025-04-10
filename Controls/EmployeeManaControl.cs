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


namespace ArcadeSync_Project
{
    public partial class EmployeeManaControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";
        OleDbConnection conn;
        OleDbCommand cmd;
        DataSet ds;

        public EmployeeManaControl()
        {
            InitializeComponent();

        }

        private void EmployeeManaControl_Load(object sender, EventArgs e)
        {
            timer1.Start();

            attendancedgv.DefaultCellStyle.ForeColor = Color.Black;
            attendancedgv.DefaultCellStyle.BackColor = Color.White;
            attendancedgv.DefaultCellStyle.SelectionForeColor = Color.White;
            attendancedgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            attendancedgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            attendancedgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            attendancedgv.EnableHeadersVisualStyles = false;

            LoadAttendance();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void LoadAttendance()
        {
            conn = new OleDbConnection(connStr);
            string query = "SELECT * FROM AttendanceLogs ORDER BY DateShift DESC, TimeIn DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "AttendanceLogs");
            conn.Close();
            attendancedgv.DataSource = ds.Tables["AttendanceLogs"];
        }

        private void timeInbtn_Click(object sender, EventArgs e)
        {
            string id = empIDtxtbx.Text.Trim();
            string fullName = FullNametxtbx.Text.Trim();
            string password = passwordChecktxtbx.Text.Trim();

            if (id == "" || fullName == "" || password == "")
            {
                MessageBox.Show("All fields are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn = new OleDbConnection(connStr);
            conn.Open();

            string validateQuery = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @id AND FullName = @fullname AND [Password] = @password";
            cmd = new OleDbCommand(validateQuery, conn);
            cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;
            cmd.Parameters.Add("@fullname", OleDbType.VarWChar).Value = fullName;
            cmd.Parameters.Add("@password", OleDbType.VarWChar).Value = password;

            int match = (int)cmd.ExecuteScalar();

            if (match > 0)
            {
                string insertTimeIn = "INSERT INTO AttendanceLogs (EmployeeID, FullName, TimeIn, DateShift) VALUES (@id, @fullname, @timein, @dateshift)";
                cmd = new OleDbCommand(insertTimeIn, conn);
                cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;
                cmd.Parameters.Add("@fullname", OleDbType.VarWChar).Value = fullName;
                cmd.Parameters.Add("@timein", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("@dateshift", OleDbType.Date).Value = DateTime.Now.Date;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Time In successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendance();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private void timeOutbtn_Click(object sender, EventArgs e)
        {
            string id = empIDtxtbx.Text.Trim();
            string fullName = FullNametxtbx.Text.Trim();
            string password = passwordChecktxtbx.Text.Trim();

            if (id == "" || fullName == "" || password == "")
            {
                MessageBox.Show("All fields are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn = new OleDbConnection(connStr);
            conn.Open();

            string validateQuery = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @id AND FullName = @fullname AND [Password] = @password";
            cmd = new OleDbCommand(validateQuery, conn);
            cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;
            cmd.Parameters.Add("@fullname", OleDbType.VarWChar).Value = fullName;
            cmd.Parameters.Add("@password", OleDbType.VarWChar).Value = password;

            int match = (int)cmd.ExecuteScalar();

            if (match > 0)
            {
                string updateTimeOut = "UPDATE AttendanceLogs SET TimeOut = @timeout WHERE EmployeeID = @id AND DateShift = @dateshift AND TimeOut IS NULL";
                cmd = new OleDbCommand(updateTimeOut, conn);
                cmd.Parameters.Add("@timeout", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;
                cmd.Parameters.Add("@dateshift", OleDbType.Date).Value = DateTime.Now.Date;

                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("Time Out successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAttendance();
                }
                else
                {
                    MessageBox.Show("No active session found for time out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
