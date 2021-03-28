using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WoW_Backup_Companion.Properties;

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

            shouldSaveScreenshotsCheckbox.Checked = false;
            shouldSaveScreenshotsCheckbox.Text = "Save Screenshots?";
            shouldSaveScreenshotsCheckbox.BackColor = Color.Transparent;

            wowFolderPathTextBox.Text = Settings.Default["WorldOfWarcraftFilePath"].ToString();
            backupFolderPathTextBox.Text = Settings.Default["GameBackupFolderFilePath"].ToString();

            if (wowFolderPathTextBox.Text != "")
            {
                findWoWGameTypes(wowFolderPathTextBox.Text);
            }
        }

        // MARK: - EVENT ACTIONS

        // Function for checkbox list to deselect the highlight when checking a checkbox.
        private void gameTypeCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameTypeCheckBoxList.ClearSelected();
        }

        private void wowFolderButton_Click(object sender, EventArgs e)
        {
            // Open Windows File Explorer for the user to select the World of Warcraft folder.
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Settings.Default["WorldOfWarcraftFilePath"] = fbd.SelectedPath;
                    Settings.Default.Save();
                }
            }
            string fp = Settings.Default["WorldOfWarcraftFilePath"].ToString();
            wowFolderPathTextBox.Text = fp;

            findWoWGameTypes(fp);
        }

        private void findWoWGameTypes(string filePath)
        {
            gameTypeCheckBoxList.Items.Clear();

            // Scan for folders that begin with _ (_retail, _classic, _beta, _ptr)
            List<string> gameFolders = new List<string>();
            if (filePath != "")
            {
                string[] subFolders = Directory.GetDirectories(filePath);
                List<string> subs = new List<string>();
                foreach (string folder in subFolders)
                {
                    string subFolderName = new DirectoryInfo(folder).Name;
                    subs.Add(subFolderName);
                }

                foreach (string folder in subs)
                {
                    if (folder.Contains("_"))
                    {
                        string folderName = folder.Replace("_", "");
                        gameFolders.Add(folderName);
                    }
                }

                // For each folder found, update the checkbox list with an option for backup
                foreach (string folder in gameFolders)
                {
                    gameTypeCheckBoxList.Items.Add(folder);
                }
            }
        }

        private void backupFolderButton_Click(object sender, EventArgs e)
        {
            // Open Windows File Explorer for the user to select the folder they wish to store backups in.
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Settings.Default["GameBackupFolderFilePath"] = fbd.SelectedPath;
                    Settings.Default.Save();
                }
            }
            backupFolderPathTextBox.Text = Settings.Default["GameBackupFolderFilePath"].ToString();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            string wowFP = Settings.Default["WorldOfWarcraftFilePath"].ToString();
            string backupFP = Settings.Default["GameBackupFolderFilePath"].ToString();
            // Create a new date folder
            if (backupFP == "")
            {
                MessageBox.Show("Select a backup folder.");
                return;
            }
            string month = DateTime.Now.ToString("MM");
            string day = DateTime.Now.ToString("dd");
            string year = DateTime.Now.ToString("yyyy");
            string dateFolderPath = String.Format("{0}\\{1}_{2}_{3}", backupFP, month, day, year);
            System.IO.Directory.CreateDirectory(dateFolderPath);

            // For each option selected, create a new folder in the date folder and copy the contents from the wow folder
            int totalProgress = (gameTypeCheckBoxList.CheckedItems.Count * 3);
            copyingProgressBar.Maximum = totalProgress;
            copyingProgressBar.Value = 0;
            foreach (String gameType in gameTypeCheckBoxList.CheckedItems)
            {
                String wowGameDirectoryPath = "";
                DirectoryInfo diGameDirectory;
                String wowGameBackupPath = "";
                DirectoryInfo diBackupDirectory;

                // Backup WTF Folder
                // source directory = D:\\Blizzard\\WorldOfWarcraft\\_<GAME TYPE>_\\WTF
                wowGameDirectoryPath = String.Format("{0}\\_{1}_\\WTF", wowFP, gameType);
                if (System.IO.Directory.Exists(wowGameDirectoryPath))
                {
                    diGameDirectory = new DirectoryInfo(wowGameDirectoryPath);
                    // target directory = C:\\Desktop\\VS Backups\\03_28_2021\\<GAME TYPE>\\WTF
                    wowGameBackupPath = String.Format("{0}\\{1}\\WTF", dateFolderPath, gameType);
                    diBackupDirectory = new DirectoryInfo(wowGameBackupPath);
                    CopyEverything(diGameDirectory, diBackupDirectory);
                }
                copyingProgressBar.Increment(1);

                // Backup Interface Folder
                // source directory = D:\\Blizzard\\WorldOfWarcraft\\_<GAME TYPE>_\\Interface
                wowGameDirectoryPath = String.Format("{0}\\_{1}_\\Interface", wowFP, gameType);
                if (System.IO.Directory.Exists(wowGameDirectoryPath))
                {
                    diGameDirectory = new DirectoryInfo(wowGameDirectoryPath);
                    // target directory = C:\\Desktop\\VS Backups\\03_28_2021\\<GAME TYPE>\\Interface
                    wowGameBackupPath = String.Format("{0}\\{1}\\Interface", dateFolderPath, gameType);
                    diBackupDirectory = new DirectoryInfo(wowGameBackupPath);
                    CopyEverything(diGameDirectory, diBackupDirectory);
                }
                copyingProgressBar.Increment(1);

                // Backup Screenshots if selected
                if (shouldSaveScreenshotsCheckbox.Checked)
                {
                    // source directory = D:\\Blizzard\\WorldOfWarcraft\\_<GAME TYPE>_\\Screenshots
                    wowGameDirectoryPath = String.Format("{0}\\_{1}_\\Screenshots", wowFP, gameType);
                    if (System.IO.Directory.Exists(wowGameDirectoryPath))
                    {
                        diGameDirectory = new DirectoryInfo(wowGameDirectoryPath);
                        // target directory = C:\\Desktop\\VS Backups\\03_28_2021\\<GAME TYPE>\\Screenshots
                        wowGameBackupPath = String.Format("{0}\\{1}\\Screenshots", dateFolderPath, gameType);
                        diBackupDirectory = new DirectoryInfo(wowGameBackupPath);
                        CopyEverything(diGameDirectory, diBackupDirectory);
                    }
                }
                copyingProgressBar.Increment(1);
            }

            MessageBox.Show("Finished copying files.");
        }

        private void CopyEverything(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy the files in this directory to the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy the subdirectories using recursion.
            foreach (DirectoryInfo diSubDir in source.GetDirectories())
            {
                DirectoryInfo newTarSubDir = target.CreateSubdirectory(diSubDir.Name);
                CopyEverything(diSubDir, newTarSubDir);
            }
        }
    }
}
