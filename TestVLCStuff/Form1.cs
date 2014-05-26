using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using AXVLC;

namespace TrafficVideoSplitter
{
    public partial class Form1 : Form
    {
        private string logFilename = "TrafficVideoSplitterLog.txt";
        private string videoFile;
        private TimeDisplay markedPosition;


        private enum DaytimeTypes { Day, Night };
        private enum SplitTypes { SP, PE, MP, SM };

        public Form1()
        {
            videoFile = "";
            markedPosition = new TimeDisplay(0);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axVLCPlugin.playlist.items.clear();
            
            axVLCPlugin.MediaPlayerTimeChanged += new AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEventHandler(axVLCPlugin_MediaPlayerTimeChanged);
            axVLCPlugin.MediaPlayerPaused += new EventHandler(axVLCPlugin_MediaPlayerPaused);

            // Set default values for starting date and time
            DateTime current = DateTime.Now;
            yearTextBox.Text = current.ToString("yyyy");
            monthTextBox.Text = current.ToString("MM");
            dayTextBox.Text = current.ToString("dd");
            hhBox.Text = current.ToString("HH");
            mmBox.Text = current.ToString("mm");
            ssBox.Text = current.ToString("ss");
        }      
        
        void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            axVLCPlugin.MediaPlayerTimeChanged -= new AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEventHandler(axVLCPlugin_MediaPlayerTimeChanged);
        }



