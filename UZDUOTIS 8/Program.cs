

using System;

namespace UZDUOTIS_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Liepkite vartotojui įvesti bet kokį sveikąjį skaičių.
             * 
             * Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.
             * Pvz.:
             * 2 * 1 = 2
             * 2 * 5 = 10
             */

            Console.WriteLine(1*1);
            Console.WriteLine(1*2);
            Console.WriteLine(1*3);
            Console.WriteLine(1*4);
            Console.WriteLine(1*5);
            Console.WriteLine();

            /* Liepkite vartotojui įvesti tris skaičius. 
             * Į ekraną išveskite šiuos skaičius ir jų vidurkį. 
             * Pvz.:
             * Įvestų skaičių 4, 5, 8 vidurkis: 5,7.
             */

            int pirmas = 4;
            int antras = 5;
            int trecias = 8;
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Sqrt(5));
            Console.WriteLine(Math.Sqrt(8));


            /* Liepkite įvesti tris skaičius. 
             * Išveskite įvestus skaičius, 
             * jų kvadratus, juos pakeltus trečiuoju laipsniu, 
             * taip pat tuos skaičius, padalintus iš dviejų.
             */

            var a = 3;
            var b = 5;
            var c = 7;
            Console.WriteLine(3);
            var pirmasStr = Console.ReadLine();
            Console.WriteLine(5);
            var antrasStr = Console.ReadLine();
            Console.WriteLine(7);
            var treciasStr = Console.ReadLine();
            Console.WriteLine(3 * 3);

            Console.WriteLine(5 * 5);
            Console.WriteLine(7 * 7);
            Console.WriteLine(Math.Pow(9,3));
            Console.WriteLine(Math.Pow(25,3));
            Console.WriteLine(Math.Pow(49,3));
            Console.WriteLine(Math.Pow(729,2));
            Console.WriteLine(Math.Pow(15625,1/2));
            Console.WriteLine(Math.Pow(117649,1/2));
            Console.WriteLine();
        }

    }

}
