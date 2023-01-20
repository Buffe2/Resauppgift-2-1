using System;
namespace Uppgift_2._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken stad kommer du ifrån?");
            string strNr1 = Console.ReadLine();
            Console.WriteLine("Vart är din drömresa?");
            string strNr2 = Console.ReadLine();
            Console.WriteLine("Hej " + strNr1 + "s bo. " + "Jag hoppas du får resa till " + strNr2 + ". :)");
        }
    }
}