using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("El número debe ser mayor que 0.");
            }
            else
            {
                bool esPrimo = true;
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.WriteLine("{0} es un número primo.", numero);
                }
                else
                {
                    Console.WriteLine("{0} no es un número primo.", numero);
                }
            }

            Console.ReadKey();
        }
    }
}
