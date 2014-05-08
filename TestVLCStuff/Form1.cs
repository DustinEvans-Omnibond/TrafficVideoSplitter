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
        private string videoFile;

        enum DaytimeTypes { Day, Night };
        enum ConditionTypes { Glare, Rain, Fog, Shaking, Distortion };
        enum SplitTypes { SP, PE };

        public Form1()
        {
            videoFile = "";

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
            positionDisplay.Text = GetTimeStringForDisplay(axVLCPlugin.input.Time) + " / " + GetTimeStringForDisplay(axVLCPlugin.input.Length);
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
                axVLCPlugin.playlist.playItem(0);
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
                positionDisplay.Text = GetTimeStringForDisplay(axVLCPlugin.input.Time) + " / " + GetTimeStringForDisplay(axVLCPlugin.input.Length);

                // Check if save location directory is correct 
                if (saveLocationBox.Text != "")
                {
                    try 
                    {
                        // Try to create the location directory
                        Directory.CreateDirectory(saveLocationBox.Text);

                        // Build rest of output path directories
                        string outputFilename = BuildOutputFileName(hhBox.Text, mmBox.Text, ssBox.Text, axVLCPlugin.input.Time, (spRadioButton.Checked ? SplitTypes.SP : SplitTypes.PE), GetFileExtension(videoFile));
                        string outputPath = BuildOutputPath(saveLocationBox.Text, outputFilename, (dayRadioButton.Checked ? DaytimeTypes.Day : DaytimeTypes.Night));
                        
                        // Split the video into two segments at the given time
                        // and save them in the output directory
                        SplitVideo(videoFile, outputPath, axVLCPlugin.input.Time, (spRadioButton.Checked ? SplitTypes.SP : SplitTypes.PE));
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                // Error
                MessageBox.Show("ERROR: Must have a video file loaded!");
            }
        }




        private string GetTimeString(double time)
        {
            string hours = TimeSpan.FromMilliseconds(time).Hours.ToString();
            string minutes = TimeSpan.FromMilliseconds(time).Minutes.ToString();
            string seconds = TimeSpan.FromMilliseconds(time).Seconds.ToString();

            if (hours.Length < 2)
                hours = "0" + hours;

            if (minutes.Length < 2)
                minutes = "0" + minutes;

            if (seconds.Length < 2)
                seconds = "0" + seconds;

            return (hours + minutes + seconds);
        }

        private string GetTimeStringForDisplay(double time)
        {
            TimeSpan interval = new TimeSpan(TimeSpan.FromMilliseconds(time).Hours, TimeSpan.FromMilliseconds(time).Minutes, TimeSpan.FromMilliseconds(time).Seconds);

            return interval.ToString();
        }

        private string GetFileExtension(string filepath)
        {
            string[] splitStrings = filepath.Split('.');
            

            return "." + splitStrings[splitStrings.Length - 1];
        }

        private string BuildOutputFileName(string milHours, string milMinutes, string milSeconds, double timePosition, SplitTypes splitType, string fileExtension)
        {
            string timeString = milHours + milMinutes + milSeconds;
            if (splitType == SplitTypes.PE)
            {
                // Add timePosition to military time
                TimeSpan militaryStartTime = new TimeSpan(Int32.Parse(milHours), Int32.Parse(milMinutes), Int32.Parse(milSeconds)); 
                TimeSpan positionTime = new TimeSpan(TimeSpan.FromMilliseconds(timePosition).Hours, TimeSpan.FromMilliseconds(timePosition).Minutes, TimeSpan.FromMilliseconds(timePosition).Seconds); 
                TimeSpan addedTime = militaryStartTime.Add(positionTime);

                // Parse time string
                string hours = addedTime.Hours.ToString();
                string minutes = addedTime.Minutes.ToString();
                string seconds = addedTime.Seconds.ToString();
                if (hours.Length < 2)
                    hours = "0" + hours;

                if (minutes.Length < 2)
                    minutes = "0" + minutes;

                if (seconds.Length < 2)
                    seconds = "0" + seconds;

                timeString = hours + minutes + seconds;
            }
            
            return timeString + fileExtension;
        }

        private string BuildOutputPath(string mainDirectory, string outputFilename, DaytimeTypes daytimeType)
        {
            // Check if mainDirectory has a \ at the end of it
            if (mainDirectory.IndexOf('\\', mainDirectory.Length - 1) < 0)
            {
                mainDirectory += "\\";
            }

            // Add daytimeType (Day\, Night\) to main directory
            mainDirectory += (daytimeType == DaytimeTypes.Day ? "Day\\" : "Night\\");

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

            return dirString + "\\";
        }

        private void SplitVideo(string inputPath, string outputPath, double timePosition, SplitTypes splitType)
        {
            string timeString = GetTimeString(timePosition);

            // Build command line arguments based on split type user selected, defaults to SplitTypes.SP
            string commandArgs = "/C ffmpeg -ss 00:00:00 -t " + timeString + " -i " + inputPath + " -c:v copy " + outputPath;
            //string commandArgs = "/C ffmpeg -i " + inputPath + " -ss 00:00:00 -t " + timeString + " -c:v copy " + outputPath;
            if (splitType == SplitTypes.PE)
            {
                //commandArgs = "/C ffmpeg -i " + inputPath + " -ss " + timeString + " -c:v copy " + outputPath;
                commandArgs = "/C ffmpeg -ss " + timeString + " -i " + inputPath + " -c:v copy " + outputPath;
            }
            
            // Do the split            
            Process.Start("cmd.exe", commandArgs);
        }
    }
}
