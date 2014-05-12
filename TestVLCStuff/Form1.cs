﻿using System;
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
        private enum SplitTypes { SP, PE, MP };

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
        }
        
        void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            axVLCPlugin.MediaPlayerTimeChanged -= new AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEventHandler(axVLCPlugin_MediaPlayerTimeChanged);
        }



        void axVLCPlugin_MediaPlayerTimeChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEvent e)
        {
            UpdatePositionDisplay(axVLCPlugin.input.Time, axVLCPlugin.input.Length);
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
                if ((saveLocationBox.Text != "") && CheckMilitaryTime())
                {
                    try
                    {
                        // Try to create the location directory
                        Directory.CreateDirectory(saveLocationBox.Text);

                        // Build rest of output path directories
                        TimeDisplay milTime = new TimeDisplay(hhBox.Text, mmBox.Text, ssBox.Text);
                        TimeDisplay posTime = new TimeDisplay(axVLCPlugin.input.Time);
                        SplitTypes splitType = (spRadioButton.Checked ? SplitTypes.SP : (peRadioButton.Checked ? SplitTypes.PE : SplitTypes.MP));
                                                
                        string outputFilename = BuildOutputFileName(milTime, markedPosition, posTime, splitType, GetFileExtension(videoFile));
                        string outputPath = BuildOutputPath(saveLocationBox.Text, outputFilename, (dayRadioButton.Checked ? DaytimeTypes.Day : DaytimeTypes.Night));
                        
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
                    MessageBox.Show("ERROR: Make sure that output directory and military time is correct!");
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

        private bool CheckMilitaryTime()
        {
            bool correct = false;
            try
            {
                correct = ((hhBox.Text != "" && mmBox.Text != "" && ssBox.Text != "") && (Int32.Parse(hhBox.Text) < 24 && Int32.Parse(hhBox.Text) >= 0) && (Int32.Parse(mmBox.Text) < 60 && Int32.Parse(mmBox.Text) >= 0) && (Int32.Parse(ssBox.Text) < 60 && Int32.Parse(ssBox.Text) >= 0));
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

        private string BuildOutputFileName(TimeDisplay militaryTime, TimeDisplay markedTime, TimeDisplay currentTime, SplitTypes splitType, string fileExtension)
        {            
            if (splitType == SplitTypes.PE)
            {
                TimeDisplay total = militaryTime + currentTime;
                return total.ToString('C') + fileExtension;
            }
            else if (splitType == SplitTypes.MP)
            {
                if (currentTime.Compare(markedTime) >= 0)
                {
                    TimeDisplay markedTotal = militaryTime + markedTime;
                    return markedTotal.ToString('C') + fileExtension;
                }
                else
                {
                    TimeDisplay currentTotal = militaryTime + currentTime;
                    return currentTotal.ToString('C') + fileExtension;
                }
            }

            return militaryTime.ToString('C') + fileExtension;
        }

        private string BuildOutputPath(string mainDirectory, string outputFilename, DaytimeTypes daytimeType)
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

            // Create the actual directory
            try { Directory.CreateDirectory(mainDirectory); }
            catch { }

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

                StreamWriter file = File.AppendText(directory + logFilename); //new StreamWriter(directory + logFilename);
                file.WriteLine("Input: " + inputPath);
                file.WriteLine("Output: " + outputPath);
                file.WriteLine("-------------------------------------------------------");
                file.Close();
            }
            catch { }
        }

       
    }
}
