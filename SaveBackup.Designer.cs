
namespace WoW_Backup_Companion
{
    partial class SaveBackup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wowFolderButton = new System.Windows.Forms.Button();
            this.wowFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.wowSelectLabel = new System.Windows.Forms.Label();
            this.wowSelectNoteLabel = new System.Windows.Forms.Label();
            this.backupSelectLabel = new System.Windows.Forms.Label();
            this.backupFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.backupFolderButton = new System.Windows.Forms.Button();
            this.gameTypeCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.gameTypeLabel = new System.Windows.Forms.Label();
            this.backupButton = new System.Windows.Forms.Button();
            this.copyingProgressBar = new System.Windows.Forms.ProgressBar();
            this.shouldSaveScreenshotsCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // wowFolderButton
            // 
            this.wowFolderButton.FlatAppearance.BorderSize = 0;
            this.wowFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.wowFolderButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wowFolderButton.Location = new System.Drawing.Point(708, 175);
            this.wowFolderButton.Name = "wowFolderButton";
            this.wowFolderButton.Size = new System.Drawing.Size(27, 26);
            this.wowFolderButton.TabIndex = 0;
            this.wowFolderButton.TabStop = false;
            this.wowFolderButton.Text = ">";
            this.wowFolderButton.UseVisualStyleBackColor = true;
            this.wowFolderButton.Click += new System.EventHandler(this.wowFolderButton_Click);
            // 
            // wowFolderPathTextBox
            // 
            this.wowFolderPathTextBox.Enabled = false;
            this.wowFolderPathTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wowFolderPathTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wowFolderPathTextBox.Location = new System.Drawing.Point(12, 175);
            this.wowFolderPathTextBox.Name = "wowFolderPathTextBox";
            this.wowFolderPathTextBox.ReadOnly = true;
            this.wowFolderPathTextBox.Size = new System.Drawing.Size(690, 26);
            this.wowFolderPathTextBox.TabIndex = 1;
            this.wowFolderPathTextBox.TabStop = false;
            this.wowFolderPathTextBox.WordWrap = false;
            // 
            // wowSelectLabel
            // 
            this.wowSelectLabel.AutoSize = true;
            this.wowSelectLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wowSelectLabel.ForeColor = System.Drawing.Color.White;
            this.wowSelectLabel.Location = new System.Drawing.Point(12, 150);
            this.wowSelectLabel.Name = "wowSelectLabel";
            this.wowSelectLabel.Size = new System.Drawing.Size(148, 22);
            this.wowSelectLabel.TabIndex = 2;
            this.wowSelectLabel.Text = "wowSelectLabel";
            // 
            // wowSelectNoteLabel
            // 
            this.wowSelectNoteLabel.AutoSize = true;
            this.wowSelectNoteLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.wowSelectNoteLabel.ForeColor = System.Drawing.Color.White;
            this.wowSelectNoteLabel.Location = new System.Drawing.Point(12, 204);
            this.wowSelectNoteLabel.Name = "wowSelectNoteLabel";
            this.wowSelectNoteLabel.Size = new System.Drawing.Size(122, 15);
            this.wowSelectNoteLabel.TabIndex = 3;
            this.wowSelectNoteLabel.Text = "wowSelectNoteLabel";
            // 
            // backupSelectLabel
            // 
            this.backupSelectLabel.AutoSize = true;
            this.backupSelectLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupSelectLabel.ForeColor = System.Drawing.Color.White;
            this.backupSelectLabel.Location = new System.Drawing.Point(12, 279);
            this.backupSelectLabel.Name = "backupSelectLabel";
            this.backupSelectLabel.Size = new System.Drawing.Size(172, 22);
            this.backupSelectLabel.TabIndex = 5;
            this.backupSelectLabel.Text = "backupSelectLabel";
            // 
            // backupFolderPathTextBox
            // 
            this.backupFolderPathTextBox.Enabled = false;
            this.backupFolderPathTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupFolderPathTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backupFolderPathTextBox.Location = new System.Drawing.Point(12, 304);
            this.backupFolderPathTextBox.Name = "backupFolderPathTextBox";
            this.backupFolderPathTextBox.Size = new System.Drawing.Size(690, 26);
            this.backupFolderPathTextBox.TabIndex = 6;
            this.backupFolderPathTextBox.TabStop = false;
            // 
            // backupFolderButton
            // 
            this.backupFolderButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupFolderButton.Location = new System.Drawing.Point(708, 304);
            this.backupFolderButton.Name = "backupFolderButton";
            this.backupFolderButton.Size = new System.Drawing.Size(27, 26);
            this.backupFolderButton.TabIndex = 7;
            this.backupFolderButton.TabStop = false;
            this.backupFolderButton.Text = ">";
            this.backupFolderButton.UseVisualStyleBackColor = true;
            this.backupFolderButton.Click += new System.EventHandler(this.backupFolderButton_Click);
            // 
            // gameTypeCheckBoxList
            // 
            this.gameTypeCheckBoxList.CheckOnClick = true;
            this.gameTypeCheckBoxList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTypeCheckBoxList.FormattingEnabled = true;
            this.gameTypeCheckBoxList.Location = new System.Drawing.Point(13, 421);
            this.gameTypeCheckBoxList.Name = "gameTypeCheckBoxList";
            this.gameTypeCheckBoxList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameTypeCheckBoxList.Size = new System.Drawing.Size(230, 109);
            this.gameTypeCheckBoxList.TabIndex = 9;
            this.gameTypeCheckBoxList.TabStop = false;
            this.gameTypeCheckBoxList.UseTabStops = false;
            this.gameTypeCheckBoxList.SelectedIndexChanged += new System.EventHandler(this.gameTypeCheckBoxList_SelectedIndexChanged);
            // 
            // gameTypeLabel
            // 
            this.gameTypeLabel.AutoSize = true;
            this.gameTypeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTypeLabel.ForeColor = System.Drawing.Color.White;
            this.gameTypeLabel.Location = new System.Drawing.Point(13, 396);
            this.gameTypeLabel.Name = "gameTypeLabel";
            this.gameTypeLabel.Size = new System.Drawing.Size(147, 22);
            this.gameTypeLabel.TabIndex = 10;
            this.gameTypeLabel.Text = "gameTypeLabel";
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(473, 440);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(116, 40);
            this.backupButton.TabIndex = 12;
            this.backupButton.TabStop = false;
            this.backupButton.Text = "backupButton";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // copyingProgressBar
            // 
            this.copyingProgressBar.Location = new System.Drawing.Point(391, 507);
            this.copyingProgressBar.Name = "copyingProgressBar";
            this.copyingProgressBar.Size = new System.Drawing.Size(279, 23);
            this.copyingProgressBar.TabIndex = 13;
            // 
            // shouldSaveScreenshotsCheckbox
            // 
            this.shouldSaveScreenshotsCheckbox.AutoSize = true;
            this.shouldSaveScreenshotsCheckbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shouldSaveScreenshotsCheckbox.ForeColor = System.Drawing.Color.White;
            this.shouldSaveScreenshotsCheckbox.Location = new System.Drawing.Point(12, 536);
            this.shouldSaveScreenshotsCheckbox.Name = "shouldSaveScreenshotsCheckbox";
            this.shouldSaveScreenshotsCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shouldSaveScreenshotsCheckbox.Size = new System.Drawing.Size(105, 22);
            this.shouldSaveScreenshotsCheckbox.TabIndex = 14;
            this.shouldSaveScreenshotsCheckbox.Text = "checkBox1";
            this.shouldSaveScreenshotsCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaveBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::WoW_Backup_Companion.Properties.Resources.wow_sl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 568);
            this.Controls.Add(this.shouldSaveScreenshotsCheckbox);
            this.Controls.Add(this.copyingProgressBar);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.gameTypeLabel);
            this.Controls.Add(this.gameTypeCheckBoxList);
            this.Controls.Add(this.backupFolderButton);
            this.Controls.Add(this.backupFolderPathTextBox);
            this.Controls.Add(this.backupSelectLabel);
            this.Controls.Add(this.wowSelectNoteLabel);
            this.Controls.Add(this.wowSelectLabel);
            this.Controls.Add(this.wowFolderButton);
            this.Controls.Add(this.wowFolderPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaveBackup";
            this.Text = "WoW Backup Companion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wowFolderButton;
        private System.Windows.Forms.TextBox wowFolderPathTextBox;
        private System.Windows.Forms.Label wowSelectLabel;
        private System.Windows.Forms.Label wowSelectNoteLabel;
        private System.Windows.Forms.Label backupSelectLabel;
        private System.Windows.Forms.TextBox backupFolderPathTextBox;
        private System.Windows.Forms.Button backupFolderButton;
        private System.Windows.Forms.CheckedListBox gameTypeCheckBoxList;
        private System.Windows.Forms.Label gameTypeLabel;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.ProgressBar copyingProgressBar;
        private System.Windows.Forms.CheckBox shouldSaveScreenshotsCheckbox;
    }
}
