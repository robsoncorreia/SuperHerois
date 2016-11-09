using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerois
{
    class Program
    {
        static void Main(string[] args)
        {
            string MARVELCOMICS = "Marvel Comics";
            string DCCOMICS = "DC Comics";

            //HERÓIS
            Poder forca = new Poder("Força", 10, 8);
            //PODERES DO SUPER MAN
            Poder visaoDeRaios = new Poder("Visão de Raios", 5, 5);
            Poder superSopro = new Poder("Supersopro", 4, 4);
            //PODERES DO HOMEM-ARANHA
            Poder soltaTeia = new Poder("Solta teia", 5, 5);
            //PODERES DA FENIX
            //possui apenas força

            //VILÕES
            //PODERES DO SUPERBIZARRO
            //possui os mesmos poderes de Super man
            //PODERES DO DUENDE VERDE
            //força
            Poder granadaDeAbobora = new Poder("Granada de Abóbora", 5, 5);
            //PODER DO DOUTOR OCTOPUS
            Poder tentaculos = new Poder("Tentáculos", 6, 4);
            //PODER PARASITA
            Poder rajadaEnergetica = new Poder("Rajada Energética", 6, 8);

            //PERSONAGENS HERÓIS
            Heroi superman = new Heroi("Superman", DCCOMICS, 100, 70, false, false, "Clark Kent");
            Heroi homemAranha = new Heroi("Homem-Aranha", MARVELCOMICS, 80, 50, false, false, "Peter Parker");
            Heroi fenix = new Heroi("Fênix", MARVELCOMICS, 150, 100, false, false, "Jean Grey");
            Heroi mimico = new Heroi("Mimico", MARVELCOMICS, 70, 50, true, false, "Calvin Montgomery Rankin");

            //PERSONAGENS VILÕES
            Vilao superbizarro = new Vilao("Superbizarro", DCCOMICS, 50, 95, 65, false, false);
            Vilao duendeVerde = new Vilao("Duende Verde", MARVELCOMICS, 70, 80, 60, false, false);
            Vilao doutorOctopus = new Vilao("Doutor Octopus", MARVELCOMICS, 40, 70, 40, false, false);
            Vilao superSkrull = new Vilao("Super Skrull", MARVELCOMICS, 100, 90, 60, true, false);
            Vilao parasita = new Vilao("Parasita", DCCOMICS, 70, 90, 70, false, true);

            //ADIONANDO PODERES AO SUPERMAN
            superman.AdicionarPoder(forca);
            superman.AdicionarPoder(visaoDeRaios);
            superman.AdicionarPoder(superSopro);
            //superman.ExibirPoderes();

            //ADCIONANDO PODERES AO HOMEM-ARANHA
            homemAranha.AdicionarPoder(forca);
            homemAranha.AdicionarPoder(soltaTeia);
            //homemAranha.ExibirPoderes();

            //ADCIONANDO PODERES A FÊNIX
            fenix.AdicionarPoder(forca);
            //fenix.ExibirPoderes();

            //ADCIONADO PODERES AO SUPERBIZARRO
            superbizarro.AdicionarPoder(forca);
            superbizarro.AdicionarPoder(visaoDeRaios);
            superbizarro.AdicionarPoder(superSopro);
            //superbizarro.ExibirPoderes();

            //ADCIONADO PODERES AO DUENDE VERDE
            duendeVerde.AdicionarPoder(forca);
            duendeVerde.AdicionarPoder(granadaDeAbobora);
            //duendeVerde.ExibirPoderes();

            //ADCIONANDO PODERES AO DOUTOR OCTOPUS
            doutorOctopus.AdicionarPoder(tentaculos);
            //doutorOctopus.ExibirPoderes();

            //ADCIONANDO PODERES AO PARASITA
            parasita.AdicionarPoder(forca);
            parasita.AdicionarPoder(rajadaEnergetica);

            //CLONANDO PODERES COM SUPER SKRULL
            //superSkrull.ClonarPoderes(homemAranha);
            //superSkrull.ExibirPoderes();

            //CLONANDO PODERES COM O MIMICO
            //mimico.ClonarPoderes(superman);
            //mimico.ExibirPoderes();
            //superbizarro.Pe -= 61;
            //superbizarro.Atacar(homemAranha);
            Confronto.Confrontar(homemAranha, doutorOctopus);
            Confronto.Confrontar(fenix, superman);
            Confronto.Confrontar(doutorOctopus, duendeVerde);
            Confronto.Confrontar(mimico, fenix);
            Confronto.Confrontar(parasita, superSkrull);
            Confronto.Confrontar(parasita, superman);
            //se eu colocar dois mimicos para lutarem sem poderes, da m.
        }
    }
}
