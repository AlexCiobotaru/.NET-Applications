namespace ClientWindowsForm
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
			this.listBox = new System.Windows.Forms.ListBox();
			this.addList = new System.Windows.Forms.Button();
			this.date = new System.Windows.Forms.Label();
			this.fahrenheit = new System.Windows.Forms.Label();
			this.celsius = new System.Windows.Forms.Label();
			this.celsiusTb = new System.Windows.Forms.TextBox();
			this.fahrenheitTb = new System.Windows.Forms.TextBox();
			this.result = new System.Windows.Forms.Label();
			this.resultTb = new System.Windows.Forms.TextBox();
			this.CelsiusToFahrenheit = new System.Windows.Forms.Button();
			this.FahrenheitToCelsius = new System.Windows.Forms.Button();
			this.euroTb = new System.Windows.Forms.TextBox();
			this.leiTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lei = new System.Windows.Forms.Label();
			this.Conversion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 16;
			this.listBox.Location = new System.Drawing.Point(80, 49);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(208, 116);
			this.listBox.TabIndex = 0;
			// 
			// addList
			// 
			this.addList.Location = new System.Drawing.Point(80, 189);
			this.addList.Name = "addList";
			this.addList.Size = new System.Drawing.Size(75, 23);
			this.addList.TabIndex = 1;
			this.addList.Text = "Add List";
			this.addList.UseVisualStyleBackColor = true;
			this.addList.Click += new System.EventHandler(this.addList_Click);
			// 
			// date
			// 
			this.date.AutoSize = true;
			this.date.Location = new System.Drawing.Point(77, 251);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(38, 17);
			this.date.TabIndex = 2;
			this.date.Text = "Date";
			this.date.Click += new System.EventHandler(this.date_Click);
			// 
			// fahrenheit
			// 
			this.fahrenheit.AutoSize = true;
			this.fahrenheit.Location = new System.Drawing.Point(421, 106);
			this.fahrenheit.Name = "fahrenheit";
			this.fahrenheit.Size = new System.Drawing.Size(56, 17);
			this.fahrenheit.TabIndex = 3;
			this.fahrenheit.Text = "Temp F";
			// 
			// celsius
			// 
			this.celsius.AutoSize = true;
			this.celsius.Location = new System.Drawing.Point(417, 61);
			this.celsius.Name = "celsius";
			this.celsius.Size = new System.Drawing.Size(57, 17);
			this.celsius.TabIndex = 4;
			this.celsius.Text = "Temp C";
			// 
			// celsiusTb
			// 
			this.celsiusTb.Location = new System.Drawing.Point(511, 58);
			this.celsiusTb.Name = "celsiusTb";
			this.celsiusTb.Size = new System.Drawing.Size(100, 22);
			this.celsiusTb.TabIndex = 5;
			// 
			// fahrenheitTb
			// 
			this.fahrenheitTb.Location = new System.Drawing.Point(511, 101);
			this.fahrenheitTb.Name = "fahrenheitTb";
			this.fahrenheitTb.Size = new System.Drawing.Size(100, 22);
			this.fahrenheitTb.TabIndex = 6;
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(421, 173);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(48, 17);
			this.result.TabIndex = 7;
			this.result.Text = "Result";
			// 
			// resultTb
			// 
			this.resultTb.Location = new System.Drawing.Point(511, 168);
			this.resultTb.Name = "resultTb";
			this.resultTb.Size = new System.Drawing.Size(100, 22);
			this.resultTb.TabIndex = 8;
			// 
			// CelsiusToFahrenheit
			// 
			this.CelsiusToFahrenheit.Location = new System.Drawing.Point(511, 251);
			this.CelsiusToFahrenheit.Name = "CelsiusToFahrenheit";
			this.CelsiusToFahrenheit.Size = new System.Drawing.Size(75, 23);
			this.CelsiusToFahrenheit.TabIndex = 9;
			this.CelsiusToFahrenheit.Text = "CtoF";
			this.CelsiusToFahrenheit.UseVisualStyleBackColor = true;
			this.CelsiusToFahrenheit.Click += new System.EventHandler(this.CelsiusToFahrenheit_Click);
			// 
			// FahrenheitToCelsius
			// 
			this.FahrenheitToCelsius.Location = new System.Drawing.Point(511, 214);
			this.FahrenheitToCelsius.Name = "FahrenheitToCelsius";
			this.FahrenheitToCelsius.Size = new System.Drawing.Size(75, 23);
			this.FahrenheitToCelsius.TabIndex = 10;
			this.FahrenheitToCelsius.Text = "FtoC";
			this.FahrenheitToCelsius.UseVisualStyleBackColor = true;
			this.FahrenheitToCelsius.Click += new System.EventHandler(this.FahrenheitToCelsius_Click);
			// 
			// euroTb
			// 
			this.euroTb.Location = new System.Drawing.Point(511, 366);
			this.euroTb.Name = "euroTb";
			this.euroTb.Size = new System.Drawing.Size(100, 22);
			this.euroTb.TabIndex = 11;
			// 
			// leiTb
			// 
			this.leiTb.Location = new System.Drawing.Point(511, 324);
			this.leiTb.Name = "leiTb";
			this.leiTb.Size = new System.Drawing.Size(100, 22);
			this.leiTb.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(417, 366);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Euro";
			// 
			// lei
			// 
			this.lei.AutoSize = true;
			this.lei.Location = new System.Drawing.Point(421, 329);
			this.lei.Name = "lei";
			this.lei.Size = new System.Drawing.Size(27, 17);
			this.lei.TabIndex = 14;
			this.lei.Text = "Lei";
			// 
			// Conversion
			// 
			this.Conversion.Location = new System.Drawing.Point(647, 346);
			this.Conversion.Name = "Conversion";
			this.Conversion.Size = new System.Drawing.Size(75, 23);
			this.Conversion.TabIndex = 15;
			this.Conversion.Text = "Convert";
			this.Conversion.UseVisualStyleBackColor = true;
			this.Conversion.Click += new System.EventHandler(this.Conversion_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Conversion);
			this.Controls.Add(this.lei);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.leiTb);
			this.Controls.Add(this.euroTb);
			this.Controls.Add(this.FahrenheitToCelsius);
			this.Controls.Add(this.CelsiusToFahrenheit);
			this.Controls.Add(this.resultTb);
			this.Controls.Add(this.result);
			this.Controls.Add(this.fahrenheitTb);
			this.Controls.Add(this.celsiusTb);
			this.Controls.Add(this.celsius);
			this.Controls.Add(this.fahrenheit);
			this.Controls.Add(this.date);
			this.Controls.Add(this.addList);
			this.Controls.Add(this.listBox);
			this.Name = "Form1";
			this.Text = "Exercise2 - Lab4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button addList;
		private System.Windows.Forms.Label date;
		private System.Windows.Forms.Label fahrenheit;
		private System.Windows.Forms.Label celsius;
		private System.Windows.Forms.TextBox celsiusTb;
		private System.Windows.Forms.TextBox fahrenheitTb;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.TextBox resultTb;
		private System.Windows.Forms.Button CelsiusToFahrenheit;
		private System.Windows.Forms.Button FahrenheitToCelsius;
		private System.Windows.Forms.TextBox euroTb;
		private System.Windows.Forms.TextBox leiTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lei;
		private System.Windows.Forms.Button Conversion;
	}
}

