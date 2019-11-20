/*
 * Created by: Tobi Adebayo
 * Created on: 2019-11-20
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Dynamic Picture Box Creation & Click Events
 * This program creates 4 picture boxes that displays a picture frame by frame to make it look like it's walking when they are clicked on
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DynamicPictureBoxClickEvents
{
    public partial class frmDynamicPictureBoxCreationAndClickEvents : Form
    {
        public frmDynamicPictureBoxCreationAndClickEvents()
        {
            InitializeComponent();
            //Hide the instructions label
            this.lblInstructions.Hide();
        }

        private void GeneratePictureBoxes()
        {
            //Generate the picture boxes
            GeneratePictureBoxes(61, 78);
            GeneratePictureBoxes(464, 78);
            GeneratePictureBoxes(61, 358);
            GeneratePictureBoxes(464, 358);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //show the label
            this.lblInstructions.Show();

            //generate the picture boxes with their event listeners
            GeneratePictureBoxes();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            //Cast the sender object into a Picture box
            PictureBox tmpPicMan = (PictureBox)sender;

            // White a message to the console to check which picture box was clicked
            Console.WriteLine("Picture Box (" + tmpPicMan.Location.X + " , " + tmpPicMan.Location.Y + ") was clicked.");

            //Declare local variable and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // Continue this loop while the frame counter has not reached the max number of frames we have to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }

                // Increment the counter
                pictureFrameCounter = pictureFrameCounter + 1;

                // refresh the form
                this.Refresh();

                // pause the loop for 100 milliseconds
                Thread.Sleep(100);
            }
        }

        private void GeneratePictureBoxes(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location (x,y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // Set the location of the picture box
            tmpPicMan.Location = pntPic;

            // ASsign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            //Stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // Make the picture box width and height to be the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // Add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // Add the picture box to the form
            this.Controls.Add(tmpPicMan);


        }
    }
}
