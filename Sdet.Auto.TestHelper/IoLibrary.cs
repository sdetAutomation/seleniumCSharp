using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
