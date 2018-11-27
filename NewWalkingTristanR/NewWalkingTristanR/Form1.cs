using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWalkingTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void GeneratePictureBoxes()
		{
			// generate each of the picture boxes on the form.

			GeneratePictureBoxes(61, 78);
			GeneratePictureBoxes(464, 78);
			GeneratePictureBoxes(61, 358);
			GeneratePictureBoxes(464, 358);
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
			PictureBox topPicMan = new PictureBox();
			Point pntPic = new System.Drawing.Point(x, y);

			// set the location of the picture box.
			top
		}
	}
}
