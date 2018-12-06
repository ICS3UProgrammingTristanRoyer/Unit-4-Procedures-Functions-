/*
 * Created by: Tristan Royer
 * Created on: 29-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Name of Program
 * This program this creates picture boxes during runtime and allows the user to click on them to make them change.
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

namespace NewWalkingTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{

			InitializeComponent();
			this.lblInstructions.Hide();


		}

		private void GeneratePictureBoxes()
		{
			// generate each of the picture boxes on the form.

			GeneratePictureBox(61, 78);
			GeneratePictureBox(464, 78);
			GeneratePictureBox(61, 358);
			GeneratePictureBox(464, 358);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			// reveal the instructions
			this.lblInstructions.Show();

			// generate the picture boxes with their event listeners.
			GeneratePictureBoxes();

		}

		private void GeneratePictureBox(int x , int y)
		{
			// dynamically generate a new picture box and a new point at the given location
			PictureBox tmpPicMan = new PictureBox();
			Point pntPic = new System.Drawing.Point(x, y);

			// set the location of the picture box.
			tmpPicMan.Location = pntPic;

			// assign the image to the picture box
			tmpPicMan.Image = Properties.Resources.walk1;

			// stretch the image to the size of the picture box
			tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

			// make the picture box width and height to be the same as the image.
			tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

			// add the event listener
			tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

			// add the picture box to the form
			this.Controls.Add(tmpPicMan);
		}
		private void PictureBox_Click(object sender , EventArgs e)
		{
			// cast the sender object into a Picture  Box
			PictureBox tmpPicMan = (PictureBox)sender;

			// write a message to the console to check which picture box was clicked
			Console.WriteLine("Picture box (" + tmpPicMan.Location.X + " ," + tmpPicMan.Location.Y + ") was clicked.");

			// declare local variables and constants
			const byte MAX_FRAMES = 10;
			int pictureFrameCounter = 1;

			// continue this loop while the frame counter has not reached the max number of frames we have to display
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

				pictureFrameCounter = pictureFrameCounter + 1;
				this.Refresh();
				Thread.Sleep(100);
			}
	}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
