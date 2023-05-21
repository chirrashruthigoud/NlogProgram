using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProblems
{
    public class Program
    {//Nlog is open-source log platform 
        //download it from the nugget package in visual studio.
        //types of log-methods => 1.trance:detailed log 
        //2.debug:debugging information
        //3.info message:information
        //4.warning: warning message
        //5.error:error message
        static void Main(string[] args)
        {
            AddNumber add = new AddNumber();
            Console.WriteLine(add.Sum(1, 0));
            Console.ReadLine();

        }
    }
}
