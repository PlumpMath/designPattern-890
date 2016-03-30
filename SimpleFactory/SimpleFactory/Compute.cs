using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Compute
    {
        private Int32 _numberA;

        

        public Int32 NumberA
        {
            get
            {
                return _numberA;
            }

            set
            {
                _numberA = value;
            }
        }
        private Int32 _numberB;
        public Int32 NumberB
        {
            get
            {
                return _numberB;
            }

            set
            {
                _numberB = value;
            }
        }

        public abstract int GetResult();
       
    }
}
