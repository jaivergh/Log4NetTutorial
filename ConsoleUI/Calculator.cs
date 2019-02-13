using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	class Calculator
	{
		private static readonly log4net.ILog log = LogHelper.GetLogger();

		public static int sum(int num1, int num2)
		{
			log.Debug("Summing: " + num1 + " and " + num2);
			return num1 + num2;
		}
	}
}
