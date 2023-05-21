using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProblems
{
    public class AddNumber
    {
        private readonly Nlog nlog = new Nlog();
        public int Sum(int first, int second)
        {
            if (first == 0 || second == 0)
            {
                nlog.LogDebug("Debug successfully.");
                nlog.LogError("having null value");
                nlog.LogWarning("any numbers should not equal to zero");

            }
            int result = first + second;
            nlog.LogDebug("Return successfully.");
            nlog.LogInfo("hello" + result);
            return result;
        }
    }
}
