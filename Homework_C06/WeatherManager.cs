using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_C06
{
	internal class WeatherManager
	{

		// wrzucić kod z B02 - web client

		// w maine stowrzyć obiekt tej klasy i pobrać temperature


		// Transofrm u gościa
		private double CovertTemprature(string unit, double temperature)
		{
			if (unit == "Celsius")

				return temperature;
			if (unit == "Fahrenheit")
				return (temperature * 1.8) + 32;

			if (unit == "Kelvin")
				return temperature + 277.15;

			throw new Exception("Unknow unit");

		}
	}
}
