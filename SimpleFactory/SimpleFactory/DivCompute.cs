using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class DivCompute : Compute
    {
        public override int GetResult()
        {

            if (base.NumberB == 0)
                throw new ArgumentException("Argument exception");
            return base.NumberA / base.NumberB;
        }
    }
}
