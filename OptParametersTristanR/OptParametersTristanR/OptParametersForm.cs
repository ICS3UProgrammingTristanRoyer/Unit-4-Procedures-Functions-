using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptParametersTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void DisplayAddress(String aptNumber , string streetAddress , string city , string province , string postalCode)
		{ MessageBox.Show("Your Address is:"
		+ aptNumber + " , "
		+ streetAddress + " , "
		+ city + " , "
		+ province + " , "
		+ postalCode);
		}

		public void DisplayAddress( string streetAddress, string city, string province, string postalCode)
		{
			MessageBox.Show("Your Address is:"
		  +  streetAddress + " , "
		  +  city + " , "
		  +  province + " , "
		  +  postalCode);
		}

		private void btnAddress_Click(object sender, EventArgs e)
		{
			// declare local variables
			String userAptNumber;
			String userStreetAddress, userCity, userProvince, userPostalCode;

			// get the locations
			userAptNumber = txtApt.Text;
			userStreetAddress = txtStreet.Text;
			userCity = txtCity.Text;
			userProvince = txtProvince.Text;
			userPostalCode = txtPostal.Text;

			// check to make sure the user enters the required fields
			if (userStreetAddress == "")
			{
				MessageBox.Show("Please enter your street address", "AddressDisplay");
			}
			else if (userProvince == "")
			{
				MessageBox.Show("Please enter your province", "AddressDisplay");
			}
			else if (userCity == "")
			{
				MessageBox.Show("Please enter your City", "AddressDisplay");
			}
			else if (userPostalCode == "")
			{
				MessageBox.Show("Please enter your Postal Code", "AddressDisplay");
			}
			else if (userAptNumber == "")
			{
				DisplayAddress(userStreetAddress, userCity, userProvince, userPostalCode);
			}
			else
				DisplayAddress(userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode);




		}

		private void txtApt_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
