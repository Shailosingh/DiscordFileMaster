using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

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

            //Verify file and folder  paths
            if(File.Exists(filePath))
            {
                if(Directory.Exists(folderPath))
                {
                    //CONSTANTS
                    long BYTES_IN_8MEGS = 8 * 1000 * 1000;

                    //Get file info
                    FileInfo fi = new FileInfo(filePath);
                    long fileSize = fi.Length;

                    //Get number of files to be made
                    long numberOfFiles = fileSize / BYTES_IN_8MEGS;
                    if (fileSize % BYTES_IN_8MEGS != 0 || fileSize == 0)
                    {
                        numberOfFiles++;
                    }

                    //Set maximum for progress bar
                    progressBar.Maximum = (int)numberOfFiles;

                    //Cycle through bytes of file
                    long fileIndex = 0;
                    int fileNameLength = (int)Math.Ceiling(Math.Log10(numberOfFiles));
                    string outFilePath = @$"{folderPath}\{fileIndex.ToString().PadLeft(fileNameLength, '0')}.piece"; //Pads 0s to the left to ensure alphabetical order is same as numeric
                    int currentByte = 0;
                    long bytesInFile = BYTES_IN_8MEGS;
                    using (FileStream fs = File.OpenRead(filePath))
                    {
                        while (fileIndex < numberOfFiles)
                        {
                            byteCounter.Text = $"File {fileIndex}";
                            using (FileStream outStream = new FileStream(outFilePath, FileMode.Create))
                            {
                                if (fileIndex == numberOfFiles - 1)
                                {
                                    bytesInFile = fileSize % BYTES_IN_8MEGS;
                                }

                                for (int index = 0; index < bytesInFile; index++)
                                {
                                    currentByte = fs.ReadByte();
                                    outStream.WriteByte((byte)currentByte);
                                }
                            }

                            fileIndex++;
                            outFilePath = @$"{folderPath}\{fileIndex.ToString().PadLeft(fileNameLength, '0')}.piece";
                            progressBar.Increment(1);

                        }
                    }

                    //Send completion message and open folder location
                    byteCounter.Text = "Complete!";
                    System.Diagnostics.Process.Start("explorer.exe", folderPath);
                }

                else
                {
                    byteCounter.Text = "Folder Does Not Exist";
                }
            }

            else
            {
                byteCounter.Text = "File Does Not Exist";
            }
        }
    }
}
