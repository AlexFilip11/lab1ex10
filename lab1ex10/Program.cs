using System;

namespace lab1ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma cifrelor unui numar de 2 cifre
            Console.WriteLine("Introduceti un numar de doua cifre: ");
            int a = int.Parse(Console.ReadLine());
            int suma = a % 10 + a / 10;
            Console.WriteLine("Suma cifrelor numarului " + a + " este " + suma);
        }
    }
}
