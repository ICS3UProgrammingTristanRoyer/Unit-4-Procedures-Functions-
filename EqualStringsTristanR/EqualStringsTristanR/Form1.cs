using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EqualStringsTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		public bool StringsAreEqual (string string1 , string string2 , ref bool isEqual )
		{
			
			string lowerString1;
			string lowerString2;

			lowerString1 = string1.ToLower();
			lowerString2 = string2.ToLower();
			

			if (lowerString1 == lowerString2)
			{
				isEqual = true;
			}

			else
			{
				isEqual = false;

			}

			return isEqual;


		}

		private void button1_Click(object sender, EventArgs e)
		{
			string userString1;
			string userString2;
			bool equality = false;

			userString1 = Convert.ToString(txtString1.Text);
			userString2 = Convert.ToString(txtString2.Text);

			StringsAreEqual(userString1, userString2, ref equality);

			if (equality == true)
			{
				lblAnswer.Text = "The strings are equal";


			}
			else if (equality == false)
			{
				lblAnswer.Text = "The strings are not equal";
			}
			else
			{
				lblAnswer.Text = "Error!";
			}

		}
	}
}
