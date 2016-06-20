using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace MyNLog
{
    class Program
    {
        static void Main(string[] args)
        {
//            MyLogger logger=new MyLogger(LoggerType.WEB);
//            logger.SetMessage(LoggerLevel.DEBUG, "Test Message");
        }
    }

    public class MyLogger
    {
        private Logger Log;

        public MyLogger(LoggerType type)
        {
            if (GetLoggerType(type)!=null)
            {
                Log = LogManager.GetLogger(GetLoggerType(type));
            }
        }

        private static string GetLoggerType(LoggerType type)
        {
            switch (type)
            {
                case LoggerType.DB:
                    return "DB";
                    case LoggerType.XML:
                    return "XML";
                    case LoggerType.WEB:
                    return "WEB";
                    case LoggerType.APA:
                    return "APA";
            }
            return null;
        }

                public void SetMessage(LoggerLevel level, string message)
                {
                    switch (level)
                    {
                            case LoggerLevel.DEBUG:
                            Log.Debug(message);
                            break;
                            case LoggerLevel.INFO:
                            Log.Info(message);
                            break;
                            case LoggerLevel.WARN:
                            Log.Warn(message);
                            break;
                            case LoggerLevel.ERROR:
                            Log.Error(message);
                            break;
                            case LoggerLevel.FATAL:
                            Log.Fatal(message);
                            break;
                    }
                }
    }

    public enum LoggerType
    {
        DB, XML, WEB, APA
    }

    public enum LoggerLevel
    {
        DEBUG, INFO, WARN, ERROR, FATAL
    }
}
