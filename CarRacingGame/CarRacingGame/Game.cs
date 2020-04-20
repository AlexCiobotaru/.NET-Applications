using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
	public partial class Game : Form
	{
		private Random random = new Random();
		private int x;
		private int counter = 0;
		private int gameSpeed = 0;

		public Game()
		{
			InitializeComponent();
			over.Visible = false;

			Form GameMenu = new Form();
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			moveLine(gameSpeed);
			enemy(gameSpeed);
			gameOver();
			addCoins(gameSpeed);
			collectCoins();
		}

		

		private void enemy(int speed)
		{
			if (enemy1.Top >= 500)
			{
				x = random.Next(0, 350);
				enemy1.Location = new Point(x, 0);
			}
			else { enemy1.Top += speed; }

			if (enemy2.Top >= 500)
			{
				x = random.Next(0, 350);
				enemy2.Location = new Point(x, 0);
			}
			else { enemy2.Top += speed; }

			if (enemy3.Top >= 500)
			{
				x = random.Next(0, 350);
				enemy3.Location = new Point(x, 0);
			}
			else { enemy3.Top += speed; }
		}

		

		void collectCoins()
		{
			if (car.Bounds.IntersectsWith(coin1.Bounds))
			{
				int currentScore = ++counter;
				x = random.Next(50, 350);
				coin1.Location = new Point(x, 0);

				coinCounter.Text = "Coins: " + currentScore.ToString();
			}

			if (car.Bounds.IntersectsWith(coin2.Bounds))
			{
				int currentScore = ++counter;
				x = random.Next(50, 350);
				coin2.Location = new Point(x, 0);

				coinCounter.Text = "Coins: " + currentScore.ToString();

			}

			if (car.Bounds.IntersectsWith(coin3.Bounds))
			{
				int currentScore = ++counter;
				x = random.Next(50, 350);
				coin3.Location = new Point(x, 0);

				coinCounter.Text = "Coins: " + currentScore.ToString();
			}
		}


		void addCoins(int speed)
		{

			if (coin1.Top >= 500)
			{
				x = random.Next(50, 350);
				coin1.Location = new Point(x, 0);
			}
			else { coin1.Top += speed; }

			if (coin2.Top >= 500)
			{
				x = random.Next(50, 350);
				coin2.Location = new Point(x, 0);
			}
			else { coin2.Top += speed; }

			if (coin3.Top >= 500)
			{
				x = random.Next(50, 350);
				coin3.Location = new Point(x, 0);
			}
			else { coin3.Top += speed; }




		}

		void gameOver()
		{
			if (car.Bounds.IntersectsWith(enemy1.Bounds))
			{
				timer1.Enabled = false;
				over.Visible = true;
			}

			if (car.Bounds.IntersectsWith(enemy2.Bounds))
			{
				timer1.Enabled = false;
				over.Visible = true;
			}

			if (car.Bounds.IntersectsWith(enemy3.Bounds))
			{
				timer1.Enabled = false;
				over.Visible = true;
			}
		}

		void moveLine(int speed)
		{
			if(pictureBox1.Top >= 500)
			{
				pictureBox1.Top = 0;
			}
			else { pictureBox1.Top += speed; }


			if (pictureBox2.Top >= 500)
			{
				pictureBox2.Top = 0;
			}
			else { pictureBox2.Top += speed; }

			if (pictureBox3.Top >= 500)
			{
				pictureBox3.Top = 0;
			}
			else { pictureBox3.Top += speed; }

			if (pictureBox4.Top >= 500)
			{
				pictureBox4.Top = 0;
			}
			else { pictureBox4.Top += speed; }
		}

		
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Left)
			{
				if(car.Left > 0)
				car.Left += -gameSpeed;
			}

			if(e.KeyCode == Keys.Right)
			{
				if(car.Right < 280)
				car.Left += gameSpeed;
			}
			if (e.KeyCode == Keys.Up)
				if (gameSpeed < 21)
				{
					gameSpeed++;
				}
			
			if(e.KeyCode == Keys.Down)
				if (gameSpeed > 0)
				{
					gameSpeed--;
				}
		}

		private void over_Click(object sender, EventArgs e)
		{

		}
	}
}
