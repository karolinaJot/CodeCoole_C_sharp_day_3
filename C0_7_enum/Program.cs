using C0_7_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0_7_enum

{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter a city");
			string city = Console.ReadLine();	

				WeatherManager weatherManager = new WeatherManager();

			List<Unit> listExample = Enum.GetValues(typeof(Unit)).Cast<Unit>().ToList();

            Console.WriteLine("Enter one of the following units: " + string.Join(",", listExample));

            weatherManager.GetTemperature("London", Unit.Farenheit);


			string unit = Console.ReadLine();

			// you can convert enum to string, enum to int, int to enum and enum to string
			bool isValid = Enum.TryParse(unit, out Unit unitEnum);

			Unit selectedUnit = (Unit)Enum.ToObject(typeof(Unit), 2-1);

			if (isValid) { 
				WeatherManager weatherManager1 = new WeatherManager();
				double temp = weatherManager1.GetTemperature(city, unitEnum);
				Console.WriteLine(temp);
			
			}

			
		}
	}
}
