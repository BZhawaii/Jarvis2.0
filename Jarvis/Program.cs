using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Jarvis
{
    class Program
    {
        /// <summary>
        /// Where all the magic happens
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // This will pull the current CPU load in percentage
            PerformanceCounter perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            // Infinite while loop
            while(true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("CPU Load: {0}", perfCpuCount.NextValue());
            }
        }
    }
}
