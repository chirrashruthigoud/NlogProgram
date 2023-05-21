using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProblems
{
    public class Nlog
    {
        //logger :-filetring a log data
        //logmanger is a inbuilt class from current class
        //currentclassLogger 
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string s)
        {

            logger.Debug(s);
        }
        public void LogError(string s)
        {
            logger.Error(s);
        }
        public void LogInfo(string s)
        {
            logger.Info(s);
        }
        public void LogWarning(string s)
        {
            logger.Warn(s);
        }
    }
}
