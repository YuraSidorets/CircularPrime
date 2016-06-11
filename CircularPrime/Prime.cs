using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularPrime
{
    public static class Prime
    {
        public static List<int> Primes;

        public static int Find()
        {
            //primes 2 and 5 are the only exceptions
            Primes = new List<int> { 2, 5 };

            for (int i = 1; i < 1000000; i++)
            {
                if (PrimeNum(i))
                {
                    var ch = i.ToString().ToCharArray();
                    Array.Reverse(ch);
                    int reversed = Convert.ToInt32(new string(ch));

                    //except "1379" because circular prime only consists of the digits 1, 3, 7 and 9.
                    if (!i.ToString().ToCharArray().Except("1379").Any() && PrimeNum(reversed) && !Primes.Contains(i))
                    {
                        Primes.Add(i);
                    }
                }
            }
            return Primes.Count;
        }

        private static bool PrimeNum(int n)
        {
            if (n == 1)
                return false;
            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                    return false;
            }
            return true;
        }
    }
}
