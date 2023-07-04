

using System;

namespace MASYVAIUZDUOTIS21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             *Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus
             *(iškart su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
             *pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
             *skirtą studentų pažymiams saugoti;
              skirtą mašinų markėms saugoti.
            */

            string marke1 = "Opel";
            string marke2 = "Mazda";
            string marke3 = "Reno";

            string[] markiuMasyvasIsKonkreciuReiksmiu = {"Opel","Mazda","Reno"};
            string[] markiuMasyvasKonkretausDydzio = new string[3];

            markiuMasyvasKonkretausDydzio[1] = "Opel";
            markiuMasyvasKonkretausDydzio[2] = "Mazda";
            markiuMasyvasKonkretausDydzio[3] = "Reno";
            Console.WriteLine(markiuMasyvasIsKonkreciuReiksmiu[2]);

            int[] pazymiuMasyvas = new int[4];
            pazymiuMasyvas[0] = 8;
            pazymiuMasyvas[1] = 7;
            pazymiuMasyvas[2] = 4;
            pazymiuMasyvas[3] = 3;
            int[] pazymiuMasyvasIsKonkreciuReiksmiu = { 8, 7, 4, 3 };
            int[] pazymiuMasyvasKonkretausDydzio = new int[4];
            Console.WriteLine(pazymiuMasyvasIsKonkreciuReiksmiu[3]);

        }
    }
}
