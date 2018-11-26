/*
 * Created by: Tristan Royer
 * Created on: 11 / 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program uses a procedure  to calculate the volume of a cylinder with the given values. 
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

namespace VolCylinderTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		// creates a function that calculates the volume of a cylinder with the given height and radius
		public double CalculateVolume (double height , double radius , ref double volume)
		{
			
			// calculates the volume and returns it.
			volume = Math.Round(Math.PI, 2) * Math.Pow(radius, 2) * height;
			return volume;


		}
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			// declare variables
			double theVolume = 0;
			double userHeight;
			double userRadius;
			// assign the values input by the user to the userRadius and userHeight
			userHeight = Convert.ToDouble(txtHeight.Text);
			userRadius = Convert.ToDouble(txtRadius.Text);
			// calls the CalculateVolume function
			CalculateVolume(userHeight, userRadius , ref  theVolume);
			// shows a message box with the volume of the cylinder.
			MessageBox.Show ("The Volume is:" + theVolume , "Volume");

	}
}
		}
