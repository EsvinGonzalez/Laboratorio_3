using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puntaje_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int suma = 0;
            int puntaje;

            while (true)
            {
                Console.WriteLine("Ingrese un puntaje entre 1 a 60 y escribe fin para ver el resultado :");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "fin")
                {
                    break;
                }

                if (!int.TryParse(entrada, out puntaje) || puntaje < 1 || puntaje > 60)
                {
                    Console.WriteLine("Entrada no valida. Ingrese un número entre 1 y 60 y escriba fin para ver el resultado.");
                    continue;
                }

                contador++;
                suma += puntaje;
            }

            if (contador == 0)
            {
                Console.WriteLine("No se ingresaron promedios.");
            }
            else
            {
                double promedio = (double)suma / contador;
                Console.WriteLine("El puntaje promedio es {0:0.00}.", promedio);
            }

            Console.ReadKey();
        }
    }
}
