using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_properties_and_fields
{
	internal class Person
	{
		// field - private, visibale only insied class
		private string lastName;

		// property - are public
		public string FirstName { get; set; }

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}

		// encapsulation - hide interaction within the object,
		// show only what is necessery, internal sate of the object stay hiden
		public string FullName
		{
			get
			{
				string upperFirstName = FirstName.ToUpper();
				string lowerLastName = LastName.ToLower();
				return upperFirstName + " " + lowerLastName;
			}
		}


	}
}
