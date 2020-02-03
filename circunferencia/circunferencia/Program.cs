using System;

namespace circunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 3.14, num2, resultado;
           

            Console.WriteLine("digite el radio: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = num1 * num2;

            Console.WriteLine("la circunferencia es: " + resultado);

            Console.ReadKey();

        }
    }
}
