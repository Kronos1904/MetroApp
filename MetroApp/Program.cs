using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pražské metro");
            List<string> linkaA = new List<string>
            {"Nemocnice Motol", "Petřiny", "Nádrží Veleslaví", "Bořislav", "Dejvická", "Hradčanská", "Malostranská", "Staroměstská", "Muzeum",
            "Náměstí Míru", "Jiřího z Poděbrad", "Flora", "Želivského", "STRAŠNICKÁ", "Skalka", "Depo Hostivař"};
            List<string> linkaD = new List<string>
            {"Písnice", "Libuše", "Nové Dvory", "Nádraží krč", "Olbrachtova", "Pankrác", "Náméstí bratří Synků", "Náměstí Míru"};

            LinkaMetra linkaMetraA = new LinkaMetra(linkaA);
            LinkaMetra linkaMetraD = new LinkaMetra(linkaD);

            Console.WriteLine("Vyberte linku metra A/D");
            string zvolenLinka = Console.ReadLine();

            if (zvolenLinka == "A")
            {
                linkaMetraA.VypisPrvni();
                linkaMetraA.VypisStanice();
            }
            else if (zvolenLinka == "D")
            {
                linkaMetraD.VypisPrvni();
                linkaMetraD.VypisStanice();
            }

            Console.Write("Zadejte první stanici: ");
            string stanice1 = Console.ReadLine();

            Console.Write("Zadejte druhou stanici: ");
            string stanice2 = Console.ReadLine();

            Console.WriteLine("------------");
            if (linkaMetraA.ZjistiCas(stanice1, stanice2) == 0 && linkaMetraD.ZjistiCas(stanice1, stanice2) == 0)
            {
                Console.WriteLine("Chybně zadaná stanice");
            }
            else if (zvolenLinka == "A")
            {
                Console.WriteLine($"Cesta z {stanice1} do {stanice2} bude trvat {linkaMetraA.ZjistiCas(stanice1, stanice2)} min");
            }
            else if (zvolenLinka == "D")
            {
                Console.WriteLine($"Cesta z {stanice1} do {stanice2} bude trvat {linkaMetraD.ZjistiCas(stanice1, stanice2)} min");
            }
            Console.ReadKey();
        }
    }
}
