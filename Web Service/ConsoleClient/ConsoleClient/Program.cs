using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleClient
{
	class Program
	{
		static ConsoleClient.ServerFirstExercise.WebService1SoapClient service = new ConsoleClient.ServerFirstExercise.WebService1SoapClient();

		private static void FtoC()
		{
			Console.WriteLine("FAHRENHEIT TO CELSIUS METHOD");
			Console.WriteLine();
			Console.WriteLine("Enter the temperature in Fahrenheit: ");
			double fahrenheit = double.Parse(Console.ReadLine());
			double celsius = service.FtoC(fahrenheit);
			Console.WriteLine("Temperature in Celsius: " + celsius.ToString());
			Console.WriteLine();
			
		}

		private static void CtoF()
		{
			Console.WriteLine("CELSIUS TO FAHRENHEIT METHOD");
			Console.WriteLine();
			Console.WriteLine("Enter the temperature in Celsius: ");
			double celsius = double.Parse(Console.ReadLine());
			double fahrenheit = service.CtoF(celsius);
			Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit.ToString());
			Console.WriteLine();
			Console.ReadKey();

		}

		private static void ShowDate()
		{
			Console.WriteLine("DATE-TIME METHOD");
			Console.WriteLine("The current date and time is: ");
			Console.WriteLine(service.dateShow());
			Console.ReadKey();
			Console.WriteLine();
		}

		

		private static void leiToEuro()
		{
			Console.WriteLine("LEI TO EURO CONVERSION");
			Console.WriteLine("Enter the amount in lei: ");
			double lei = double.Parse(Console.ReadLine());
			double euro = service.leiToEuro(lei);
			Console.WriteLine("Euro: " + euro);
			Console.ReadKey();

		}


		private static void listItem()
		{
			Console.WriteLine("List with 5 items: ");

			//foreach (String item in service.itemList())
			//{
				//Console.WriteLine(item);
			//}
		}
		static void Main(string[] args)
		{

			FtoC();
			CtoF();
			ShowDate();
			leiToEuro();
			listItem();


		}
	}
}
