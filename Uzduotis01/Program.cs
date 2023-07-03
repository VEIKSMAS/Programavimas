
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Parašykite programą, kuri išvestų žodį “Labas” 
             * ir jūsų vardą toje pačioje eilutėje.
             */
              Console.WriteLine("Gerai");

             /*
             * Susikurkite kintamąjį žmogaus amžiui nusakyti,
             * išveskite į ekraną tekstą su
              šiuo amžiumi: “Įvestas amžius: { amžius}”. 
              Tarp { } nurodytas kintamasis, 
              kurio reikšmė toje vietoje turi būti įstatyta.
             */
              int amzius = 20;
              Console.WriteLine("Įvestas amzius: { amzius");

             /*
              Susikurkite skaičiaus kintamąjį,
              kurį išveskite penkis kartus 
              toje pačioje eilutėje be tarpų tarp šių skaičių
              (skaičius -25, išvedimas - 2525252525).
             */
              int skaicius = -25;
              Console.WriteLine("Mano skaicius:{0},mano skaicius:{4}.", skaicius);




             /*
             Susikurkite skaičiaus kintamąjį,
             kurį išveskite penkis kartus toje pačioje
             eilutėje su tarpais tarp šių skaičių
             (skaičius -25, rezultatas - 25 25 25 25 25).

            */

             int skaicius = -25;
             Console.WriteLine("Mano skaicius:" + skaicius + ", mano skaicius: " + 25  +  ", + 25 + ", + 25 + ", + 25 + ",+ 25 +";,"
        }
    }
}










