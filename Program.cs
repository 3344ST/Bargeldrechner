using System.Text;

namespace Bargeldrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] geld = { "500€ Schein", "200€ Schein", "100€ Schein", "50€ Schein", "20€ Schein", "10€ Schein", "5€ Schein", "2€ Münze", "1€ Münze", "50 Cent", "20 Cent", "10 Cent", "5 Cent", "2 Cent", "1 Cent" };
            int[] centBetrag = { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("Geben Sie den zu zahlenden Betrag ein: ");
            decimal betrag = Convert.ToDecimal(Console.ReadLine());
            decimal gegeben = 0;


            while (true)
            {

                Console.WriteLine("Geben Sie den bezahlten Betrag ein");
                gegeben = Convert.ToDecimal(Console.ReadLine());

                if (betrag < gegeben)
                {
                    break;
                }
                else if (betrag == gegeben)
                {
                    Console.WriteLine("Passt überein");
                    return;
                }
                Console.WriteLine("Der Betrag ist zu niedrig");
            }

            decimal rueckgeld = gegeben - betrag;
            Console.WriteLine(" Rückgeld:" + rueckgeld + " € ");

            decimal rueckgeldInCent = rueckgeld * 100;
            Console.WriteLine(rueckgeldInCent);

            for (int i = 0; i < centBetrag.Length; i++)
            {
                int anzahl = (int)rueckgeldInCent / centBetrag[i];     //decimal als int deklarieren

                if (anzahl > 0)
                {
                    Console.WriteLine($"{anzahl} * {geld[i]}");
                    rueckgeldInCent = rueckgeldInCent % centBetrag[i];
                    
                }
            }
        }
    }
}
