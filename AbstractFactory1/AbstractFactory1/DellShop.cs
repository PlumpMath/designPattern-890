using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    /// <summary>
    /// concrete products producer Dell
    /// </summary>
     public class DellShop : Sportshop
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
