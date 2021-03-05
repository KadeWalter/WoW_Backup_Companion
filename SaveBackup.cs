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

            // Configure the background color of items.
            wowSelectLabel.BackColor = Color.Transparent;
            wowSelectLabel.Text = "Select Your World of Warcraft Folder";

            wowSelectNoteLabel.BackColor = Color.Transparent;
            wowSelectNoteLabel.Text = "Select the folder that contains your _retail folder.";
        }
    }
}
