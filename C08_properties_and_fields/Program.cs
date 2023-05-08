using C0_7_enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_properties_and_fields
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.FirstName = "Karolina";
			person.LastName = "Smith";

            Console.WriteLine(person.FullName);

			WeatherManager weatherManager = new WeatherManager();

			Console.WriteLine(weatherManager.SearchChar);


			weatherManager.EndChar = "%";
			weatherManager.GetTemperature("Warsaw", Unit.Celsius);
        }
	}
}
