using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanjet.T.PU.ReflectorCai
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class Sportshop
    {
        public abstract Shoes CreateShoes();

        public abstract Hat CreateHat();

    }

    
}
