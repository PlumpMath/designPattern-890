using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SubCompute : Compute
    {
        public override int GetResult()
        {
            return base.NumberA - base.NumberB;
            //throw new NotImplementedException();
        }
    }
}
