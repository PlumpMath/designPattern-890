using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanjet.T.PU.ReflectorCai
{
    /// <summary>
    /// 具体的工厂1
    /// </summary>
    public class DellShop : Chanjet.T.PU.ReflectorCai.Sportshop
    {
        public override Hat CreateHat()
        {
            return new DellHat();
            //throw new NotImplementedException();
        }

        public override Shoes CreateShoes()
        {
            return new DellShoes();
            //throw new NotImplementedException();
        }
    }


    /// <summary>
    /// 生产具体的产品啊
    /// </summary>
    public class DellShoes : Shoes
    {
        public override string ToString()
        {
            return "Dell Shoes";
        }
    }

    public class DellHat : Hat
    {
        public override string ToString()
        {
            return "Dell Hat";
        }
    }
}
