using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Collections;

namespace Ex1Server
{
	/// <summary>
	/// Summary description for WebService1
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class WebService1 : System.Web.Services.WebService
	{

		[WebMethod (Description = "Celsius to Fahrenheit Conversion")]
		public double CtoF(double celsiusTemp)
		{
			double fahrenheitTemp = Math.Round((celsiusTemp * 9) / 5 + 32,2);
			
			return fahrenheitTemp;
		}

		[WebMethod (Description = "Fahrenheit to Celsius Conversion")]
		public double FtoC(double fahrenheitTemp)
		{
			double celsiusTemp = Math.Round((fahrenheitTemp - 32) * 5 / 9,2);

			return celsiusTemp;
		}

		[WebMethod (Description ="Show the current date and time")]
		public string dateShow()
		{
			return DateTime.Now.ToString();
		}

		[WebMethod (Description ="Displays a five-item list")]
		public List<string> itemList()
		{
			List<string> itemList = new List<string>();

			itemList.Add("Item1");
			itemList.Add("Item2");
			itemList.Add("Item3");
			itemList.Add("Item4");
			itemList.Add("Item5");

			return itemList;
		}

		[WebMethod (Description ="Conversion from Lei to Euro")]
		public double leiToEuro(double leiAmount)
		{
			double euroAmount = Math.Round(leiAmount / 4.83, 2);
			return euroAmount;
		}

	}
}
