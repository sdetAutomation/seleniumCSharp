using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.TestHelper
{
    public class TestAssert
    {
        private bool _pass;

        public TestAssert()
        {
            this._pass = true;
        }

        public bool Pass
        {
            get
            {
                return _pass;
            }
            set 
            {
                CheckPass(value);
            }
        }

        private void CheckPass(bool pass)
        {
            if (this._pass == true)
            {
                this._pass = pass;
            }
        }
    }
}
