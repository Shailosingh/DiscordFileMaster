using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FileMasterLibrary;

namespace DiscordFileMaster
{
    public partial class FileSplitter : Form
    {
        //Folder/File Select Tracker
        bool fileSelectFilled = false;
        bool folderSelectFilled = false;

        public FileSplitter()
        {
            InitializeComponent();
        }

        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDirectoryBox.Text = fileDialog.FileName;
                fileSelectFilled = true;

                if(fileSelectFilled == true && folderSelectFilled == true)
                {
                    splitButton.Enabled = true;
                }
            }
        }

        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderDirectoryBox.Text = folderDialog.SelectedPath;
                folderSelectFilled = true;

                if(folderSelectFilled == true && fileSelectFilled == true)
                {
                    splitButton.Enabled = true;
                }
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            //Clear progress bar
            progressBar.Value = 0;

            //Get file directory
            string filePath = fileDirectoryBox.Text;

            //Get folder directory
            string folderPath = folderDirectoryBox.Text;

            //Disable window
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            //Calculate piece size (8 MB for discord)
            int PIECE_SIZE = 8 * 1000 * 1000;

            //Start up thread that will start the "FileSplit" thread and update the UI thread on its progress
            Thread monitoringJoinThread = new Thread(() => StartSplit(filePath, folderPath, PIECE_SIZE));
            monitoringJoinThread.Start();
        }

        private void StartSplit(string inputFile, string outputFolder, int pieceSize)
        {
            //Start up FileMaster instance
            FileMaster fileMasterInstance = new FileMaster();

            //Spin up thread to start splitting up large files into several pieces
            Thread splitThread = new Thread(() => fileMasterInstance.FileSplit(inputFile, outputFolder, pieceSize));
            Stopwatch timer = new Stopwatch();
            timer.Start();
            splitThread.Start();

            //Uses "Invoke" to update user on the parameters being validated
            progressCounter.Invoke((MethodInvoker)delegate
            {
                progressBar.Maximum = 100;
                progressCounter.Text = "Validating...";
            });
            while (!fileMasterInstance.IsFinished && !fileMasterInstance.IsValidated) ;

            //Check for errors and exit
            if (fileMasterInstance.ExitError)
            {
                progressCounter.Invoke((MethodInvoker)delegate
                {
                    progressCounter.Text = $"ERROR: {fileMasterInstance.StatusMessage}";
                    this.Enabled = true;
                    this.Cursor = Cursors.Default;
                });
                return;
            }

            progressCounter.Invoke((MethodInvoker)delegate
            {
                progressCounter.Text = $"Total Number Of Pieces: {fileMasterInstance.TotalFiles}";
            });

            long currentNumFilesProcessed = 0;
            while (!fileMasterInstance.IsFinished)
            {
                //Check if the number of files processed has changed
                if (currentNumFilesProcessed != fileMasterInstance.NumFilesProcessed)
                {
                    currentNumFilesProcessed = fileMasterInstance.NumFilesProcessed;
                    progressCounter.Invoke((MethodInvoker)delegate
                    {
                        progressCounter.Text = $"Pieces Created: {currentNumFilesProcessed}/{fileMasterInstance.TotalFiles}";
                        progressBar.Value = 100 * (int)(currentNumFilesProcessed / fileMasterInstance.TotalFiles);
                    });
                }
            }

            //Check for errors and exit
            if (fileMasterInstance.ExitError)
            {
                progressCounter.Invoke((MethodInvoker)delegate
                {
                    progressCounter.Text = $"ERROR: {fileMasterInstance.StatusMessage}";
                    this.Enabled = true;
                    this.Cursor = Cursors.Default;
                });
                return;
            }

            //Split must be over
            timer.Stop();
            progressCounter.Invoke((MethodInvoker)delegate
            {
                progressCounter.Text = $"SPLIT COMPLETE! Took {timer.ElapsedMilliseconds} milliseconds.";
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            });
            Process.Start("explorer.exe", outputFolder);
        }

    }
}
