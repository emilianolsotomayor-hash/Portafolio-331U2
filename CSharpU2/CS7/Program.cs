using System;

namespace CS7   //Oscar López 331-20
{
    class Program
    {
        static void Main(string[]args)
        {
            // 15- Funciones 15/10/2026
            // Funciones: Es un bloque de instrucciones para realizar una tarea especifica que se ejecuta unicamente cuando es invocado.
            // Parametros: Variables para iniciar una función.
            // Argumentos: Valores correspondientes a los parametros.
            /*Sintaxis
            1. Tipo_dato_devuelta identificador_funcion(parametros)
            {
                Bloque de instrucciones
            }
            Nota: Los parametros se definen incluyendo el tipo de dato .
            Nota 2: Los parametros van separados por comas.
            Sintaxis : Invocación función.
            identificador_funcion(argumentos)
            */
            // Ejemplo 1- Función vacia sin parametros
            void Saludar()
            {
                string salon = "Exactas 331";
                Console.WriteLine($"¡Hola, {salon}!");
            }
            // Invocación
            Saludar();
            // Ejercitación
            // 1_ Definir e invocar una funcion sin parametros para imprimir nombre, clave y salon.
            void Datos()
            {
                string nombre = "Oscar López";
                int clave = 20;
                int salon = 331;
                Console.WriteLine($"Tus datos son; {nombre}, {salon},{clave}");
            }
            Datos();

            // 2. Definir e invocar una función para desplegar el horario de hoy.
           void Horario()
           {
            string clase_1 = "7:00 calculo";
            string clase_2 = "7:50 fh";
            string clase_3 = "8:40 programación";
            string clase_4 = "9:50 psicología";
            string clase_5 = "10:40 idiomas";
            string clase_6 = "11:50 a 1.30 dibujo tecnico";
            Console.WriteLine($"Tu horario es : {clase_1}, {clase_2}, {clase_3}, {clase_4},{clase_5}, {clase_6}");
            // return : Palabra reservada para terminar una función y delvolver una función.
            

           }
           Horario();

           // Ejemplo 1: Doble
           // Definición de función
           int CalcularDoble(int número)
            {
                int resultado = 2 * número;
                return resultado;
            }
            // Invocación
            int devolución;
            devolución = CalcularDoble(9);
            Console.WriteLine($"Devolución: {devolución}");
            // 1- definir una función que devuelva la evaluación de la siguiente expresión. F(x)= 4x - 7/5.
            double funcionx(double x)
            {
                
                double despeje = 4 * x - 7/5D;
                return despeje;
            }
            double solución ;
            solución = funcionx(6);
            Console.WriteLine($"funciónx: {solución}");



        
    
            
        }
    }
}