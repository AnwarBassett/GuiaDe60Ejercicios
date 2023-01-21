using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ejercicio #4 Determine la raíz Cuadrada de un número cualquiera.
                int n;
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("No puede agregar cero, numeros negativos o letras");
                    }
                } while (n<=0);
                Console.WriteLine("La raiz cuadrada de {0} es: {1}",n,(Math.Pow(n,2)));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error se encuentra en: "+ex.Message);
            }
            Console.ReadKey();
        }
    }
}
