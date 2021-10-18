using System;

namespace ejercicio_practico_1er_corte
{
    class Program
    {
        static void Main(string[] args)
        {
            int valora;
            int valorb;
            int valorc;

            valora = 15;
            valorb = 50;
            valorc = 23;

            Console.WriteLine("Combinacion de variables en orden aacb");
            Console.Write(valora);
            Console.Write(valora);
            Console.Write(valorc);
            Console.WriteLine(valorb);
            Console.WriteLine("--------");


            Console.WriteLine("Combinacion de variables en orden bca");
            Console.Write(valorb);
            Console.Write(valorc);
            Console.WriteLine(valora);
            Console.WriteLine("--------");

            Console.WriteLine("Combinacion de variables en orden bcbc");
            Console.Write(valorb);
            Console.Write(valorc);
            Console.Write(valorb);
            Console.WriteLine(valorc);
            Console.WriteLine("--------");
        }
    }
}
