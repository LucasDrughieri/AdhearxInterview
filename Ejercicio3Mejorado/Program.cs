using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Ejercicio3
{
    class Program
    {
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese ceros iniciales:");
            int zerosExpected = Convert.ToInt32(Console.ReadLine());

            int numberLength = Random.Next(1, 9);
            string randomNumber = GenerateRandomNumber(numberLength);

            string hashedData = string.Empty;
            int attempts = 0;

            string expectedResult = new string('0', zerosExpected);

            do
            {
                attempts++;
                hashedData = ComputeSha256Hash(randomNumber + GenerateRandomNumber(numberLength));

            } while (!hashedData.StartsWith(expectedResult));

            Console.WriteLine($"Número de ceros iniciales: {zerosExpected}");
            Console.WriteLine($"Hash: {hashedData}");
            Console.WriteLine($"Número aleatorio: {randomNumber}");
            Console.WriteLine($"Número de intentos necesarios: {attempts}");

            Console.ReadKey();
        }

        private static string GenerateRandomNumber(int length)
        {
            const string chars = "0123456789";
            return Random.Next(1, 9).ToString() + new string(Enumerable.Repeat(chars, length-1).Select(s => s[Random.Next(s.Length-1)]).ToArray());
        }

        static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
