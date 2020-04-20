using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CarRacingGame
{
	

	public partial class GameMenu : Form
	{
		Thread thread;

		public GameMenu()
		{
			InitializeComponent();
		
		}

		private void start_Click(object sender, EventArgs e)
		{
			Close();
			thread = new Thread(openGame);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}

		private void openGame()
		{
			Application.Run(new Game());
		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
