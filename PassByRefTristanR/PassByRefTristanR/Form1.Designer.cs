namespace PassByRefTristanR
{
	partial class numNumberOfPlaces
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtDecimal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numNumOfPlaces = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numNumOfPlaces)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(98, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Round";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtDecimal
			// 
			this.txtDecimal.Location = new System.Drawing.Point(172, 28);
			this.txtDecimal.Name = "txtDecimal";
			this.txtDecimal.Size = new System.Drawing.Size(100, 20);
			this.txtDecimal.TabIndex = 1;
			this.txtDecimal.TextChanged += new System.EventHandler(this.txtDecimal_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Please enter the number you want to round:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "How many places do you want to round:";
			// 
			// numNumOfPlaces
			// 
			this.numNumOfPlaces.Location = new System.Drawing.Point(172, 67);
			this.numNumOfPlaces.Name = "numNumOfPlaces";
			this.numNumOfPlaces.Size = new System.Drawing.Size(100, 20);
			this.numNumOfPlaces.TabIndex = 4;
			// 
			// numNumberOfPlaces
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.numNumOfPlaces);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDecimal);
			this.Controls.Add(this.button1);
			this.Name = "numNumberOfPlaces";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numNumOfPlaces)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtDecimal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numNumOfPlaces;
	}
}

