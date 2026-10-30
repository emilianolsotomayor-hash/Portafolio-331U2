using System;

namespace CS5    // Oscar López 331-20
{
    class Program
    {
        static void Main(string[]args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad2 Funciones II
            // Sesión 12 : Instrucción while
            // Sintaxis Whiles
            // Inicialización;
            // While( expresión)
            /*
            {
                    Bloque de instrucciones
                    iterador;
            }
            */ // Iterador = instrucción que me ayuda a repetir o termonar el ciclo.
            // Ejemplo 1: Ciclo ascendente ( rango de 1-3 )
            // m = variable de inicialización
            int m = 1; // Inicialización :)
            while (m <= 3)
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1;
            }
            // Ejercitacióm definir un ciclo para imprimir to nombre 5 veces
            // Nota para la expresión usar el operador usar menor que
            // Ciclo ascendente.
            int n = 0;
            while ( n <5)
            {
                Console.WriteLine("Oscar López");
                n += 1;
            }
            // Ciclo descendente
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine("d. {d}");
                d -= 1;
            }
            // C. Incrementos
            // Secuencia:  3 6 9 12 15 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            // Decrementos
            // Definir un ciclo para imprimir 331 8 veces
            int f = 16;
            while(f >= 2)
            {
                Console.WriteLine($"f: {f}");
                f -= 2;
            }
            // Actividad 1: Ciclo Infinito
            // 1. Definir un ciclo infinito ascendento.
            // 2 Definir un ciclo infinito descendente
            // Nota : Para la solución usar el operador de diferencia en el ultimo
            int s = 2;
            while ( s >= 2)
            {
                Console.WriteLine("s: {s}");
                s += 1;
            }
            int a = 0;  // Oscar López 331-20
            while ( a != 2)
            {
                Console.WriteLine($"a: {a}");
                a -= 1;
            }
        }
    }
}
