namespace CarRacingGame
{
	partial class Game
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.car = new System.Windows.Forms.PictureBox();
			this.enemy1 = new System.Windows.Forms.PictureBox();
			this.enemy2 = new System.Windows.Forms.PictureBox();
			this.enemy3 = new System.Windows.Forms.PictureBox();
			this.over = new System.Windows.Forms.Label();
			this.coinCounter = new System.Windows.Forms.Label();
			this.coin1 = new System.Windows.Forms.PictureBox();
			this.coin2 = new System.Windows.Forms.PictureBox();
			this.coin3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(186, -67);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 96);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Location = new System.Drawing.Point(186, 68);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(10, 131);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Location = new System.Drawing.Point(186, 228);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 126);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Location = new System.Drawing.Point(186, 405);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 117);
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.White;
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(10, 453);
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.White;
			this.pictureBox6.Location = new System.Drawing.Point(374, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(10, 453);
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// car
			// 
			this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
			this.car.Location = new System.Drawing.Point(98, 325);
			this.car.Name = "car";
			this.car.Size = new System.Drawing.Size(49, 64);
			this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.car.TabIndex = 6;
			this.car.TabStop = false;
			// 
			// enemy1
			// 
			this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
			this.enemy1.Location = new System.Drawing.Point(293, 57);
			this.enemy1.Name = "enemy1";
			this.enemy1.Size = new System.Drawing.Size(51, 65);
			this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.enemy1.TabIndex = 6;
			this.enemy1.TabStop = false;
			// 
			// enemy2
			// 
			this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
			this.enemy2.Location = new System.Drawing.Point(40, 90);
			this.enemy2.Name = "enemy2";
			this.enemy2.Size = new System.Drawing.Size(51, 65);
			this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.enemy2.TabIndex = 6;
			this.enemy2.TabStop = false;
			// 
			// enemy3
			// 
			this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
			this.enemy3.Location = new System.Drawing.Point(293, 297);
			this.enemy3.Name = "enemy3";
			this.enemy3.Size = new System.Drawing.Size(51, 65);
			this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.enemy3.TabIndex = 6;
			this.enemy3.TabStop = false;
			// 
			// over
			// 
			this.over.AutoSize = true;
			this.over.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.over.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.over.ForeColor = System.Drawing.Color.Red;
			this.over.Location = new System.Drawing.Point(74, 182);
			this.over.Name = "over";
			this.over.Size = new System.Drawing.Size(243, 43);
			this.over.TabIndex = 7;
			this.over.Text = "Game Over!";
			this.over.Click += new System.EventHandler(this.over_Click);
			// 
			// coinCounter
			// 
			this.coinCounter.AutoSize = true;
			this.coinCounter.BackColor = System.Drawing.Color.Red;
			this.coinCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coinCounter.Location = new System.Drawing.Point(12, 0);
			this.coinCounter.Name = "coinCounter";
			this.coinCounter.Size = new System.Drawing.Size(123, 29);
			this.coinCounter.TabIndex = 8;
			this.coinCounter.Text = "Coins = 0";
			// 
			// coin1
			// 
			this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
			this.coin1.Location = new System.Drawing.Point(110, 222);
			this.coin1.Name = "coin1";
			this.coin1.Size = new System.Drawing.Size(25, 25);
			this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin1.TabIndex = 9;
			this.coin1.TabStop = false;
			// 
			// coin2
			// 
			this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
			this.coin2.Location = new System.Drawing.Point(220, 118);
			this.coin2.Name = "coin2";
			this.coin2.Size = new System.Drawing.Size(25, 25);
			this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin2.TabIndex = 9;
			this.coin2.TabStop = false;
			// 
			// coin3
			// 
			this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
			this.coin3.Location = new System.Drawing.Point(262, 297);
			this.coin3.Name = "coin3";
			this.coin3.Size = new System.Drawing.Size(25, 25);
			this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin3.TabIndex = 9;
			this.coin3.TabStop = false;
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(382, 453);
			this.Controls.Add(this.coin3);
			this.Controls.Add(this.coin2);
			this.Controls.Add(this.coin1);
			this.Controls.Add(this.coinCounter);
			this.Controls.Add(this.over);
			this.Controls.Add(this.enemy3);
			this.Controls.Add(this.enemy2);
			this.Controls.Add(this.enemy1);
			this.Controls.Add(this.car);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Game";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CarRace";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox car;
		private System.Windows.Forms.PictureBox enemy1;
		private System.Windows.Forms.PictureBox enemy2;
		private System.Windows.Forms.PictureBox enemy3;
		private System.Windows.Forms.Label over;
		private System.Windows.Forms.Label coinCounter;
		private System.Windows.Forms.PictureBox coin1;
		private System.Windows.Forms.PictureBox coin2;
		private System.Windows.Forms.PictureBox coin3;
	}
}

