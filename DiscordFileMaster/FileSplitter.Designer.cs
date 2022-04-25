
namespace DiscordFileMaster
{
    partial class FileSplitter
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
            this.splitButton = new System.Windows.Forms.Button();
            this.fileTextLabel = new System.Windows.Forms.Label();
            this.fileDirectoryBox = new System.Windows.Forms.TextBox();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.folderTextLabel = new System.Windows.Forms.Label();
            this.folderDirectoryBox = new System.Windows.Forms.TextBox();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitButton
            // 
            this.splitButton.Enabled = false;
            this.splitButton.Location = new System.Drawing.Point(442, 162);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(104, 29);
            this.splitButton.TabIndex = 0;
            this.splitButton.Text = "Split Files";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // fileTextLabel
            // 
            this.fileTextLabel.AutoSize = true;
            this.fileTextLabel.Location = new System.Drawing.Point(13, 13);
            this.fileTextLabel.Name = "fileTextLabel";
            this.fileTextLabel.Size = new System.Drawing.Size(107, 20);
            this.fileTextLabel.TabIndex = 1;
            this.fileTextLabel.Text = "File To Be Split";
            // 
            // fileDirectoryBox
            // 
            this.fileDirectoryBox.Location = new System.Drawing.Point(13, 37);
            this.fileDirectoryBox.Name = "fileDirectoryBox";
            this.fileDirectoryBox.ReadOnly = true;
            this.fileDirectoryBox.Size = new System.Drawing.Size(412, 27);
            this.fileDirectoryBox.TabIndex = 2;
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(442, 37);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(104, 29);
            this.fileSelectButton.TabIndex = 3;
            this.fileSelectButton.Text = "Select File";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // folderTextLabel
            // 
            this.folderTextLabel.AutoSize = true;
            this.folderTextLabel.Location = new System.Drawing.Point(13, 71);
            this.folderTextLabel.Name = "folderTextLabel";
            this.folderTextLabel.Size = new System.Drawing.Size(226, 20);
            this.folderTextLabel.TabIndex = 4;
            this.folderTextLabel.Text = "Folder For Split Files To Be Made";
            // 
            // folderDirectoryBox
            // 
            this.folderDirectoryBox.Location = new System.Drawing.Point(13, 95);
            this.folderDirectoryBox.Name = "folderDirectoryBox";
            this.folderDirectoryBox.ReadOnly = true;
            this.folderDirectoryBox.Size = new System.Drawing.Size(412, 27);
            this.folderDirectoryBox.TabIndex = 5;
            // 
            // folderSelectButton
            // 
            this.folderSelectButton.Location = new System.Drawing.Point(442, 93);
            this.folderSelectButton.Name = "folderSelectButton";
            this.folderSelectButton.Size = new System.Drawing.Size(104, 29);
            this.folderSelectButton.TabIndex = 6;
            this.folderSelectButton.Text = "Select Folder";
            this.folderSelectButton.UseVisualStyleBackColor = true;
            this.folderSelectButton.Click += new System.EventHandler(this.folderSelectButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 162);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(412, 29);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // progressCounter
            // 
            this.progressCounter.AutoSize = true;
            this.progressCounter.Location = new System.Drawing.Point(13, 139);
            this.progressCounter.Name = "progressCounter";
            this.progressCounter.Size = new System.Drawing.Size(534, 20);
            this.progressCounter.TabIndex = 8;
            this.progressCounter.Text = "Waiting.........................................................................." +
    "................................................................................" +
    "....";
            // 
            // FileSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 209);
            this.Controls.Add(this.progressCounter);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.folderSelectButton);
            this.Controls.Add(this.folderDirectoryBox);
            this.Controls.Add(this.folderTextLabel);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.fileDirectoryBox);
            this.Controls.Add(this.fileTextLabel);
            this.Controls.Add(this.splitButton);
            this.Name = "FileSplitter";
            this.Text = "File Splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Label fileTextLabel;
        private System.Windows.Forms.TextBox fileDirectoryBox;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.Label folderTextLabel;
        private System.Windows.Forms.TextBox folderDirectoryBox;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressCounter;
    }
}