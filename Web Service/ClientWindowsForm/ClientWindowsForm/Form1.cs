using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ClientWindowsForm
{
	public partial class Form1 : Form
	{
		ClientWindowsForm.ServiceReference1.WebService1SoapClient service = new ClientWindowsForm.ServiceReference1.WebService1SoapClient();

		public Form1()
		{
			InitializeComponent();
		}

		private void FahrenheitToCelsius_Click(object sender, EventArgs e)
		{
			resultTb.Text = service.FtoC(Convert.ToDouble(fahrenheitTb.Text)).ToString();
		}

		private void CelsiusToFahrenheit_Click(object sender, EventArgs e)
		{
			resultTb.Text = service.CtoF(Convert.ToDouble(celsiusTb.Text)).ToString();
		}

		private void Conversion_Click(object sender, EventArgs e)
		{
			euroTb.Text = service.leiToEuro(Convert.ToDouble(leiTb.Text)).ToString();
		}

		private void date_Click(object sender, EventArgs e)
		{
			date.Text = service.dateShow();
		}

		private void addList_Click(object sender, EventArgs e)
		{
			foreach(String item in service.itemList())
			{
				listBox.Items.Add(item);
			}
		}
	}
}
