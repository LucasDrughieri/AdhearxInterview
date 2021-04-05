using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int frecuencyQuantity = 0;
            string bandType = string.Empty;

            do
            {
                Console.WriteLine("Ingrese cantidad de frecuencias:");

            } while (!int.TryParse(Console.ReadLine(), out frecuencyQuantity));

            do
            {
                Console.WriteLine("Ingrese tipo de banda (AM/FM):");
                bandType = Console.ReadLine();

            } while (!Enum.IsDefined(typeof(BandTypes), bandType));

            var result = GetRandomStations(frecuencyQuantity, (BandTypes) Enum.Parse(typeof(BandTypes), bandType));

            StringBuilder sb = new StringBuilder();

            foreach (var item in result)
            {
                sb.AppendLine(item);
            }

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }

        private static List<string> GetRandomStations(int frecuencyQuantity, BandTypes bandType)
        {
            var radio = RadioFrecuencyFactory.GetInstance(bandType);

            return radio.GetRandomStations(frecuencyQuantity);
        }
    }
}
