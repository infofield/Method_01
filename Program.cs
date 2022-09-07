using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqr = Sqr(2);
            Console.WriteLine(sqr);

            int Sqr(int x)
            {
                int result = x * x;
                return result;
            }
        }
    }
}
