﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DiscordFileMaster
{
    public partial class FileJoiner : Form
    {
        //Select Tracker
        bool inputSelectFilled = false;
        bool outputSelectFilled = false;

        public FileJoiner()
        {
            InitializeComponent();
        }

        private void inputSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                inputDirectoryBox.Text = folderDialog.SelectedPath;
                inputSelectFilled = true;

                if (inputSelectFilled == true && outputSelectFilled == true)
                {
                    joinButton.Enabled = true;
                }
            }
        }

        private void outputSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                outputDirectoryBox.Text = folderDialog.SelectedPath;
                outputSelectFilled = true;

                if (inputSelectFilled == true && outputSelectFilled == true)
                {
                    joinButton.Enabled = true;
                }
            }
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            //Default progress bar to zero
            progressBar.Value = 0;

            //Initialize variables
            string folderPath = inputDirectoryBox.Text;
            string outputDirectory = outputDirectoryBox.Text;
            string title = filenameBox.Text;
            string extension = extensionBox.Text;

            //Verify input and output paths
            if (Directory.Exists(folderPath))
            {
                if (Directory.Exists(outputDirectory))
                {
                    //Get list of files in folder
                    string[] files = Directory.GetFiles(folderPath, "*.piece");

                    //Set max of progress bar
                    progressBar.Maximum = files.Length;

                    //Get potential output path
                    string outputPath = @$"{outputDirectory}\{title}.{extension}";

                    try
                    {
                        //Cycle through each file and write to new output file
                        FileInfo fi;
                        long fileSize;
                        int currentByte;
                        using (FileStream outStream = new FileStream(outputPath, FileMode.Create))
                        {
                            foreach (string fileDirectory in files)
                            {
                                progressCounter.Text = fileDirectory;
                                fi = new FileInfo(fileDirectory);
                                fileSize = fi.Length;

                                using (FileStream fs = File.OpenRead(fileDirectory))
                                {
                                    for (int index = 0; index < fileSize; index++)
                                    {
                                        currentByte = fs.ReadByte();
                                        outStream.WriteByte((byte)currentByte);
                                    }

                                }

                                progressBar.Increment(1);
                            }
                        }

                        //Signal completion of join
                        progressCounter.Text = "Complete";
                        Process.Start("explorer.exe", outputDirectory);
                        if(launchCheckBox.Checked)
                        {
                            var p = new Process();
                            p.StartInfo = new ProcessStartInfo(outputPath)
                            {
                                UseShellExecute = true
                            };
                            p.Start();
                        }
                    }

                    catch
                    {
                        progressCounter.Text = "Invalid Filename";
                    }
                }
            }
        }
    }
}