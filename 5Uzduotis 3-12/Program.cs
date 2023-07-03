using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Uzduotis_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*UZDUOTIS 6
             * 
             * Išveskite pasirinkto skaičiaus daugybos lentelę.
             * Pvz.: 5 * 0 = 0
             * 5 * 1 = 5
             *5 * 10 = 50
             */

            int daugyba = 4 * 3;
            Console.WriteLine(4 * 3);
            Console.WriteLine();

            int skaicius = 7*7;
            Console.WriteLine(skaicius);
            Console.WriteLine();

            /*Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. 
             * Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
             */

            int skaicius = 25;
            Console.WriteLine(5 * 5);
            Console.WriteLine();


            /* UZDUOTIS 7
             * Liepkite vartotojui įvesti savo vardą ir amžių.
             * Į ekraną išveskite: “Jūsų vardas { vardas}, o amžius { amžius}.”
             */
                 TRYS-  BANDYMAI


            Console.WriteLine("Asta");
            var vardas = Console.ReadLine();
            Console.WriteLine("25");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine("Asta + 25");

            //


            string vardas = string.Empty;
            int amzius;
            Console.WriteLine("Asta:");
            vardas = Console.ReadLine();
            Console.WriteLine("25:");
            amzius = Console.ReadLine();
            amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Asta,25", vardas, amzius);

            //

            string vardas = "Asta";
            int amzius = 20;
            Console.WriteLine(vardas);
            Console.WriteLine(amzius);
            Console.WriteLine("Mano vardas:Asta,mano amzius:20");




            /*Liepkite vartotojui įvesti bet kokį simbolį.
             * Atspausdinkite 3x3 kvadratą iš to simbolio.
             */



            /*Liepkite vartotojui įvesti bet kokį skaičių. 
             *Išveskite į ekraną šio skaičiaus kvadratą.
             */

            Console.WriteLine(7 * 7);


            /*Liepkite vartotojui įvesti tris skaičius.
             * Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, 
             * nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.:
             * 5 + 3 + 8 = 16
             * 5 - 3 - 8 = -6...
             */

            Console.Write("Iveskite pirma skaiciu:1");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antras skaiciu:8");
            var antras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite trecia skaiciu:9");
            var trecias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{1} + {8} + {9} = {3}", pirmas, antras, trecias, pirmas + antras + trecias);




        }
    }
}