        void axVLCPlugin_MediaPlayerTimeChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEvent e)
        {
            UpdatePositionDisplay(axVLCPlugin.input.Time, axVLCPlugin.input.Length);
        }

        void axVLCPlugin_MediaPlayerPaused(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                // Clear previous playlist
                axVLCPlugin.playlist.items.clear();

                // Store filename and display it
                videoFile = ofd.FileName;
                fileDisplay.Text = videoFile;
                
                // Add video file to playlist and start playing
                axVLCPlugin.playlist.add("file:///" + videoFile);
                UpdateMarkedDisplay(0, axVLCPlugin.input.Length);
                UpdatePositionDisplay(0, axVLCPlugin.input.Length);
                axVLCPlugin.playlist.playItem(0);
                
                if (formatCheckBox.Checked)
                {
                    ParseDateTime(videoFile);
                }

                UpdateOuputFilePathLabel();
            }
        }

        private void markButton_Click(object sender, EventArgs e)
        {
            if ((videoFile != "") && (axVLCPlugin.playlist.items.count > 0))
            {
                // Pause the video
                axVLCPlugin.playlist.pause();

                // Update the marked position display and stored variable
                UpdateMarkedDisplay(axVLCPlugin.input.Time, axVLCPlugin.input.Length);

                UpdateOuputFilePathLabel();
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            // Make sure that there's a video file loaded
            if ((videoFile != "") && (axVLCPlugin.playlist.items.count > 0))
            {
                // Pause the video
                axVLCPlugin.playlist.pause();

                // Get and display time position
                UpdatePositionDisplay(axVLCPlugin.input.Time, axVLCPlugin.input.Length);

                // Check if save location directory path and military time is correct 
                if ((saveLocationBox.Text != "") && CheckStartingDateTime())
                {
                    try
                    {
                        // Try to create the location directory
                        Directory.CreateDirectory(saveLocationBox.Text);

                        // Build rest of output path directories
                        int year = Int32.Parse(yearTextBox.Text);
                        int month = Int32.Parse(monthTextBox.Text);
                        int day = Int32.Parse(dayTextBox.Text);
                        int hours = Int32.Parse(hhBox.Text);
                        int minutes = Int32.Parse(mmBox.Text);
                        int seconds = Int32.Parse(ssBox.Text);
                        DateTime startingDateTime = new DateTime(year, month, day, hours, minutes, seconds);
                        
                        TimeDisplay posTime = new TimeDisplay(axVLCPlugin.input.Time);
                        SplitTypes splitType = (spRadioButton.Checked ? SplitTypes.SP : (peRadioButton.Checked ? SplitTypes.PE : (mpRadioButton.Checked ? SplitTypes.MP : SplitTypes.SM)));

                        string outputFilename = BuildOutputFileName(startingDateTime, markedPosition.GetTimeSpan(), posTime.GetTimeSpan(), splitType, GetFileExtension(videoFile));
                        string outputPath = BuildOutputPath(saveLocationBox.Text, outputFilename, (dayRadioButton.Checked ? DaytimeTypes.Day : DaytimeTypes.Night), true);
                        
                        // Split the video into two segments at the given time
                        // and save them in the output directory
                        SplitVideo(videoFile, outputPath, markedPosition, posTime, splitType);
                        WriteToLog(saveLocationBox.Text, videoFile, outputPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Make sure that output directory and starting date/time is correct!");
                }
            }
            else
            {
                // Error
                MessageBox.Show("ERROR: Must have a video file loaded!");
            }
        }

        private void UpdateMarkedDisplay(double msCurrentTime, double msTotalTime)
        {
            markedPosition = new TimeDisplay(msCurrentTime);
            TimeDisplay total = new TimeDisplay(msTotalTime);
            markedDisplay.Text = markedPosition.ToString() + " / " + total.ToString();
        }

        private void UpdatePositionDisplay(double msCurrentTime, double msTotalTime)
        {
            TimeDisplay current = new TimeDisplay(msCurrentTime);
            TimeDisplay total = new TimeDisplay(msTotalTime);
            positionDisplay.Text = current.ToString() + " / " + total.ToString();
        }

        private bool CheckStartingDateTime()
        {
            bool correct = false;
            try
            {
                int year = Int32.Parse(yearTextBox.Text);
                int month = Int32.Parse(monthTextBox.Text);
                int day = Int32.Parse(dayTextBox.Text);
                int hours = Int32.Parse(hhBox.Text);
                int minutes = Int32.Parse(mmBox.Text);
                int seconds = Int32.Parse(ssBox.Text);
                correct = ((hhBox.Text != "" && mmBox.Text != "" && ssBox.Text != "") && (yearTextBox.Text != "" && monthTextBox.Text != "" && dayTextBox.Text != "") && (year < 10000 && year > 0) && (month < 13 && month > 0) && (day < 32 && day > 0) && (hours < 24 && hours >= 0) && (minutes < 60 && minutes >= 0) && (seconds < 60 && seconds >= 0));
               
                return correct;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string GetFileExtension(string filepath)
        {
            string[] splitStrings = filepath.Split('.');
            

            return "." + splitStrings[splitStrings.Length - 1];
        }

        private string BuildOutputFileName(DateTime startingTime, TimeSpan markedPos, TimeSpan currentPos, SplitTypes splitType, string fileExtension)
        {
            if (splitType == SplitTypes.PE)
            {
                DateTime total = startingTime.Add(currentPos);
                return total.ToString("yyyyMMdd_HHmmss") + fileExtension;
            }
            else if (splitType == SplitTypes.MP)
            {
                TimeSpan compareTimeSpan = new TimeSpan(startingTime.Hour, startingTime.Minute, startingTime.Second);
                if (compareTimeSpan.CompareTo(markedPos) >= 0)
                {
                    DateTime total = startingTime.Add(markedPos);
                    return total.ToString("yyyyMMdd_HHmmss") + fileExtension;
                }
                else
                {
                    DateTime total = startingTime.Add(currentPos);
                    return total.ToString("yyyyMMdd_HHmmss") + fileExtension;
                }
            }

            return startingTime.ToString("yyyyMMdd_HHmmss") + fileExtension;
        }
        
        private string BuildOutputPath(string mainDirectory, string outputFilename, DaytimeTypes daytimeType, bool makeDirectory)
        {
            // Check if mainDirectory has a \ at the end of it
            if (mainDirectory.IndexOf('\\', mainDirectory.Length - 1) < 0)
            {
                mainDirectory += "\\";
            }

            // Add daytimeType (Day\, Night\) to main directory
            mainDirectory += (daytimeType == DaytimeTypes.Day ? "Day" : "Night");
            mainDirectory += viewTextBox.Text + "\\";

            // Create next directory given conditions
            mainDirectory += BuildConditionsDirectory();

            // Create the actual directory if needed
            if (makeDirectory)
            {
                try { Directory.CreateDirectory(mainDirectory); }
                catch { }
            }

            // Add outputFilename
            mainDirectory += outputFilename;

            return mainDirectory;
        }

        private string BuildConditionsDirectory()
        {
            CheckBox[] checkBoxes = { glareCheckBox, rainCheckBox, fogCheckBox, shakeCheckBox, distortionCheckBox };
            string dirString = "";

            if (checkBoxes[0].Checked)
            {
                dirString += "_Glare";
            }

            if (checkBoxes[1].Checked)
            {
                dirString += "_Rain";
            }

            if (checkBoxes[2].Checked)
            {
                dirString += "_Fog";
            }

            if (checkBoxes[3].Checked)
            {
                dirString += "_Shaking";
            }

            if (checkBoxes[4].Checked)
            {
                dirString += "_Distortion";
            }

            return (dirString == "" ? "" : dirString + "\\");
        }

        private void SplitVideo(string inputPath, string outputPath, TimeDisplay markedPos, TimeDisplay position, SplitTypes splitType)
        {
            // Build command line arguments based on split type user selected, defaults to SplitTypes.SP
            string commandArgs = "";
            switch (splitType)
            {
                case SplitTypes.SP:
                    commandArgs = "/C ffmpeg -ss 00:00:00 -t " + position.ToString() + " -i " + inputPath + " -c:v copy " + outputPath;
                break;

                case SplitTypes.PE:
                    commandArgs = "/C ffmpeg -ss " + position.ToString() + " -i " + inputPath + " -c:v copy " + outputPath;
                break;

                case SplitTypes.MP:
                    if (position.Compare(markedPos) >= 0)
                    {
                        commandArgs = "/C ffmpeg -i " + inputPath + " -ss " + markedPos.ToString() + " -to " + position.ToString() + " -c:v copy " + outputPath;
                    }
                    else
                    {
                        // Switch the marked and postion times since the marked position it greater than the current position
                        commandArgs = "/C ffmpeg -i " + inputPath + " -ss " + position.ToString() + " -to " + markedPos.ToString() + " -c:v copy " + outputPath;
                    }
                break;

                case SplitTypes.SM:
                    commandArgs = "/C ffmpeg -ss 00:00:00 -t " + markedPos.ToString() + " -i " + inputPath + " -c:v copy " + outputPath;
                break;

                default:
                    commandArgs = "/C ffmpeg -ss 00:00:00 -t " + position.ToString() + " -i " + inputPath + " -c:v copy " + outputPath;
                break;
            }

            // Do the split            
            Process.Start("cmd.exe", commandArgs);
        }

        private void WriteToLog(string directory, string inputPath, string outputPath)
        {
            try
            {
                // Check if mainDirectory has a \ at the end of it
                if (directory.IndexOf('\\', directory.Length - 1) < 0)
                {
                    directory += "\\";
                }

                StreamWriter file = File.AppendText(directory + logFilename);
                file.WriteLine("Input: " + inputPath);
                file.WriteLine("Output: " + outputPath);
                file.WriteLine("-------------------------------------------------------");
                file.Close();
            }
            catch { }
        }

        private void ParseDateTime(string filepath)
        {
            try
            {
                // Get the filename from the directory filepath
                string[] sFilepath = filepath.Split('\\');
                string filename = sFilepath[sFilepath.Length - 1].Split('.')[0];
                
                // Parse the date/time from the filename and put it in the text boxes
                string date = filename.Split('_')[0];
                string time = filename.Split('_')[1];
                
                string year = date.Substring(0, 4);
                string month = date.Substring(4, 2);
                string day = date.Substring(6, 2);

                string hours = time.Substring(0, 2);
                string minutes = time.Substring(2, 2);
                string seconds = time.Substring(4, 2);
                
                yearTextBox.Text = year; 
                monthTextBox.Text = month; 
                dayTextBox.Text = day;
                hhBox.Text = hours; 
                mmBox.Text = minutes; 
                ssBox.Text = seconds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't parse the date or time!");
            }
        }


        private void UpdateOuputFilePathLabel()
        {
            try
            {
                // Build rest of output path directories
                int year = Int32.Parse(yearTextBox.Text);
                int month = Int32.Parse(monthTextBox.Text);
                int day = Int32.Parse(dayTextBox.Text);
                int hours = Int32.Parse(hhBox.Text); 
                int minutes = Int32.Parse(mmBox.Text);
                int seconds = Int32.Parse(ssBox.Text);
                DateTime startingDateTime = new DateTime(year, month, day, hours, minutes, seconds);
                
                TimeDisplay posTime = new TimeDisplay(axVLCPlugin.input.Time);
                SplitTypes splitType = (spRadioButton.Checked ? SplitTypes.SP : (peRadioButton.Checked ? SplitTypes.PE : (mpRadioButton.Checked ? SplitTypes.MP : SplitTypes.SM)));

                string outputFilename = BuildOutputFileName(startingDateTime, markedPosition.GetTimeSpan(), posTime.GetTimeSpan(), splitType, GetFileExtension(videoFile));
                string outputPath = BuildOutputPath(saveLocationBox.Text, outputFilename, (dayRadioButton.Checked ? DaytimeTypes.Day : DaytimeTypes.Night), false);

                outputFileLabel.Text = outputPath;
            }
            catch (Exception ex)
            {

            }
        }

        private void formatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void saveLocationBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void monthTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void dayTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void hhBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void mmBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void ssBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void viewTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void dayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void nightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void glareCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void rainCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void fogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void shakeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void distortionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void spRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void peRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        private void mpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOuputFilePathLabel();
        }

        

       
    }
}
