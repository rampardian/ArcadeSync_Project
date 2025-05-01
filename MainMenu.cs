using ArcadeSync_Project.Controls;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeSync_Project
{
    public partial class MainMenu : MaterialForm
    {
        public MainMenu()
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
        }

        private void MMTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Control control in MMTabControl1.SelectedTab.Controls)
            {
                if(control is Panel panel)
                {
                    panel.Controls.Clear();

                    UserControl selectedControl = null;

                    switch (MMTabControl1.SelectedTab.Text)
                    {
                        case "Timekeeping System":
                            selectedControl = new EmployeeManaControl();
                            break;

                        case "Shift Schedule":
                            selectedControl = new ShiftSchedControl();
                            break;

                        case "Arcade Rental":
                            selectedControl = new RentalControl();
                            break;

                        case "Log Report Calendar":
                            selectedControl = new CalendarControl();
                            break;

                        case "Arcade Inventory":
                            selectedControl = new InventoryControl();
                            break;

                        case "Registry":
                            selectedControl = new RegistryControl();
                            break;

                        case "Arcade Layout":
                            selectedControl = new LayoutControl();
                            break;

                        case "Analytics":
                            selectedControl = new EarnedCredControl();
                            break;
                    }

                    if(selectedControl != null)
                    {
                        selectedControl.Dock = DockStyle.Fill;
                        panel.Controls.Add(selectedControl);
                    }
                }
            }
        }
    }
}
