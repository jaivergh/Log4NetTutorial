# Log4NetTutorial
Use of log4Net

-Add "log4Net" from NugetManager

-Add "[assembly: log4net.Config.XmlConfigurator(Watch =true)]" one time at the beginning of the program

-Create the Logger: "private static readonly log4net.ILog log = LogHelper.GetLogger();"

-Add the "<log4net>" section in App.config
