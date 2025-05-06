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
        private string userRole;

        public MainMenu(string role)
        {
            InitializeComponent();
            userRole = role;
            ConfigureTabsByRole();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700,
                Primary.Red900,
                Primary.Red500,
                Accent.Yellow700,
                TextShade.WHITE
            );
        }

        private void ConfigureTabsByRole()
        {

            // Manager
            if (userRole != "Manager")
            {
                MMTabControl1.TabPages.Remove(ShiftSched);
                MMTabControl1.TabPages.Remove(Registry);
                MMTabControl1.TabPages.Remove(Layout);
                MMTabControl1.TabPages.Remove(CredAna);
                MMTabControl1.TabPages.Remove(MainSched);
            }

            // Employee
            if (userRole != "Employee")
            {
                MMTabControl1.TabPages.Remove(RentalSys);
            }
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

                        case "Earned Credits":
                            selectedControl = new EarnedCredControl();
                            break;

                        case "Total Rentals":
                            selectedControl = new TotRentControl();
                            break;
                        case "Maintenance Schedule":
                            selectedControl = new MainSchedControl();
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
