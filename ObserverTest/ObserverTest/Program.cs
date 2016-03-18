using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Boss huhansan = new Boss();

            StockObserver tongshil = new StockObserver("围观宅", huhansan);

            NBAObserver tongshi2 = new NBAObserver("易茶冠", huhansan);

            huhansan.Attach(tongshil);
            huhansan.Attach(tongshi2);

            huhansan.Detach(tongshil);

            huhansan.SubjectState = "我胡汉三回来啦";

            huhansan.Notify();
            Console.ReadLine();
        }
    }
}
