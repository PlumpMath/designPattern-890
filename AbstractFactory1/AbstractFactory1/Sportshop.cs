using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public abstract class Sportshop
    {
        /// <summary>
        /// 产生Shoes and Hat 的抽象工厂
        /// </summary>
        /// <returns></returns>
        public abstract Shoes CreateShoes();


        public abstract Hat CreateHat();
    }
}
