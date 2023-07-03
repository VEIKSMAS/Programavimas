using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,
              kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes.
              Pvz.: 4 + 5 = 9
              4 - 5 = -1
            */
              int sudetis = 3 + 3;
              Console.WriteLine(sudetis);
…             Console.WriteLine(3-3);
              Console.WriteLine(3*3);
              Console.WriteLine();

            /*Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.
             */
              Console.WriteLine(Math.Pow (36,3));
              Console.WriteLine();

            /*Išveskite į ekraną trijų skaičių sandaugą.
             */
              Console.WriteLine(6 * (3 + 3)); 
              Console.WriteLine();

        }
    }
}
