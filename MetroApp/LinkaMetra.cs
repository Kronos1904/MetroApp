using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp
{
    internal class LinkaMetra
    {
        private int _pocetStanic;

        private List<string> _nazvyStanice; //názvy stanice - Florenc, Pankrác, Hlavní nádraží, ...

        public LinkaMetra(List<string> _vkladanestanice)
        {
            _nazvyStanice = _vkladanestanice;
        }
        public void VypisStanice()
        {
            foreach (string stanice in _nazvyStanice)
            {
                Console.WriteLine(stanice);
            }
        }
        public void VypisPrvni()
        {
            Console.WriteLine(_nazvyStanice[0]);
        }
        public int ZjistiCas(string prvniStanice, string druhaStanice)
        {
            int cas = 0;
            if(prvniStanice == druhaStanice)
            {
                Console.WriteLine("Stanice se shodují");
                return cas;
            }
            else
            {
                //seznam musí obsahovat obě zadané stanice
                if(_nazvyStanice.Contains(prvniStanice) && _nazvyStanice.Contains(druhaStanice))
                {
                    int indexPrvni = _nazvyStanice.IndexOf(prvniStanice);
                    int indexDruhe = _nazvyStanice.IndexOf(druhaStanice);
                    int rozdíl = indexPrvni - indexDruhe;
                    cas = rozdíl * 2;
                }
            }
            return cas;

        }
    }
}
