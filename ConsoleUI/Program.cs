using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace ConsoleUI
{
	class Program
	{

		/// <summary>
		/// if want to use directy to database:
		/// <commandText value="INSERT INTO Logs ([logDate],[logThread],[logLevel],[logSource],[logMessage],[exception]) VALUES (@log_date, @thread, @log_level, @log_source, @log_message, @exception)" />
		/// <commandType value="Text"></commandType>
	
		/// 
		/// if want use stored procedure in database log
		///<commandText value = "dbo.procLog_insert" ></ commandText >
		///< commandType value="StoredProcedure"></commandType>
		/// </summary>
		//private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");
		//private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		private static readonly log4net.ILog log = LogHelper.GetLogger();

		static void Main(string[] args)
		{
			log.Debug("Developer: Tutorial was run");
			log.Info("Maintenance: water pump turned on");
			log.Warn("Maintenance: the water pump is getting hot");

			var i = 0;
			try
			{
				var x = 10 / i;
			}
			catch (DivideByZeroException ex)
			{

				log.Error("Developer: We tried to divide by zero again", ex);
			}

			Counter j = new Counter();
			log4net.GlobalContext.Properties["Counter"] = j;

			for (j.LoopCounter = 0; j.LoopCounter < 5; j.LoopCounter++)
			{
				
				log.Fatal("This is message Number");
			}

			log.Fatal("Maintenance: the water pump exploded");

			Calculator.sum(7, 10);

			Console.ReadLine();
		}
	}
}
