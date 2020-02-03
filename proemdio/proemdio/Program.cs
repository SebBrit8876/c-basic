using System;

namespace proemdio
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1, c2, c3, c4, tc, p;

            Console.WriteLine("digite su clalificacion");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite su clalificacion");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite su clalificacion");
            c3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite su clalificacion");
            c4 = Convert.ToInt32(Console.ReadLine());

            tc = c1 + c2 + c3 + c4;
            p = tc / 4;

            Console.WriteLine(" el total es {0}",tc);
            Console.WriteLine("el promedio de las calificaciones es {0}", p);
            Console.ReadKey();

            if ( p >= 90)
            {
                Console.WriteLine("usted saco A");
            }

            if (p >= 80)
            {
                Console.WriteLine("usted saco B");
            }

            if (p >= 70)
            {
                Console.WriteLine("usted saco C");
            }

            if (p < 70)
            {
                Console.WriteLine("usted es un penco");
            }
        }
    }
}
