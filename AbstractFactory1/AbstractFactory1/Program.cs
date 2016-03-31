using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hat hat = null;
            Shoes shoes = null;
            Sportshop sportShop = null;
            sportShop = new NikeShop();
            shoes = sportShop.CreateShoes();
            hat = sportShop.CreateHat();

            Console.WriteLine("鞋子：{0} 帽子：{1}", shoes.ToString(), hat.ToString());
            Console.ReadLine();
        }
    }

















}

