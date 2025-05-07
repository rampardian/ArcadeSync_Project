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
            da = new OleDbDataAdapter("SELECT MachineID, MachineName, Status, Location FROM ArcadeInventory", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "ArcadeInventory");
            inventorydgv.DataSource = ds.Tables["ArcadeInventory"];
            myConn.Close();
        }

        private void addMachbtn_Click(object sender, EventArgs e)
        {
            string id = machIDtxtbx.Text.Trim();
            string name = machNametxtbx.Text.Trim();
            string status = statuscmbbx.Text.Trim();
            string location = locationtxtbx.Text.Trim();

            if (id == "" || name == "" || status == "" || location == "")
            {
                MessageBox.Show("All fields must be filled.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            myConn = new OleDbConnection(connStr);
            string insertQuery = "INSERT INTO ArcadeInventory (MachineID, MachineName, Status, Location, ArcadeImage) VALUES (@id, @name, @status, @location, @image)";
            cmd = new OleDbCommand(insertQuery, myConn);

            cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;
            cmd.Parameters.Add("@name", OleDbType.VarWChar).Value = name;
            cmd.Parameters.Add("@status", OleDbType.VarWChar).Value = status;
            cmd.Parameters.Add("@location", OleDbType.VarWChar).Value = location;

            byte[] imgData;
            if (machinePictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    machinePictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgData = ms.ToArray();
                }
            }
            else
            {
                imgData = new byte[0];
            }

            cmd.Parameters.Add("@image", OleDbType.Binary).Value = imgData;

            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Machine added successfully.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadInventoryData();
        }

        private void updateMachbtn_Click(object sender, EventArgs e)
        {
            if (indexRow < 0)
            {
                MessageBox.Show("Please select a machine to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = machIDtxtbx.Text.Trim();
            string name = machNametxtbx.Text.Trim();
            string status = statuscmbbx.Text.Trim();
            string location = locationtxtbx.Text.Trim();

            if (id == "" || name == "" || status == "" || location == "")
            {
                MessageBox.Show("All fields must be filled.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            myConn = new OleDbConnection(connStr);
            string updateQuery = "UPDATE ArcadeInventory SET MachineName = @name, Status = @status, Location = @location, ArcadeImage = @image WHERE MachineID = @id";
            cmd = new OleDbCommand(updateQuery, myConn);

            cmd.Parameters.Add("@name", OleDbType.VarWChar).Value = name;
            cmd.Parameters.Add("@status", OleDbType.VarWChar).Value = status;
            cmd.Parameters.Add("@location", OleDbType.VarWChar).Value = location;

            byte[] imgData;
            if (machinePictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (Bitmap clone = new Bitmap(machinePictureBox.Image))
                    {
                        clone.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    imgData = ms.ToArray();
                }
            }
            else
            {
                imgData = new byte[0];
            }


            cmd.Parameters.Add("@image", OleDbType.Binary).Value = imgData;
            cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;

            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Machine record updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (indexRow < 0 || inventorydgv.Rows[indexRow].IsNewRow) return;

            DataGridViewRow row = inventorydgv.Rows[indexRow];

            string id = row.Cells["MachineID"].Value.ToString();
            machIDtxtbx.Text = id;
            machNametxtbx.Text = row.Cells["MachineName"].Value.ToString();
            statuscmbbx.Text = row.Cells["Status"].Value.ToString();
            locationtxtbx.Text = row.Cells["Location"].Value.ToString();

            // Retrieve image separately
            myConn = new OleDbConnection(connStr);
            string query = "SELECT ArcadeImage FROM ArcadeInventory WHERE MachineID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.Add("@id", OleDbType.VarWChar).Value = id;

            myConn.Open();
            object result = cmd.ExecuteScalar();
            myConn.Close();

            if (result != DBNull.Value && result != null)
            {
                byte[] imgData = (byte[])result;
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    machinePictureBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                machinePictureBox.Image = null;
            }
        }

        private void insertArcPicbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                machinePictureBox.Image = Image.FromFile(open.FileName);
                machinePictureBox.Tag = open.FileName;
            }
        }

        private void statuscmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statuscmbbx.Text)
            {
                case "Rented":
                    locationtxtbx.Text = "Rental Event";
                    break;
                case "Maintenance":
                    locationtxtbx.Text = "Repair Station";
                    break;
                case "Stored":
                    locationtxtbx.Text = "Storage";
                    break;
                default:
                    
                    break;
            }
        }
    }
}
