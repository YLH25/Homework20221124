using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.model
{
	public static class StringExtenstions
	{
		public static int ToInt(this string source, int defaultValue)
		{
			bool isInt = int.TryParse(source, out int number);

			return isInt ? number : defaultValue;
		}
	}
}
