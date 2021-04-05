using System;
using System.Security.Cryptography;
using System.Text;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese ceros iniciales:");
            int zeros = Convert.ToInt32(Console.ReadLine());
            int randomNumber = new Random().Next(1, 999999999);
            string hashedData = string.Empty;
            int attempts = 0;

            do
            {
                attempts++;
                hashedData = ComputeSha256Hash(randomNumber.ToString());

            } while (!hashedData.StartsWith(GetZeros(zeros)));

            Console.WriteLine(hashedData);
            Console.WriteLine(attempts);

            Console.ReadKey();
        }

        static string GetZeros(int zeros)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < zeros; i++)
            {
                sb.AppendLine("0");
            }

            return sb.ToString();
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
