
namespace DiscordFileMaster
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.programmerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.nameEntry = new System.Windows.Forms.Label();
            this.programmerEntry = new System.Windows.Forms.Label();
            this.versionEntry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // programmerLabel
            // 
            this.programmerLabel.AutoSize = true;
            this.programmerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programmerLabel.Location = new System.Drawing.Point(12, 43);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Size = new System.Drawing.Size(103, 20);
            this.programmerLabel.TabIndex = 0;
            this.programmerLabel.Text = "Programmer:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.Location = new System.Drawing.Point(13, 72);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(69, 20);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version: ";
            // 
            // nameEntry
            // 
            this.nameEntry.AutoSize = true;
            this.nameEntry.Location = new System.Drawing.Point(122, 13);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(132, 20);
            this.nameEntry.TabIndex = 3;
            this.nameEntry.Text = "Discord Filemaster";
            // 
            // programmerEntry
            // 
            this.programmerEntry.AutoSize = true;
            this.programmerEntry.Location = new System.Drawing.Point(122, 43);
            this.programmerEntry.Name = "programmerEntry";
            this.programmerEntry.Size = new System.Drawing.Size(120, 20);
            this.programmerEntry.TabIndex = 4;
            this.programmerEntry.Text = "Shailendra Singh";
            // 
            // versionEntry
            // 
            this.versionEntry.AutoSize = true;
            this.versionEntry.Location = new System.Drawing.Point(122, 72);
            this.versionEntry.Name = "versionEntry";
            this.versionEntry.Size = new System.Drawing.Size(36, 20);
            this.versionEntry.TabIndex = 5;
            this.versionEntry.Text = "1.05";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 110);
            this.Controls.Add(this.versionEntry);
            this.Controls.Add(this.programmerEntry);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.programmerLabel);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programmerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label nameEntry;
        private System.Windows.Forms.Label programmerEntry;
        private System.Windows.Forms.Label versionEntry;
    }
}