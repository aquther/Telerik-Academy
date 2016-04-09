using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag=true;
            for (int i = 0; i < 1000; i++)
            {
                if (flag) { Console.WriteLine(2 + i); flag = false; }
                else { Console.WriteLine(-2 - i); flag = true;}
            }
        }
    }
}
