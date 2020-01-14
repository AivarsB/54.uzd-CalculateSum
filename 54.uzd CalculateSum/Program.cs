using System;

namespace _54.uzd_CalculateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter x: ");
                var x = int.Parse(Console.ReadLine());
                Console.Write("Enter y: ");
                var y = int.Parse(Console.ReadLine());

                Console.WriteLine(Calculate.CalculateSum(x, y));

                Console.WriteLine("Press enter to continue");
                Console.ReadLine();

            } while (true);
        }
    }
}
// Izveidot static metodi CalculateSum atsevišķā failā. Metodei , kā parametri ir jāsaņem divas int vērtības x un y.
// Šai metodei ir jāatgriež šo skaitļu summa. Šo metodi ir jāizmanto vairākas reizes galvenajā programmā.
