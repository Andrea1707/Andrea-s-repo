using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pokededex
{
    class Utility
    {

        public static List<Pokemon> GeneraPokemon()
        {
            string[] n_pokemon = { "Gatti", "Carolo", "Bulbasaur", "Minardi", "Ferrario" };
            string[] tipi = { "Erba", "Fuoco", "Acqua" };
            string[] path = { @"C:\Users\Public\Pictures\Pokemons\poke1.jpg",
                                @"C:\Users\Public\Pictures\Pokemons\poke2.jpg",
                                @"C:\Users\Public\Pictures\Pokemons\poke3.jpg",
                                @"C:\Users\Public\Pictures\Pokemons\poke4.jpg"};

            List<Pokemon> elenco = new List<Pokemon>();

                for (int i = 0; i < 10; i++)
                {
                Thread.Sleep(10);
                string n = n_pokemon[new Random().Next(0, n_pokemon.Length - 1)];
                string t = tipi[new Random().Next(0, tipi.Length - 1)];
                string p = path[new Random().Next(0, path.Length - 1)];
                double f = new Random().Next(1,100);
                elenco.Add(new Pokemon(p,n,t,f));
            }
            return elenco;
        }

        private static void sleep(int v)
        {
            throw new NotImplementedException();
        }
    }
}
