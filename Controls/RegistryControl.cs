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
    public partial class RegistryControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";
        OleDbConnection conn;
        OleDbCommand cmd;
        DataSet ds;
        private string selectedEmployeeID = "";

        public RegistryControl()
        {
            InitializeComponent();
        }

        private void RegistryControl_Load(object sender, EventArgs e)
        {
            registrydgv.DefaultCellStyle.ForeColor = Color.Black;
            registrydgv.DefaultCellStyle.BackColor = Color.White;
            registrydgv.DefaultCellStyle.SelectionForeColor = Color.White;
            registrydgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            registrydgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            registrydgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            registrydgv.EnableHeadersVisualStyles = false;

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            conn = new OleDbConnection(connStr);
            string query = "SELECT * FROM Employee ORDER BY FullName ASC";
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Employee");
            conn.Close();
            registrydgv.DataSource = ds.Tables["Employee"];
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            string id = empIDRegistxtbx.Text.Trim();
            string fullName = fullNameRegistxtbx.Text.Trim();
            string username = usernameRegistxtbx.Text.Trim();
            string password = passwordCheckRegistxtbx.Text.Trim();
            string role = rolecmbbx.Text.Trim();
            string contact = conNumRegistxtbx.Text.Trim();
            string address = addressRegistxtbx.Text.Trim();

            if (id == "" || fullName == "" || username == "" || password == "")
            {
                MessageBox.Show("Please complete all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn = new OleDbConnection(connStr);
            string insertQuery = "INSERT INTO Employee (EmployeeID, FullName, Username, [Password], Role, ContactNum, Address) VALUES (?, ?, ?, ?, ?, ?, ?)";
            cmd = new OleDbCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("?", id);
            cmd.Parameters.AddWithValue("?", fullName);
            cmd.Parameters.AddWithValue("?", username);
            cmd.Parameters.AddWithValue("?", password);
            cmd.Parameters.AddWithValue("?", role);
            cmd.Parameters.AddWithValue("?", contact);
            cmd.Parameters.AddWithValue("?", address);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Employee registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployees();
        }

        private void updateEmploybtn_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == "")
            {
                MessageBox.Show("Select an employee first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = fullNameRegistxtbx.Text.Trim();
            string username = usernameRegistxtbx.Text.Trim();
            string password = passwordCheckRegistxtbx.Text.Trim();
            string role = rolecmbbx.Text.Trim();
            string contact = conNumRegistxtbx.Text.Trim();
            string address = addressRegistxtbx.Text.Trim();

            conn = new OleDbConnection(connStr);
            string updateQuery = "UPDATE Employee SET FullName = ?, Username = ?, [Password] = ?, Role = ?, ContactNum = ?, Address = ? WHERE EmployeeID = ?";
            cmd = new OleDbCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("?", fullName);
            cmd.Parameters.AddWithValue("?", username);
            cmd.Parameters.AddWithValue("?", password);
            cmd.Parameters.AddWithValue("?", role);
            cmd.Parameters.AddWithValue("?", contact);
            cmd.Parameters.AddWithValue("?", address);
            cmd.Parameters.AddWithValue("?", selectedEmployeeID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Employee record updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployees();
        }

        private void removeEmploybtn_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == "")
            {
                MessageBox.Show("Select an employee first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Remove this employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                conn = new OleDbConnection(connStr);
                string deleteQuery = "DELETE FROM Employee WHERE EmployeeID = ?";
                cmd = new OleDbCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("?", selectedEmployeeID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee removed.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                selectedEmployeeID = "";
            }
        }

        private void registrydgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = registrydgv.Rows[e.RowIndex];

                selectedEmployeeID = row.Cells["EmployeeID"].Value.ToString();
                empIDRegistxtbx.Text = selectedEmployeeID;
                fullNameRegistxtbx.Text = row.Cells["FullName"].Value.ToString();
                usernameRegistxtbx.Text = row.Cells["Username"].Value.ToString();
                passwordCheckRegistxtbx.Text = row.Cells["Password"].Value.ToString();
                rolecmbbx.Text = row.Cells["Role"].Value.ToString();
                conNumRegistxtbx.Text = row.Cells["ContactNum"].Value.ToString();
                addressRegistxtbx.Text = row.Cells["Address"].Value.ToString();
            }
        }
    }
}
