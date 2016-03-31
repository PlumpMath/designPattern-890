using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanjet.T.PU.ReflectorCai
{
    /// <summary>
    /// 具体的工厂2
    /// </summary>
    public class NikeShop : Chanjet.T.PU.ReflectorCai.Sportshop
    {
        public override Hat CreateHat()
        {
            return new NikeHat(); 
            //throw new NotImplementedException();
        }

        public override Shoes CreateShoes()
        {
            return new NikeShoes();
            //throw new NotImplementedException();
        }
    }


    /// <summary>
    /// 生产具体的产品B
    /// </summary>
    public class NikeShoes : Shoes
    {
        public override string ToString()
        {
            return "Nike Shoes";
        }
    }

    public class NikeHat : Hat
    {
        public override string ToString()
        {
            return "Nike Hat";
        }
    }
}
