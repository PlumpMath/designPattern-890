using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class MulCompute : Compute
    {
        public override int GetResult()
        {
            //throw new NotImplementedException();
            return base.NumberB * base.NumberA;
        }
    }
}
