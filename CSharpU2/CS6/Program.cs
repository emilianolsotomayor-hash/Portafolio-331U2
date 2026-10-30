using System;

namespace CS6   // Oscar López 331-20
{
    class Program
    {
        static void Main(string[]args)
        {
            // Ciclo for
            /*
            for(inicialización); expresión; Iterador
            {
                Bloque de instrucciones
            }
            */
            // SEsión 14 ciclo for  Oscar López 331-20 
            // Ejemplo : Secuencia 35-41
            for(int m = 35; m <= 41; m++)
            {
                Console.WriteLine($"m:{m}");
                
            }
            // 1. Definir un ciclo for para la siguiente secuencia: -33,-34, hasta el -39
            for(int n = -33; n >= -39; n -=1)
            {
                Console.WriteLine($"n: {n*-1}");
            }
            Console.WriteLine("Ciclo ascendente");
            for(int a = 9; a <= 15; a++)
            {
                if (a != 13)
                {
                Console.WriteLine($"a: {a}");
                }
            }

            for(int pagina = 1; pagina <= 539; pagina +=1)
            {
                if (pagina == 88 || pagina == 88*2 || pagina == 88*3)
                {
                    Console.WriteLine("Titulo de capítulo");
                }
            }

        }
    }
}
