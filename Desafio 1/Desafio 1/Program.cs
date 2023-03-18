using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números pares hasta {0} son:", numero);
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
