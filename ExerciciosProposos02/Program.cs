using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double formulaDePi = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = " + formulaDePi.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
