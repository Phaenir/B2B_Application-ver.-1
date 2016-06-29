using System.IO;
using System.Configuration;
using MyNLog;
using TypeMock.ArrangeActAssert.Suggest;
using TypeMock.ArrangeActAssert;
using System.Linq;
using NUnit.Framework;

//-------------------------------------------------------------------------------------------------------------------
// Unit Tests suggested by Typemock.
// You are invited to modify the tests just take note to leave tests in region
//-------------------------------------------------------------------------------------------------------------------
namespace UnitTestMyNLog
{
    [SafetyNet(typeof(MyLogger))]
    [Isolated()]
    [TestFixture()]
    public class MyLoggerTests
    {
        #region Unit Tests for MyLogger
        
        [Test]
        public void ClassConstructor_Test_NoAsserts()
        {
            // MyNLog.MyLogger..ctor(LoggerType)(6)=[VVVVVV]
            // MyNLog.MyLogger.GetLoggerType(LoggerType)(8)=[VVXXXVXV]
             
            // arrange
            var appSettings = ConfigurationManager.AppSettings;    // plan 91 (90: 0)
            Isolate.WhenCalled(() => appSettings["nlog.internalLogToConsole"]).WillReturn("WEB");    // plan 93 (91: 1) (82: 0)
            var appSettings1 = ConfigurationManager.AppSettings;    // plan 94 (90: 0)
            Isolate.WhenCalled(() => appSettings1["nlog.internalLogToConsoleError"]).WillReturn("APA");    // plan 96 (94: 1) (83: 0)
            var appSettings2 = ConfigurationManager.AppSettings;    // plan 97 (90: 0)
            Isolate.WhenCalled(() => appSettings2["nlog.internalLogLevel"]).WillReturn("XML");    // plan 99 (97: 1) (81: 0)
            var appSettings3 = ConfigurationManager.AppSettings;    // plan 100 (90: 0)
            Isolate.WhenCalled(() => appSettings3["nlog.internalLogFile"]).WillReturn("DB");    // plan 102 (100: 1) (80: 0)
            var appSettings4 = ConfigurationManager.AppSettings;    // plan 103 (90: 0)
            Isolate.WhenCalled(() => appSettings4["nlog.internalLogToTrace"]).WillReturn("APA");    // plan 105 (103: 1) (83: 0)
            var appSettings5 = ConfigurationManager.AppSettings;    // plan 106 (90: 0)
            Isolate.WhenCalled(() => appSettings5["nlog.internalLogIncludeTimestamp"]).WillReturn("WEB");    // plan 108 (106: 1) (82: 0)
            Isolate.WhenCalled(() => File.Exists(null)).WillReturn(true);    // plan 109 (0: 0) (36: 0)
            Isolate.WhenCalled(() => Directory.Exists(null)).WillReturn(false);    // plan 110 (0: 0) (37: 0)
             
            // act
            var result = new MyLogger(LoggerType.APA);    // plan 111 (88: 0) (93: 0) (96: 0) (99: 0) (102: 0) (105: 0) (108: 0) (109: 0) (110: 0)
        }

        #endregion
        #region Unit Tests for SetMessage
        
