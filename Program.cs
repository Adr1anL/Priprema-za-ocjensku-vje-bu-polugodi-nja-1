using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzvjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;

            prvi:  Console.Write("Unesi a  (prva kateta): ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x <= 0)
            {
                Console.WriteLine("Unos je manji od 0!!");
                goto prvi;
            }

            drugi:  Console.Write("Unesi b (druga kateta): ");
            y = Convert.ToInt32(Console.ReadLine());

            if (y <= 0)
            {
                Console.WriteLine("Unos je manji od 0!!");
                goto drugi;
            }

            treci:  Console.Write("Unesi c   (hipotenuza): ");
            z = Convert.ToInt32(Console.ReadLine());

            if (z <= 0)
            {
                Console.WriteLine("Unos je manji od 0!!");
                goto treci;
            }

            if (z <= x || z <= y)
            {
                Console.WriteLine("Stranica c nije hipotenuza!!");
                goto prvi;
            }

            if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2)) Console.WriteLine("To su stranice pravokutnog trokuta!");
            else Console.WriteLine("To nisu stranice pravokutnog trokuta.");

            Console.ReadKey();
        }
    }
}
