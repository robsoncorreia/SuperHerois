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

            oponente1.Pe = oponente1.PeInicial;
            oponente2.Pe = oponente2.PeInicial;

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
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Confronto CrossOver");
                Console.WriteLine();
            }

            if (oponente1.GetType() != oponente2.GetType())
            {
                Console.WriteLine("Confronto Clássico: Bem versus o Mal !");
                Console.WriteLine();
            }
            else if (oponente1.GetType().Equals(typeof(Heroi)) && oponente2.GetType().Equals(typeof(Heroi)))
            {
                Console.WriteLine("Confronto Herói contra Herói !");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Confronto Vilão contra Vilão !");
                Console.WriteLine();
            }

            //Mudei para ver se metodo Drenar estava funcionado
            Console.WriteLine("{0} PF: {1} PE: {2} VS {3} PF: {4} PE: {5}", oponente1.Nome, oponente1.Pf, oponente1.Pe, oponente2.Nome, oponente2.Pf, oponente2.Pe);
            Console.WriteLine();

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

            string vencedor = string.Empty;

            if (oponente1.Pf > 0)
            {
                vencedor = oponente1.Nome;
            }
            else
            {
                vencedor = oponente2.Nome;
            }
            if (vencedor.Equals("Parasita"))
            {
                if (oponente1.Nome.Equals("Parasita"))
                {
                    oponente1.Drenar(oponente2);
                }
                else
                {
                    oponente2.Drenar(oponente1);
                }
            }
            Console.WriteLine("Combate encerrado\nVencedor : {0}", vencedor);
            Console.WriteLine();
        }
    }
}
