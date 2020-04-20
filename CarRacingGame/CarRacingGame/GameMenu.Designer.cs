namespace CarRacingGame
{
	partial class GameMenu
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
			this.start = new System.Windows.Forms.Button();
			this.quitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// start
			// 
			this.start.BackColor = System.Drawing.SystemColors.InfoText;
			this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.start.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start.ForeColor = System.Drawing.Color.Red;
			this.start.Location = new System.Drawing.Point(239, 302);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(119, 51);
			this.start.TabIndex = 0;
			this.start.Text = "Start";
			this.start.UseVisualStyleBackColor = false;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// quitButton
			// 
			this.quitButton.BackColor = System.Drawing.SystemColors.InfoText;
			this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.quitButton.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.ForeColor = System.Drawing.Color.Red;
			this.quitButton.Location = new System.Drawing.Point(239, 369);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(119, 51);
			this.quitButton.TabIndex = 1;
			this.quitButton.Text = "Quit";
			this.quitButton.UseVisualStyleBackColor = false;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// GameMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CarRacingGame.Properties.Resources.menuWallpaper;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(382, 453);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.start);
			this.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimizeBox = false;
			this.Name = "GameMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CarRacingGame";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button quitButton;
	}
}