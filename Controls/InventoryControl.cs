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
    public partial class InventoryControl : UserControl
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;

        string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Jared Adlawan\\OneDrive\\ドキュメント\\ArcadeSync Database\\ArcadeSync.accdb\"";

        public InventoryControl()
        {
            InitializeComponent();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            LoadInventoryData();

            inventorydgv.DefaultCellStyle.ForeColor = Color.Black;
            inventorydgv.DefaultCellStyle.BackColor = Color.White;
            inventorydgv.DefaultCellStyle.SelectionForeColor = Color.White;
            inventorydgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            inventorydgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            inventorydgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            inventorydgv.EnableHeadersVisualStyles = false;
        }

        private void LoadInventoryData()
        {
            myConn = new OleDbConnection(connStr);
            da = new OleDbDataAdapter("SELECT * FROM ArcadeInventory", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "ArcadeInventory");
            inventorydgv.DataSource = ds.Tables["ArcadeInventory"];
            myConn.Close();
        }

        private void addMachbtn_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection(connStr);
            string query = "INSERT INTO ArcadeInventory (MachineID, MachineName, Status, Location) VALUES (@id, @name, @status, @location)";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", machIDtxtbx.Text);
            cmd.Parameters.AddWithValue("@name", machNametxtbx.Text);
            cmd.Parameters.AddWithValue("@status", statuscmbbx.Text);
            cmd.Parameters.AddWithValue("@location", locationtxtbx.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            LoadInventoryData();
        }

        private void updateMachbtn_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection(connStr);
            string query = "UPDATE ArcadeInventory SET MachineName = @name, Status = @status, Location = @location WHERE MachineID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@name", machNametxtbx.Text);
            cmd.Parameters.AddWithValue("@status", statuscmbbx.Text);
            cmd.Parameters.AddWithValue("@location", locationtxtbx.Text);
            cmd.Parameters.AddWithValue("@id", machIDtxtbx.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            LoadInventoryData();
        }

        private void removeMachbtn_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection(connStr);
            string query = "DELETE FROM ArcadeInventory WHERE MachineID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", machIDtxtbx.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();
            LoadInventoryData();
        }

        private void inventorydgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = inventorydgv.Rows[indexRow];
            machIDtxtbx.Text = row.Cells["MachineID"].Value.ToString();
            machNametxtbx.Text = row.Cells["MachineName"].Value.ToString();
            statuscmbbx.SelectedItem = row.Cells["Status"].Value.ToString();
            locationtxtbx.Text = row.Cells["Location"].Value.ToString();
        }
    }
}
