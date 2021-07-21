
namespace DiscordFileMaster
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.fileJoin = new System.Windows.Forms.Button();
            this.fileSplitter = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(73, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Discord Filemaster";
            // 
            // fileJoin
            // 
            this.fileJoin.Location = new System.Drawing.Point(73, 45);
            this.fileJoin.Name = "fileJoin";
            this.fileJoin.Size = new System.Drawing.Size(209, 29);
            this.fileJoin.TabIndex = 1;
            this.fileJoin.Text = "File Joiner";
            this.fileJoin.UseVisualStyleBackColor = true;
            this.fileJoin.Click += new System.EventHandler(this.fileJoin_Click);
            // 
            // fileSplitter
            // 
            this.fileSplitter.Location = new System.Drawing.Point(73, 80);
            this.fileSplitter.Name = "fileSplitter";
            this.fileSplitter.Size = new System.Drawing.Size(209, 29);
            this.fileSplitter.TabIndex = 2;
            this.fileSplitter.Text = "File Splitter";
            this.fileSplitter.UseVisualStyleBackColor = true;
            this.fileSplitter.Click += new System.EventHandler(this.fileSplitter_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(73, 115);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(209, 29);
            this.about.TabIndex = 3;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(73, 150);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(209, 29);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 195);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
            this.Controls.Add(this.fileSplitter);
            this.Controls.Add(this.fileJoin);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button fileJoin;
        private System.Windows.Forms.Button fileSplitter;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
    }
}

