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

            //Disable window
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            //Start up thread that will start the "FileJoin" thread and update the UI thread on its progress
            Thread monitoringJoinThread = new Thread(() => StartJoin(folderPath, outputDirectory, title, extension));
            monitoringJoinThread.Start();
        }

        private void StartJoin(string inputFolderPath, string outputFolderPath, string outputFileName, string outputExtension)
        {
            //Create FileMaster Instance
            FileMaster fileMasterInstance = new FileMaster();

            //Spin up thread to start joining the pieces
            Thread joinThread = new Thread(() => fileMasterInstance.FileJoin(inputFolderPath, outputFolderPath, outputFileName, outputExtension));
            Stopwatch timer = new Stopwatch();
            timer.Start();
            joinThread.Start();

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
                        progressCounter.Text = $"Pieces Joined: {currentNumFilesProcessed}/{fileMasterInstance.TotalFiles}";
                        progressBar.Value = 100*(int)(currentNumFilesProcessed/fileMasterInstance.TotalFiles);
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
                progressCounter.Text = $"JOIN COMPLETE! Took {timer.ElapsedMilliseconds} milliseconds.";
                this.Enabled = true;
                this.Cursor = Cursors.Default;
            });

            //Start joined file if user asked
            progressCounter.Invoke((MethodInvoker)delegate 
            {
                if (launchCheckBox.Checked)
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(Path.Join(outputFolderPath, $"{outputFileName}.{outputExtension}"))
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                }
            });
        }
    }
}
