using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    class StockObserver :Observer
    {
        public StockObserver(string name, Subject sub):base(name, sub)
        {

        }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作！", sub.SubjectState, name);
            //throw new NotImplementedException();
        }
    }

    class NBAObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("{0}, {1}关闭NBA直播，继续工作", sub.SubjectState, name);
            //throw new NotImplementedException();
        }
        public NBAObserver(string name, Subject sub) :base(name, sub)
        {

        }
    }
}
