

using
using System;

namespace Uzduotis_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Išveskite į ekraną
             *norimo dydžio tuščiavidurį kvadratą iš žvaigždučių.
              ****
              *	 *
              *	 *
              ****
             *Susikurkite reikiamus kintamuosius užduočiai atlikti. 
             *Į ekraną išveskite: Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
             *Tarp {} nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti
             *įstatytos.
             */

            string marke = "Mazda";
            string modelis = "Lupo";
            int metai = 2000;
            int rida = 12000;
            Console.WriteLine("Automobilio {Mazda}marke {Lupo} modelis ({2000} metai {12000} rida");
        }
    }
}
}
