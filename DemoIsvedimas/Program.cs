

using System;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviskų  simbolių rodymas
            Console.BackgroundColor = ConsoleColor.Red;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Labas Rytas");
            Console.Write("Labas Rytas");
            Console.WriteLine();

            Console.Write("Labas ");
            Console.Write("Rytas");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ąčėęš");

            // Kintamųjų išvedimas
            string vardas = "Petras";
            int amzius = 25;
            Console.WriteLine(vardas);
            Console.WriteLine(amzius);

            // Teksto ir kintamojo išvedimas
            Console.WriteLine("Labas,mano vardas:Petras,mano amzius: 25.");

            //  1 būdas

            Console.WriteLine("Labas,mano vardas:" + vardas + ",mano amzius: " + 25 + ".");

            // 2 būdas

            Console.WriteLine("Labas,mano vardas:{0},mano amzius: {1}.",vardas,amzius);

            // 3 būdas (String interpalation)

            Console.WriteLine($"Labas,mano vardas:{vardas},mano amzius: {amzius}.");
            
            






        }
    }
}
