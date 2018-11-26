namespace OptParametersTristanR
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAddress = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtApt = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtProvince = new System.Windows.Forms.TextBox();
			this.txtPostal = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAddress
			// 
			this.btnAddress.Location = new System.Drawing.Point(16, 174);
			this.btnAddress.Name = "btnAddress";
			this.btnAddress.Size = new System.Drawing.Size(91, 23);
			this.btnAddress.TabIndex = 0;
			this.btnAddress.Text = "Check Address";
			this.btnAddress.UseVisualStyleBackColor = true;
			this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Apt.Number(Optional):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Street Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "City:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Province:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Postal Code:";
			// 
			// txtApt
			// 
			this.txtApt.Location = new System.Drawing.Point(145, 13);
			this.txtApt.Name = "txtApt";
			this.txtApt.Size = new System.Drawing.Size(100, 20);
			this.txtApt.TabIndex = 6;
			this.txtApt.TextChanged += new System.EventHandler(this.txtApt_TextChanged);
			// 
			// txtStreet
			// 
			this.txtStreet.Location = new System.Drawing.Point(145, 42);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(100, 20);
			this.txtStreet.TabIndex = 7;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(145, 68);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(100, 20);
			this.txtCity.TabIndex = 8;
			// 
			// txtProvince
			// 
			this.txtProvince.Location = new System.Drawing.Point(145, 97);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.Size = new System.Drawing.Size(100, 20);
			this.txtProvince.TabIndex = 9;
			// 
			// txtPostal
			// 
			this.txtPostal.Location = new System.Drawing.Point(145, 125);
			this.txtPostal.Name = "txtPostal";
			this.txtPostal.Size = new System.Drawing.Size(100, 20);
			this.txtPostal.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txtPostal);
			this.Controls.Add(this.txtProvince);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtStreet);
			this.Controls.Add(this.txtApt);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddress);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtApt;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtProvince;
		private System.Windows.Forms.TextBox txtPostal;
	}
}

