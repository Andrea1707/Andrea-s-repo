using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classifica_calcio
{
    class InfoSquadra
    {
        public string Nome { get; set; }
        public string Logo { get; set; }
        public int PG { get; set; }
        public int Vittorie { get; set; }
        public int Pareggi { get; set; }
        public int Sconfitte { get; set; }
        public int GF { get; set; }
        public int GS { get; set; }
        public int Punti { get; set; }

        public InfoSquadra(string n,string l,int v1, int v2, int v3, int v4, int v5, int v6, int v7)
        {
            Nome = n;
            Logo = l;
            PG = v1;
            Vittorie = v2;
            Pareggi = v3;
            Sconfitte = v4;
            GF = v5;
            GS = v6;
            Punti = v7;
        }




    }
}
