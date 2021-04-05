using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToDivide = 3;
            Dictionary<int, int> result = new Dictionary<int, int>();
            int index = 1000;

            while(numberToDivide < 18)
            {
                var acumulatedNumbers = new List<int>();

                while(acumulatedNumbers.Count < numberToDivide)
                {
                    if (index % numberToDivide == 0)
                    {
                        acumulatedNumbers.Add(index);
                    }

                    index++;
                }

                result.Add(numberToDivide, acumulatedNumbers.Sum());

                numberToDivide++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"Suma de numeros divisibles por {item.Key}: {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
