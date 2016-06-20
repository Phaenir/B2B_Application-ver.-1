using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNLog;

namespace APA
{
    class ApaProgram
    {
        

        public static void Main()
        {
            MyLogger logger=new MyLogger(LoggerType.XML);
            logger.SetMessage(LoggerLevel.DEBUG, "success work");
        }
    }
}
