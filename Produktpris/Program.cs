using System.Diagnostics;

namespace Produktpris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange produktens namn:");
            string product = Console.ReadLine();


            Console.WriteLine("Ange produktens pris:");
            double price = Convert.ToDouble(Console.ReadLine()); // pris är en variabel som lagrar produktens pris,
            //convert.toDouble omvandlar det som användaren skriver in till dicimal
            double tax = 0.25; // tax är en variabel som lagrar momsen


            Console.WriteLine("Ange antal produkter");
            int quantity = Convert.ToInt32(Console.ReadLine()); //quantity är en variabel som lagrar antal produkter,

            //jag använder Convert.ToInt32 för att omvandla det användaren skriver in till heltal//



            double totalPris = CalculateTotal(product, price, quantity, tax);
            Console.WriteLine("Du köpte " + quantity + " st " + product + ", totalpris (inkl. moms): " + totalPris + " kr");



            


        }
                                                
         static double CalculateTotal(string product, double price, int quantity, double tax = 0.25)
        {
            double total = (price * quantity) * (1 + tax);
            return total;

        }

    }
}
