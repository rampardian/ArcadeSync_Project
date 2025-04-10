using MaterialSkin;
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
    public partial class RentTransaction : MaterialForm
    {
        private string selectedMachineID;
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb";
        private decimal dailyRate = 450;

        private DateTime rentDate, returnDate;
        private string rentalID, eventName, machineName, employeeID, employeeName, renterName, phoneNum, venue;


        public RentTransaction(string machineID, string machineName, DateTime rentDate, DateTime returnDate,
                       string rentalID, string eventName, string arcadeMachine, string employeeID,
                       string employeeName, string renterName, string phoneNum, string venue)
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

            selectedMachineID = machineID;
            ArcNamelbl.Text = machineName;

            this.rentDate = rentDate;
            this.returnDate = returnDate;
            this.rentalID = rentalID;
            this.eventName = eventName;
            this.machineName = arcadeMachine;
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.renterName = renterName;
            this.phoneNum = phoneNum;
            this.venue = venue;

            LoadMachineImage();
            CalculateRentalCost();
        }

        private void CalculateRentalCost()
        {
            int days = (returnDate - rentDate).Days;
            if (days < 1) days = 1;

            decimal total = days * dailyRate;
            rentalCosttxtbx.Text = total.ToString("F2");
        }

        private void LoadMachineImage()
        {
            string query = "SELECT ArcadeImage FROM ArcadeInventory WHERE MachineID = @id";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", selectedMachineID);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    byte[] imgData = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        PictureBox pic = new PictureBox
                        {
                            Dock = DockStyle.Fill,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Image = Image.FromStream(ms)
                        };
                        arcadePicpanel.Controls.Clear();
                        arcadePicpanel.Controls.Add(pic);
                    }
                }
            }
        }

        private void recordTransactbtn_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Rental (RentalID, RentalEventName, RentalMachine, EmployeeID, EmployeeName, RenterName, PhoneNum, RentVenue, RentDate, ReturnDate, RentalCost, AmountPaid, ChangeDue, PaymentMethod, Notes) VALUES (@rentalID, @eventName, @machine, @empID, @empName, @renter, @phone, @venue, @rentDate, @returnDate, @cost, @paid, @change, @method, @notes)";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@rentalID", rentalID);
                cmd.Parameters.AddWithValue("@eventName", eventName);
                cmd.Parameters.AddWithValue("@machine", machineName);
                cmd.Parameters.AddWithValue("@empID", employeeID);
                cmd.Parameters.AddWithValue("@empName", employeeName);
                cmd.Parameters.AddWithValue("@renter", renterName);
                cmd.Parameters.AddWithValue("@phone", phoneNum);
                cmd.Parameters.AddWithValue("@venue", venue);
                cmd.Parameters.AddWithValue("@rentDate", rentDate);
                cmd.Parameters.AddWithValue("@returnDate", returnDate);
                cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(rentalCosttxtbx.Text));
                cmd.Parameters.AddWithValue("@paid", Convert.ToDecimal(amounttxtbx.Text));
                cmd.Parameters.AddWithValue("@change", Convert.ToDecimal(rentChangetxtbx.Text));
                cmd.Parameters.AddWithValue("@method", payMethodcmbbx.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@notes", rentNotestxtbx.Text);

                conn.Open();
                cmd.ExecuteNonQuery();

                // update machine status
                string updateStatusQuery = "UPDATE ArcadeInventory SET Status = @status WHERE MachineName = @machine";
                using (OleDbCommand updateCmd = new OleDbCommand(updateStatusQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@status", "Rented");
                    updateCmd.Parameters.AddWithValue("@machine", machineName);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Rental transaction successfully saved and machine status updated.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void amounttxtbx_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(amounttxtbx.Text, out decimal paid) && decimal.TryParse(rentalCosttxtbx.Text, out decimal cost))
            {
                decimal change = paid - cost;
                rentChangetxtbx.Text = change.ToString("F2");
            }
        }
    }
}
