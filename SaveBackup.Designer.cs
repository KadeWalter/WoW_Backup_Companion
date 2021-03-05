
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wowSelectLabel = new System.Windows.Forms.Label();
            this.wowSelectNoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wowFolderButton
            // 
            this.wowFolderButton.Location = new System.Drawing.Point(820, 175);
            this.wowFolderButton.Name = "wowFolderButton";
            this.wowFolderButton.Size = new System.Drawing.Size(27, 23);
            this.wowFolderButton.TabIndex = 0;
            this.wowFolderButton.Text = ">";
            this.wowFolderButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(802, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
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
            this.wowSelectNoteLabel.Location = new System.Drawing.Point(12, 199);
            this.wowSelectNoteLabel.Name = "wowSelectNoteLabel";
            this.wowSelectNoteLabel.Size = new System.Drawing.Size(122, 15);
            this.wowSelectNoteLabel.TabIndex = 3;
            this.wowSelectNoteLabel.Text = "wowSelectNoteLabel";
            // 
            // SaveBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::WoW_Backup_Companion.Properties.Resources.wow_torghast;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 627);
            this.Controls.Add(this.wowSelectNoteLabel);
            this.Controls.Add(this.wowSelectLabel);
            this.Controls.Add(this.wowFolderButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaveBackup";
            this.Text = "WoW Backup Companion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wowFolderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label wowSelectLabel;
        private System.Windows.Forms.Label wowSelectNoteLabel;
    }
}
