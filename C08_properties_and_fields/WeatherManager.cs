﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C0_7_enum
{

	enum Unit
	{
		Celsius,
		Kelvin,
		Farenheit
	}
	internal class WeatherManager
	{

		public string SearchChar { get; } = "°";
		public string EndChar { get; set; } = ">";

		private	string address = $"https://www.google.com/search?q=weather+";

		public double GetTemperature(string city, Unit unit)
		{
			// char onlyOneCharacter = 'a';

		


			//  Console.WriteLine("Enter the city name");
			//   string city = Console.ReadLine();


			WebClient wc = new WebClient();
			string data = wc.DownloadString(address + city);

			try
			{
				int index = data.IndexOf(SearchChar);
				int currentPosition = index;
				int iterationCount = 0;

				while (data.Substring(currentPosition, 1) != EndChar)
				{
					iterationCount++;
					currentPosition--;
				}

				string result = data.Substring(currentPosition + 1, index - currentPosition + 1);
				// Console.WriteLine(result);
				return TransformTemperature(unit,
					Convert.ToDouble(result.Substring(0, result.Length - 2)));
			}
			catch (Exception)
			{
				throw new Exception("Faild to retrieve temperature");
			}
		}


		public double TransformTemperature(Unit unit, double temperature)
		{
			if (unit == Unit.Celsius)
				return temperature;

			if (unit == Unit.Farenheit)
				return temperature * 1.8 + 32;

			if (unit == Unit.Kelvin)
				return temperature + 273.15;

			throw new Exception("Unknown unit");
		}

	}
}


