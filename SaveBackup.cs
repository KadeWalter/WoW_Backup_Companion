using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoW_Backup_Companion
{
    public partial class SaveBackup : Form
    {
        public SaveBackup()
        {
            InitializeComponent();
            setupUIElements();
        }

        // Configure the ui elements of controls.
        private void setupUIElements()
        {
            wowSelectLabel.BackColor = Color.Transparent;
            wowSelectLabel.Text = "Select Your World of Warcraft Folder";

            wowSelectNoteLabel.BackColor = Color.Transparent;
            wowSelectNoteLabel.Text = "Note: This folder that contains your _retail folder.";

            backupSelectLabel.BackColor = Color.Transparent;
            backupSelectLabel.Text = "Select A Folder To Store Your Backups";

            gameTypeLabel.BackColor = Color.Transparent;
            gameTypeLabel.Text = "Choose Games To Backup";

            backupButton.Text = "Backup";

            gameTypeCheckBoxList.Items.Add("Test");
        }

        // MARK: - EVENT ACTIONS

        // Function for checkbox list to deselect the highlight when checking a checkbox.
        private void gameTypeCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameTypeCheckBoxList.ClearSelected();
        }
    }
}
