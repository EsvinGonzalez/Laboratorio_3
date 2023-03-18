using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicar
{
    internal class Pared
    {
        public double Alto { get; set; }
        public double Largo { get; set; }
        public double SuperficieFrontal { get { return Alto * Largo; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pared pared = new Pared();
            pared.Alto = 5.10;
            pared.Largo = 10.15;

            Console.WriteLine("La superficie frontal es {0:0.00}.", pared.SuperficieFrontal);

            Console.ReadKey();
        }
    }
}
