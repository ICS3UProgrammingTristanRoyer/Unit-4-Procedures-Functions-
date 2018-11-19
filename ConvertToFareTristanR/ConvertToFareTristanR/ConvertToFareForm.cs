/*
 * Created by: Tristan Royer
 * Created on: 15 - 11 - 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - ConvertToFare
 * This program calculates the degrees Farenheight using the degrees celsius given by the user.
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

namespace ConvertToFareTristanR
{
	public partial class ConvertToFareForm : Form
	{
		public ConvertToFareForm()
		{
			InitializeComponent();
		}
		
		// Function: ConvertToFarenheight
		// Input: int celsius
		// Output: void
		// Description: This function takes the length and width passed by the value and displays a message box with the calculated area of the triangle.
		public void ConvertToFarenheight(int celsius)
		{
			//declare local variables
			double farenheight;

			// calculate the farengeight with the given celsius.
			farenheight = ((double)9 /(double) 5) * celsius + 32;

			// display a message box with the calculated area
			MessageBox.Show("The temperature in Farenheight:" + farenheight + " degrees" , "Farenheight Converter");
        }


		private void button1_Click(object sender, EventArgs e)
		{
			// declare local variables
			int userCelsius;

			// convert the input from  a string to an int and assign it to "userCelcius"
			userCelsius = Convert.ToInt32(txtCelsius.Text);

			// call the function to calculate the farenheight passing the userCelcius arguments by value
			this.ConvertToFarenheight(userCelsius);

		}
	}
}
