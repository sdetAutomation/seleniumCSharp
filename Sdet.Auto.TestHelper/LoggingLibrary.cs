using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.TestHelper
{
    public class LoggingLibrary
    {
        public static bool CompareResult(String actual, String expected)
        {

            if (actual == expected)
            {
                IoLibrary.WriteLine(String.Format("PASS: Actual({0}) | Expected({1})", actual, expected));
                return true;
            }
            else
            {
                IoLibrary.WriteLine(String.Format("FAIL: Actual({0}) | Expected({1})", actual, expected));
                return false;
            }
        }

        public static bool CompareResultContains(String actual, String expected)
        {

            if (actual.Contains(expected))
            {
                IoLibrary.WriteLine(String.Format("PASS: Actual({0}) | ExpectedToContain({1})", actual, expected));
                return true;
            }
            else
            {
                IoLibrary.WriteLine(String.Format("FAIL: Actual({0}) | ExpectedToContain({1})", actual, expected));
                return false;
            }
        }
    }
}
