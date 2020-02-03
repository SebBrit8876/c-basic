using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, estatura, resultado, i = 703;

            Console.WriteLine("digite su peso:");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite su estatura: ");
            estatura = Convert.ToDouble(Console.ReadLine());

            resultado = (peso * i) % (estatura * estatura);

            Console.WriteLine("su imc es: " + resultado);
            Console.ReadKey();
        }
    }
}
