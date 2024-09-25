using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void CountTo(int lastNumber)
        {
            for (int aktualniCislo = 1; aktualniCislo < lastNumber; aktualniCislo++)
            {
                if (aktualniCislo % 3 == 0 && aktualniCislo % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    return;
                }

                if (aktualniCislo % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    return;
                }

                if (aktualniCislo % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    return;
                }

                Console.WriteLine(aktualniCislo);
            }
        }
    }
}
