using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    /// <summary>
    /// concrete product producer Nike
    /// </summary>
    public class NikeShop : Sportshop
    {
        public override Hat CreateHat()
        {
            return new NikeHat();
            //throw new NotImplementedException();
        }

        public override Shoes CreateShoes()
        {
            //throw new NotImplementedException();
            return new NikeShoes();
        }
    }

    public class NikeHat : Hat
    {
        public override string ToString()
        {
            return "Nike Hat";
        }
    }


    public class NikeShoes : Shoes
    {
        public override string ToString()
        {
            return "Nike Shoes";
        }
    }
}
