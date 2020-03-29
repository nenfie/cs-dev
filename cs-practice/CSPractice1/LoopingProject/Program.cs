using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LoopingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR Looping
            for (int angka = 1; angka <= 10; angka++)
            {
                Console.WriteLine("Angka ke " + angka.ToString());
            }

            Console.ReadLine();


            // FOREACH Looping
            foreach (int angka in new ArrayList { 1, 2, 3, 4, 5 })
            {
                Console.WriteLine("Angka ke " + angka.ToString());
            }

            Console.ReadLine();

            // WHILE Looping
            int angka2 = 1;
            do
            {
                Console.WriteLine("Angka ke " + angka2.ToString());
                angka2++;

            } while (angka2 <= 10);

            Console.ReadLine();

        }
    }
}
