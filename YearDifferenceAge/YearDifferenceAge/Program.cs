using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearDifferenceAge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s =Console.ReadLine();
            
            string m = s.Substring(0, 2);
            string d = s.Substring(3, 2);
            string y = s.Substring(6, 4);
            int a = Convert.ToInt32(m);
            int b = Convert.ToInt32(d);
            int c = Convert.ToInt32(y);
           
            DateTime now = DateTime.Now;
            DateTime me = new DateTime(c,a,b, now.Hour, now.Minute, now.Second);
            int diff = now.Year - me.Year;
            if (me.DayOfYear > now.DayOfYear) diff--;
            Console.WriteLine(diff);
            Console.WriteLine(diff + 10);
            ;
        }
    }
}
