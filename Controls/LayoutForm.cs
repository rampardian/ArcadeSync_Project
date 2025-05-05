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
    public partial class LayoutForm : MaterialForm
    {
        public event EventHandler LayoutUpdated;

        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Jared Adlawan\\OneDrive\\ドキュメント\\ArcadeSync Database\\ArcadeSync.accdb";

        public LayoutForm()
        {
            InitializeComponent();

            Load += LayoutForm_Load;
            Locationdgv.SelectionChanged += Locationdgv_SelectionChanged;
            updateLocbtn.Click += updateLocbtn_Click;
            Backbtn.Click += (s, e) => Close();
        }

        private void LayoutForm_Load(object sender, EventArgs e)
        {
            LoadLocationTable();
        }

        private void LoadLocationTable()
        {
            using var conn = new OleDbConnection(connStr);
            var query = "SELECT MachineID, MachineName, Location FROM ArcadeInventory";
            var adapter = new OleDbDataAdapter(query, conn);
            var table = new DataTable();
            adapter.Fill(table);
            Locationdgv.DataSource = table;
        }

        private void Locationdgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Locationdgv.CurrentRow == null) return;

            LocMachIDtxtbx.Text = Locationdgv.CurrentRow.Cells["MachineID"].Value.ToString();
            LocMachNamtxtbx.Text = Locationdgv.CurrentRow.Cells["MachineName"].Value.ToString();
            Loccmbbx.SelectedItem = Locationdgv.CurrentRow.Cells["Location"].Value.ToString();

            LocMachIDtxtbx.ReadOnly = true;
            LocMachNamtxtbx.ReadOnly = true;
        }

        private void updateLocbtn_Click(object sender, EventArgs e)
        {
            if (LocMachIDtxtbx.ReadOnly == false || LocMachNamtxtbx.ReadOnly == false)
            {
                MessageBox.Show("Only location is editable. Machine ID and Name cannot be changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string machineId = LocMachIDtxtbx.Text;
            string newLoc = Loccmbbx.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(newLoc)) return;

            using var conn = new OleDbConnection(connStr);
            conn.Open();

            if (newLoc == "Storage")
            {
                var removeCmd = new OleDbCommand("UPDATE ArcadeInventory SET Location = 'Storage' WHERE MachineID = @id", conn);
                removeCmd.Parameters.AddWithValue("@id", machineId);
                removeCmd.ExecuteNonQuery();
                MessageBox.Show("Machine sent to storage.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var checkCmd = new OleDbCommand("SELECT MachineID FROM ArcadeInventory WHERE Location = @loc", conn);
                checkCmd.Parameters.AddWithValue("@loc", newLoc);
                var occupiedId = checkCmd.ExecuteScalar();

                if (occupiedId != null)
                {
                    var result = MessageBox.Show("Location occupied. Swap machines?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var tempLoc = "Temp" + Guid.NewGuid().ToString("N");
                        var update1 = new OleDbCommand("UPDATE ArcadeInventory SET Location = @temp WHERE MachineID = @occId", conn);
                        update1.Parameters.AddWithValue("@temp", tempLoc);
                        update1.Parameters.AddWithValue("@occId", occupiedId);
                        update1.ExecuteNonQuery();

                        var update2 = new OleDbCommand("UPDATE ArcadeInventory SET Location = @loc WHERE MachineID = @id", conn);
                        update2.Parameters.AddWithValue("@loc", newLoc);
                        update2.Parameters.AddWithValue("@id", machineId);
                        update2.ExecuteNonQuery();

                        var update3 = new OleDbCommand("UPDATE ArcadeInventory SET Location = @newLoc WHERE Location = @temp", conn);
                        update3.Parameters.AddWithValue("@newLoc", Locationdgv.CurrentRow.Cells["Location"].Value.ToString());
                        update3.Parameters.AddWithValue("@temp", tempLoc);
                        update3.ExecuteNonQuery();

                        MessageBox.Show("Machines swapped.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else return;
                }
                else
                {
                    var updateCmd = new OleDbCommand("UPDATE ArcadeInventory SET Location = @loc WHERE MachineID = @id", conn);
                    updateCmd.Parameters.AddWithValue("@loc", newLoc);
                    updateCmd.Parameters.AddWithValue("@id", machineId);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Location updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            LoadLocationTable();
        }
    }
}
