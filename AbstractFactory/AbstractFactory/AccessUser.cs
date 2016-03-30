using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessUser : IUser
    {
        public IUser GetUser(int id)
        {
            Console.WriteLine("在Access中获取User一次");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在Access中插入一条信息");
        }

   
    }
}
