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
            List<String> linkaA = new List<string>
            {"Nemocnice Motol", "Petřiny", "Nádrží Veleslaví", "Bořislav", "Dejvická", "Hradčanská", "Malostranská", "Staroměstská", "Muzeum",
            "Nměstí Míru", "Jiřího z Poděbrad", "Flora", "Želivského", "STRAŠNICKÁ", "skalka", "Dope Hostivař"
            };

            LinkaMetra linkaMetroA = new LinkaMetra(linkaA);
            linkaMetroA.VypisPrvni();
            Console.WriteLine("------------");

            linkaMetroA.VypisStanice();
            Console.WriteLine("------------");

            int cas = linkaMetroA.ZjistiCas("Nemocnice Motol", "Bořislav");//vracim se včase!!!!
            Console.WriteLine(cas);

            Console.ReadKey();
        }
    }
}
