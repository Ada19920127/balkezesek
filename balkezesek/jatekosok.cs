using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    class jatekosok
    {
        public string nev;
        public DateTime elso;
        public DateTime utolso;
        public int suly;
        public int magassag;
        public jatekosok(string sor)
        {
            nev = sor.Split(';')[0];
            elso = Convert.ToDateTime(sor.Split(';')[1]);
            utolso = Convert.ToDateTime(sor.Split(';')[2]);
            suly = Convert.ToInt32(sor.Split(';')[3]);
            magassag = Convert.ToInt32(sor.Split(';')[4]);
        }
    }
}
