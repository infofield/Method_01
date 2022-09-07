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
            Console.WriteLine(Sqr(2));

            int Sqr(int x)
            {
                int result = x * x;
                return result;
            }

        }

    }
}
