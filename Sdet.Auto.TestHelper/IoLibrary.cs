using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.TestHelper
{
    public class IoLibrary
    {
        public static void WriteLine(string text)
        {
            Console.WriteLine(" ");
            Console.WriteLine(string.Format("### {0} ###", text));
        }

        public static void WritelineEnd()
        {
            Console.WriteLine("############");
            Console.WriteLine(" ");
        }

        public static string GetBinPath()
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembl‌​y().Location);
            return path;
        }

        public static void KillProcess(string processName)
        {
            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                if(process.ProcessName == processName)
                {
                    process.Kill();
                }
            }
        }
    }
}