        [Test]
        public void SetMessage_Test_NoAsserts()
        {
            // MyNLog.MyLogger.SetMessage(LoggerLevel,String)(13)=[VVVVXXXXXXXXV]
             
            // arrange
            var appSettings = ConfigurationManager.AppSettings;    // plan 128 (88: 0)
            Isolate.WhenCalled(() => appSettings["nlog.internalLogToConsole"]).WillReturn("DB");    // plan 129 (128: 1) (79: 0)
            var appSettings1 = ConfigurationManager.AppSettings;    // plan 130 (88: 0)
            Isolate.WhenCalled(() => appSettings1["nlog.internalLogToConsoleError"]).WillReturn("APA");    // plan 131 (130: 1) (82: 0)
            var appSettings2 = ConfigurationManager.AppSettings;    // plan 132 (88: 0)
            Isolate.WhenCalled(() => appSettings2["nlog.internalLogLevel"]).WillReturn("XML");    // plan 133 (132: 1) (80: 0)
            var appSettings3 = ConfigurationManager.AppSettings;    // plan 134 (88: 0)
            Isolate.WhenCalled(() => appSettings3["nlog.internalLogFile"]).WillReturn("WEB");    // plan 135 (134: 1) (81: 0)
            var appSettings4 = ConfigurationManager.AppSettings;    // plan 136 (88: 0)
            Isolate.WhenCalled(() => appSettings4["nlog.internalLogToTrace"]).WillReturn("XML");    // plan 137 (136: 1) (80: 0)
            var appSettings5 = ConfigurationManager.AppSettings;    // plan 138 (88: 0)
            Isolate.WhenCalled(() => appSettings5["nlog.internalLogIncludeTimestamp"]).WillReturn("XML");    // plan 139 (138: 1) (80: 0)
            Isolate.WhenCalled(() => File.Exists(null)).WillReturn(false);    // plan 101 (0: 0) (37: 0)
            Isolate.WhenCalled(() => Directory.Exists(null)).WillReturn(true);    // plan 126 (0: 0) (36: 0)
            var myLogger = new MyLogger(LoggerType.DB);    // plan 142 (83: 0) (129: 0) (131: 0) (133: 0) (135: 0) (137: 0) (139: 0) (101: 0) (126: 0)
             
            // act
            myLogger.SetMessage(LoggerLevel.DEBUG, "WEB");    // plan 179 (142: 0) (173: 0) (81: 0)
        }

        
        [Test]
        public void SetMessage_Test_NoAsserts_001()
        {
            // MyNLog.MyLogger.SetMessage(LoggerLevel,String)(13)=[VVXXXXXXXXVVV]
             
            // arrange
            var appSettings = ConfigurationManager.AppSettings;    // plan 89 (88: 0)
            Isolate.WhenCalled(() => appSettings["nlog.internalLogToConsole"]).WillReturn("DB");    // plan 90 (89: 1) (79: 0)
            var appSettings1 = ConfigurationManager.AppSettings;    // plan 91 (88: 0)
            Isolate.WhenCalled(() => appSettings1["nlog.internalLogToConsoleError"]).WillReturn("WEB");    // plan 92 (91: 1) (81: 0)
            var appSettings2 = ConfigurationManager.AppSettings;    // plan 93 (88: 0)
            Isolate.WhenCalled(() => appSettings2["nlog.internalLogLevel"]).WillReturn("DB");    // plan 94 (93: 1) (79: 0)
            var appSettings3 = ConfigurationManager.AppSettings;    // plan 95 (88: 0)
            Isolate.WhenCalled(() => appSettings3["nlog.internalLogFile"]).WillReturn("WEB");    // plan 96 (95: 1) (81: 0)
            var appSettings4 = ConfigurationManager.AppSettings;    // plan 97 (88: 0)
            Isolate.WhenCalled(() => appSettings4["nlog.internalLogToTrace"]).WillReturn("DB");    // plan 98 (97: 1) (79: 0)
            var appSettings5 = ConfigurationManager.AppSettings;    // plan 99 (88: 0)
            Isolate.WhenCalled(() => appSettings5["nlog.internalLogIncludeTimestamp"]).WillReturn("WEB");    // plan 100 (99: 1) (81: 0)
            Isolate.WhenCalled(() => File.Exists(null)).WillReturn(false);    // plan 101 (0: 0) (37: 0)
            Isolate.WhenCalled(() => Directory.Exists(null)).WillReturn(false);    // plan 102 (0: 0) (37: 0)
            var myLogger = new MyLogger(LoggerType.DB);    // plan 103 (83: 0) (90: 0) (92: 0) (94: 0) (96: 0) (98: 0) (100: 0) (101: 0) (102: 0)
             
            // act
            myLogger.SetMessage(LoggerLevel.FATAL, "XML");    // plan 204 (103: 0) (177: 0) (80: 0)
        }

        
        [Test]
        public void SetMessage_Test_NoAsserts_002()
        {
            // MyNLog.MyLogger.SetMessage(LoggerLevel,String)(13)=[VVXXXXVVXXXXV]
             
            // arrange
            var appSettings = ConfigurationManager.AppSettings;    // plan 128 (88: 0)
            Isolate.WhenCalled(() => appSettings["nlog.internalLogToConsole"]).WillReturn("DB");    // plan 129 (128: 1) (79: 0)
            var appSettings1 = ConfigurationManager.AppSettings;    // plan 130 (88: 0)
            Isolate.WhenCalled(() => appSettings1["nlog.internalLogToConsoleError"]).WillReturn("APA");    // plan 131 (130: 1) (82: 0)
            var appSettings2 = ConfigurationManager.AppSettings;    // plan 132 (88: 0)
            Isolate.WhenCalled(() => appSettings2["nlog.internalLogLevel"]).WillReturn("XML");    // plan 133 (132: 1) (80: 0)
            var appSettings3 = ConfigurationManager.AppSettings;    // plan 134 (88: 0)
            Isolate.WhenCalled(() => appSettings3["nlog.internalLogFile"]).WillReturn("WEB");    // plan 135 (134: 1) (81: 0)
            var appSettings4 = ConfigurationManager.AppSettings;    // plan 136 (88: 0)
            Isolate.WhenCalled(() => appSettings4["nlog.internalLogToTrace"]).WillReturn("XML");    // plan 137 (136: 1) (80: 0)
            var appSettings5 = ConfigurationManager.AppSettings;    // plan 138 (88: 0)
            Isolate.WhenCalled(() => appSettings5["nlog.internalLogIncludeTimestamp"]).WillReturn("XML");    // plan 139 (138: 1) (80: 0)
            Isolate.WhenCalled(() => File.Exists(null)).WillReturn(false);    // plan 101 (0: 0) (37: 0)
            Isolate.WhenCalled(() => Directory.Exists(null)).WillReturn(true);    // plan 126 (0: 0) (36: 0)
            var myLogger = new MyLogger(LoggerType.DB);    // plan 142 (83: 0) (129: 0) (131: 0) (133: 0) (135: 0) (137: 0) (139: 0) (101: 0) (126: 0)
             
            // act
            myLogger.SetMessage(LoggerLevel.WARN, "WEB");    // plan 190 (142: 0) (175: 0) (81: 0)
        }

        #endregion


        #region Setup
        [SetUp]
        public void Setup_RunBeforeEachTest()
        {
            TestUtil.ResetAllStatics();
            TestUtil.AssertRunningInSandbox();
        }
        #endregion

    }
}