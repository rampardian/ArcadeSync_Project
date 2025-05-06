using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ArcadeSync_Project
{
    public partial class Login : MaterialForm
    {

        private string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Jared Adlawan\OneDrive\ドキュメント\ArcadeSync Database\ArcadeSync.accdb""";
    
        public Login()
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

            label2.Font = new Font("MS UI Gothic", 18, FontStyle.Bold);
        }

        private void pwshowcheckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (pwshowcheckbx.Checked == true)
            {
                passwordtxtbx.PasswordChar = '\0';
            }
            else
            {
                passwordtxtbx.PasswordChar = '*';
            }
        }

        private void connectionbtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Employee WHERE Username = ? AND Password = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", usernametxtbx.Text.Trim());
                        cmd.Parameters.AddWithValue("?", passwordtxtbx.Text.Trim());

                        int result = (int)cmd.ExecuteScalar();

                        string roleQuery = "SELECT Role FROM Employee WHERE Username = ? AND Password = ?";
                        using (OleDbCommand roleCmd = new OleDbCommand(roleQuery, conn))
                        {
                            roleCmd.Parameters.AddWithValue("?", usernametxtbx.Text.Trim());
                            roleCmd.Parameters.AddWithValue("?", passwordtxtbx.Text.Trim());

                            string role = roleCmd.ExecuteScalar()?.ToString();

                            if (!string.IsNullOrEmpty(role))
                            {
                                MainMenu main = new MainMenu(role);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Role not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
