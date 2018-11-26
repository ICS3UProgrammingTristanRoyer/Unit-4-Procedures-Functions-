/*
 * Created by: Tristan  Royer
 * Created on: 11 / 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program takes the partial level given by the user and displays the appropriate percentage.
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

namespace PercentProgramTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private int ConvertToPercent(String mark)
		{
			// declare variable
			int percentage;

			// uses the cases function which checks the level the user entered and displays the appropriate percentage
			switch (mark)
			{

				case "4++":
					percentage = 98;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					// breaks the cases preventing it from continuing if the answer is found.
					break;

				case "4+":
					percentage = 95;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "4":
					percentage = 87;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "4-":
					percentage = 83;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "3+":
					percentage = 78;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "3":
					percentage = 75;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "3-":
					percentage = 72;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "2+":
					percentage = 68;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "2":
					percentage = 68;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "2-":
					percentage = 68;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "1+":
					percentage = 58;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "1":
					percentage = 55;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "1-":
					percentage = 52;
					break;

				case "0+":
					percentage = 45;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "0":
					percentage = 40;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "0-":
					percentage = 35;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "0--":
					percentage = 30;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "0---":
					percentage = 20;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				case "0----":
					percentage = 10;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

				default:
					percentage = -1;
					MessageBox.Show("The Percentage is:" + percentage, "PercentMark");
					break;

			}
			// returns the percentage
			return percentage;

			





			}

		

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			// declares the variables
			String level;

			// assigns the txtMark's text to the level variables
			level = txtMark.Text;

			// calls the procedure.
			ConvertToPercent( level);





		}
	}
}
