using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Loginizer
{
    public static class Log
    {
        public static Logger Instance { get; private set; }

        static Log()
        {
#if DEBUG
            // Setup the logging view for Sentinel - http://sentinel.codeplex.com
            var sentinalTarget = new NLogViewerTarget()
            {
                Name = "sentinal",
                Address = "udp://127.0.0.1:9999",
                IncludeNLogData = false
            };
            var sentinalRule = new LoggingRule("*", LogLevel.Trace, sentinalTarget);
            LogManager.Configuration.AddTarget("sentinal", sentinalTarget);
            LogManager.Configuration.LoggingRules.Add(sentinalRule);

            // Setup the logging view for Harvester - http://harvester.codeplex.com
            var harvesterTarget = new OutputDebugStringTarget()
            {
                Name = "harvester",
                Layout = "${log4jxmlevent:includeNLogData=false}"
            };
            var harvesterRule = new LoggingRule("*", LogLevel.Trace, harvesterTarget);
            LogManager.Configuration.AddTarget("harvester", harvesterTarget);
            LogManager.Configuration.LoggingRules.Add(harvesterRule);
#endif

            LogManager.ReconfigExistingLoggers();

            Instance = LogManager.GetCurrentClassLogger();
        }
    }

    class Loginizer
    {
        public static void Main()
        {
            
            try
            {
                Log.Instance.Debug("One");
                Log.Instance.Fatal("fatal");
                Log.Instance.Trace("trace");
                Log.Instance.Warn("Two");
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Debug("Log Debug");
                logger.Error("log error");
                logger.Fatal("log fatal");
                logger.Info("log info");
                logger.Trace("log trace");
                logger.Warn("log warn");
                throw new ApplicationException();
            }
            catch (ApplicationException ae)
            {
                Log.Instance.Error("Error:"+ae);
            }
            finally
            {
                Log.Instance.Info("Info");
                Log.Instance.Log(new LogEventInfo(LogLevel.Trace, "ttt","222"));
            }
        }
    }
}
