using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQL Server中给user 表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQL  server中获取User的记录一次");
            return null;
        }
    }
}
