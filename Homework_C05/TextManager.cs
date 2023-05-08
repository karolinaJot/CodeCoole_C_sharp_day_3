using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_C05
{
	internal class TextManager
	{

		public string FindLongestWord(string sentence)
		{
			string currentLongest = string.Empty;

			string[] wordsList = sentence.Split(' ');

			foreach (string word in wordsList)
			{
				if (word.Length > currentLongest.Length)
					currentLongest = word;
			}

			return currentLongest;
		}

		public string[] GetAllLongestWords() { 
		
		
		}

		private 
	}
}
