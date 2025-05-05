using OxyPlot.Series;
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
    public partial class LayoutControl : UserControl
    {
        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Jared Adlawan\\OneDrive\\ドキュメント\\ArcadeSync Database\\ArcadeSync.accdb";


        public LayoutControl()
        {
            InitializeComponent();
        }

        private void LayoutControl_Load(object sender, EventArgs e)
        {
            string query = "SELECT MachineName, Location, ArcadeImage FROM ArcadeInventory";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string location = reader["Location"].ToString();

                        if (Controls.Find(location, true).FirstOrDefault() is PictureBox box && !reader.IsDBNull(2))
                        {
                            byte[] imageBytes = (byte[])reader["ArcadeImage"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                box.Image = Image.FromStream(ms);
                                box.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                }
            }
        }

        private void transferLayoutbtn_Click(object sender, EventArgs e)
        {
            var layoutForm = new LayoutForm();
            layoutForm.LayoutUpdated += (s, args) => LayoutControl_Load(this, EventArgs.Empty);
            layoutForm.Show();
        }
    }
}
