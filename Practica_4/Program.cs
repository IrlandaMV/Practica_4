using System;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {

            double c,f;

            Console.WriteLine("Dame los grados centigrados");
            c = Convert.ToDouble(Console.ReadLine());

            f = (c*1.8) + 32;

            Console.WriteLine("Los grados Farenheit son:{0}",f);

        }
    }
}
