using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count: "+Prime.Find());
            Console.WriteLine();

            foreach (int circularPrime in Prime.Primes)
            {
                Console.WriteLine(circularPrime);
            }
            Console.CursorTop = 0;
            Console.ReadLine();
        }
    }
}
