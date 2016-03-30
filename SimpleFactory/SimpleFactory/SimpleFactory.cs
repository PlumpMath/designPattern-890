using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class SimpleFactory
    {
        public static Compute GetComputeRes(String op)
        {
            Compute com = null;
           
            switch(op)
            {
                case "+":
                    com = new AddCompute();
                    break;
                case "-":
                    com = new SubCompute();
                    break;
                case "*":
                    com = new MulCompute();
                    break;
                case "/":
                    com = new DivCompute();
                    break;
                default:
                    
                    break;
            }
            return com;
        }
    }
}
