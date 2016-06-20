using System.IO;
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
    public class GetLoggerTypeTests
    {
        #region Unit Tests for GetLoggerType
        
        [Test]
        public void GetLoggerTypeByCallingMyNLog_MyLogger__ctor_Test_NoAsserts()
        {
            // MyNLog.MyLogger..ctor(LoggerType)(6)=[VVVVVV]
            // MyNLog.MyLogger.GetLoggerType(LoggerType)(8)=[VVVXXXXV]
             
            // arrange
            Isolate.WhenCalled(() => File.Exists(null)).WillReturn(true);    // plan 109 (0: 0) (36: 0)
            Isolate.WhenCalled(() => Directory.Exists(null)).WillReturn(true);    // plan 110 (0: 0) (36: 0)
             
            // act
            var result = new MyLogger(LoggerType.DB);    // plan 215 (85: 0) (0: 0) (200: 0) (203: 0) (206: 0) (209: 0) (212: 0) (109: 0) (110: 0)
        }

        
        [Test]
        public void GetLoggerTypeByCallingMyNLog_MyLogger__ctor_Test_NoAsserts_001()
        {
            // MyNLog.MyLogger..ctor(LoggerType)(6)=[VVVVVV]
            // MyNLog.MyLogger.GetLoggerType(LoggerType)(8)=[VVXXVXXV]
             
            // arrange
            Isolate.WhenCalled(() => File.Exists(null)).WillReturn(true);    // plan 109 (0: 0) (36: 0)
            Isolate.WhenCalled(() => Directory.Exists(null)).WillReturn(true);    // plan 110 (0: 0) (36: 0)
             
            // act
            var result = new MyLogger(LoggerType.WEB);    // plan 1306 (87: 0) (1291: 0) (1294: 0) (1297: 0) (1300: 0) (0: 0) (1303: 0) (109: 0) (110: 0)
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