/*
 * Created by: Tristan Royer
 * Created on: 19 - 11 - 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * This program takes the decimal given by the user and rounds it to the number of places the user wants.
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

namespace PassByRefTristanR
{
	public partial class numNumberOfPlaces : Form
	{
		public numNumberOfPlaces()
		{
			InitializeComponent();
		}
		//Procedure: RoundNumber
		//Input: ref txtNumber , int numberOfPlaces
		//Output: void
		//Description: This procedure takes the decimal given by the user and rounds it to the places that the user wants.
		public void RoundDecimal (ref double userDecimal , int numOfPlaces)
		{
			userDecimal = userDecimal * Math.Pow(10, numOfPlaces) ;
			userDecimal = userDecimal + 0.5;
			Math.Truncate (userDecimal);
			userDecimal = userDecimal / Math.Pow(10, numOfPlaces);

			MessageBox.Show("The Rounded Number is " + userDecimal, "RoundedNumber");

		}
		private void button1_Click(object sender, EventArgs e)
		{
			double decimalNumber;
			int numOfPlaces;

			decimalNumber = Convert.ToDouble(txtDecimal.Text);
			numOfPlaces = Convert.ToInt16(numNumOfPlaces.Value);
			this.RoundDecimal(ref decimalNumber, numOfPlaces);
		}
		
		private void txtDecimal_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
