
namespace DiscordFileMaster
{
    partial class FileJoiner
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
            this.inputTextLabel = new System.Windows.Forms.Label();
            this.joinButton = new System.Windows.Forms.Button();
            this.inputDirectoryBox = new System.Windows.Forms.TextBox();
            this.inputSelectButton = new System.Windows.Forms.Button();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.extensionBox = new System.Windows.Forms.TextBox();
            this.outputTextLabel = new System.Windows.Forms.Label();
            this.outputDirectoryBox = new System.Windows.Forms.TextBox();
            this.outputSelectButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressCounter = new System.Windows.Forms.Label();
            this.launchCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // inputTextLabel
            // 
            this.inputTextLabel.AutoSize = true;
            this.inputTextLabel.Location = new System.Drawing.Point(13, 13);
            this.inputTextLabel.Name = "inputTextLabel";
            this.inputTextLabel.Size = new System.Drawing.Size(207, 20);
            this.inputTextLabel.TabIndex = 0;
            this.inputTextLabel.Text = "Folder With Files To Be Linked";
            // 
            // joinButton
            // 
            this.joinButton.Enabled = false;
            this.joinButton.Location = new System.Drawing.Point(495, 220);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(108, 29);
            this.joinButton.TabIndex = 1;
            this.joinButton.Text = "Join Button";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // inputDirectoryBox
            // 
            this.inputDirectoryBox.Location = new System.Drawing.Point(13, 37);
            this.inputDirectoryBox.Name = "inputDirectoryBox";
            this.inputDirectoryBox.ReadOnly = true;
            this.inputDirectoryBox.Size = new System.Drawing.Size(467, 27);
            this.inputDirectoryBox.TabIndex = 2;
            // 
            // inputSelectButton
            // 
            this.inputSelectButton.Location = new System.Drawing.Point(495, 37);
            this.inputSelectButton.Name = "inputSelectButton";
            this.inputSelectButton.Size = new System.Drawing.Size(108, 29);
            this.inputSelectButton.TabIndex = 3;
            this.inputSelectButton.Text = "Select Input";
            this.inputSelectButton.UseVisualStyleBackColor = true;
            this.inputSelectButton.Click += new System.EventHandler(this.inputSelectButton_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(13, 125);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(103, 20);
            this.filenameLabel.TabIndex = 4;
            this.filenameLabel.Text = "New Filename";
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(13, 148);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(249, 27);
            this.filenameBox.TabIndex = 5;
            // 
            // extensionLabel
            // 
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(275, 125);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(106, 20);
            this.extensionLabel.TabIndex = 6;
            this.extensionLabel.Text = "New Extension";
            // 
            // extensionBox
            // 
            this.extensionBox.Location = new System.Drawing.Point(275, 148);
            this.extensionBox.Name = "extensionBox";
            this.extensionBox.Size = new System.Drawing.Size(328, 27);
            this.extensionBox.TabIndex = 7;
            // 
            // outputTextLabel
            // 
            this.outputTextLabel.AutoSize = true;
            this.outputTextLabel.Location = new System.Drawing.Point(13, 71);
            this.outputTextLabel.Name = "outputTextLabel";
            this.outputTextLabel.Size = new System.Drawing.Size(101, 20);
            this.outputTextLabel.TabIndex = 8;
            this.outputTextLabel.Text = "Output Folder";
            // 
            // outputDirectoryBox
            // 
            this.outputDirectoryBox.Location = new System.Drawing.Point(13, 95);
            this.outputDirectoryBox.Name = "outputDirectoryBox";
            this.outputDirectoryBox.ReadOnly = true;
            this.outputDirectoryBox.Size = new System.Drawing.Size(467, 27);
            this.outputDirectoryBox.TabIndex = 9;
            // 
            // outputSelectButton
            // 
            this.outputSelectButton.Location = new System.Drawing.Point(495, 95);
            this.outputSelectButton.Name = "outputSelectButton";
            this.outputSelectButton.Size = new System.Drawing.Size(108, 29);
            this.outputSelectButton.TabIndex = 10;
            this.outputSelectButton.Text = "Select Output";
            this.outputSelectButton.UseVisualStyleBackColor = true;
            this.outputSelectButton.Click += new System.EventHandler(this.outputSelectButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 220);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(476, 29);
            this.progressBar.TabIndex = 11;
            // 
            // progressCounter
            // 
            this.progressCounter.AutoSize = true;
            this.progressCounter.Location = new System.Drawing.Point(13, 189);
            this.progressCounter.Name = "progressCounter";
            this.progressCounter.Size = new System.Drawing.Size(69, 20);
            this.progressCounter.TabIndex = 12;
            this.progressCounter.Text = "Waiting...";
            // 
            // launchCheckBox
            // 
            this.launchCheckBox.AutoSize = true;
            this.launchCheckBox.Checked = true;
            this.launchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.launchCheckBox.Location = new System.Drawing.Point(400, 188);
            this.launchCheckBox.Name = "launchCheckBox";
            this.launchCheckBox.Size = new System.Drawing.Size(203, 24);
            this.launchCheckBox.TabIndex = 13;
            this.launchCheckBox.Text = "Launch file on completion";
            this.launchCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileJoiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 261);
            this.Controls.Add(this.launchCheckBox);
            this.Controls.Add(this.progressCounter);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputSelectButton);
            this.Controls.Add(this.outputDirectoryBox);
            this.Controls.Add(this.outputTextLabel);
            this.Controls.Add(this.extensionBox);
            this.Controls.Add(this.extensionLabel);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.inputSelectButton);
            this.Controls.Add(this.inputDirectoryBox);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.inputTextLabel);
            this.Name = "FileJoiner";
            this.Text = "FileJoiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputTextLabel;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.TextBox inputDirectoryBox;
        private System.Windows.Forms.Button inputSelectButton;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.TextBox extensionBox;
        private System.Windows.Forms.Label outputTextLabel;
        private System.Windows.Forms.TextBox outputDirectoryBox;
        private System.Windows.Forms.Button outputSelectButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressCounter;
        private System.Windows.Forms.CheckBox launchCheckBox;
    }
}