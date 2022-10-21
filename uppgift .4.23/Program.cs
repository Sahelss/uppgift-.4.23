using System;
namespace uppgift_4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");

            int tal = int.Parse(Console.ReadLine());

            int störst = tal;

            string svar = "";
            while (svar != "n")
            {
                Console.WriteLine("Vill du skriva in ett till heltal? (j/n)");
                svar = Console.ReadLine();

                if (svar == "n")
                {
                    break;
                }
                Console.WriteLine("Skriv in ett heltal");
                int nyttTal = int.Parse(Console.ReadLine());

                if (nyttTal > störst)
                {
                    störst = nyttTal;
                }

            }

            Console.WriteLine($"Det största talet du skrev var {störst}");
        }
    }
}