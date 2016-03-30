using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Compute com = null;
            Console.WriteLine("请输入第一个数字：");
            Int32 a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第二个数字");
            Int32 b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入：+、-、*、/");
            String op = Console.ReadLine();

            //com.NumberA = a;
            //com.NumberB = b;
            com = SimpleFactory.GetComputeRes(op);
            com.NumberB = b;
            com.NumberA = a;
            int result = com.GetResult();
            Console.WriteLine("结果是: {0}", result);
            Console.ReadKey();

        }
    }
}
