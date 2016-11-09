using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerois
{
    static class Confronto
    {
        public static void Confrontar(Personagem oponente1, Personagem oponente2)
        {
            oponente1.Pf = oponente1.PfInicial;
            oponente2.Pf = oponente2.PfInicial;

            if (oponente1.Mimico)
            {
                oponente1.ClonarPoderes(oponente2);
            }

            if (oponente2.Mimico)
            {
                oponente2.ClonarPoderes(oponente1);
            }

            if (oponente1.Editora.Equals(oponente2.Editora))
            {
                Console.WriteLine("Confronto {0}",oponente1.Editora);
            }
            else
            {
                Console.WriteLine("Confronto CrossOver");
            }


        }
    }
}
