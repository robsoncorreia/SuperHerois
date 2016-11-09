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
                Console.WriteLine("Confronto {0}", oponente1.Editora);
            }
            else
            {
                Console.WriteLine("Confronto CrossOver");
            }

            if (oponente1.GetType() != oponente2.GetType())
            {
                Console.WriteLine("Confronto Clássico: Bem versus o Mal !");
            }
            else if (oponente1.GetType().Equals(typeof(Heroi)) && oponente2.GetType().Equals(typeof(Heroi)))
            {
                Console.WriteLine("Confronto Herói contra Herói !");
            }
            else
            {
                Console.WriteLine("Confronto Vilão contra Vilão !");
            }

            Console.WriteLine("{0} PF: {1} VS {2} PF: {3}", oponente1.Nome, oponente1.Pf, oponente2.Nome, oponente2.Pf);

            while (oponente1.Pf > 0 && oponente2.Pf > 0)
            {
                Random sorteio = new Random();
                int ns = sorteio.Next(1, 3);

                switch (ns)
                {
                    case 1:
                        oponente1.Atacar(oponente2);
                        oponente2.Atacar(oponente1);
                        Console.WriteLine();
                        break;
                    case 2:
                        oponente2.Atacar(oponente1);
                        oponente1.Atacar(oponente2);
                        Console.WriteLine();
                        break;
                }
            }
            Console.WriteLine("Combate encerrado\nVencedor : {0}", oponente1.Pf > 0 ? oponente1.Nome : oponente2.Nome);
            Console.WriteLine();
        }
    }
}
