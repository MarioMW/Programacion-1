using System;

namespace ejercicio_practico_2do_corte
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena ="";
            int edad = 0;
            int altura = 0;
            
            
            Console.WriteLine("¡Hola! Bienvenido a Disneyland, por favor indicanos tu edad");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            
            
            if(edad > 16)
            {
                Console.WriteLine("Disculpe ha superado el limite de edad para la seccion de juegos infantiles");
            }
            else
            {
                
                
                Console.WriteLine("Bienvenido, puedes ingresar a la seccion de juegos infantiles");
                
                Console.WriteLine("Ahora, ¿Podrías indicarnos tu estatura? en centimetros por favor");
                cadena = Console.ReadLine();
                altura = Convert.ToInt32(cadena);
                
                if(altura < 160)
                {
                Console.WriteLine("Puedes ir Dumbo The Flying Elephant, Cinderella Castle y It´s a small world");    
                }
                else
                {
                    Console.WriteLine("Puedes ir a todos los juegos del parque");
                }
            }
        }
    }
}   
