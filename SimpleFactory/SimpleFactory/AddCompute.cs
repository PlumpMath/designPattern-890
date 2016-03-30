using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class AddCompute : Compute
    {
        public override int GetResult()
        {
            //throw new NotImplementedException();
            return base.NumberA + base.NumberB;
        }
    }
}
