using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerois
{
    abstract class Personagem
    {
        private List<Poder> poderes = new List<Poder>();
        private string nome;
        private string editora;
        private int pfInicial;
        private int peInicial;
        private int pf;
        private int pe;
        private bool mimico;
        private bool drenado;

        public Personagem(string nome, string editora, int pf, int pe, bool mimico, bool drenado)
        {
            this.nome = nome;
            this.editora = editora;
            this.pf = pf;
            this.pe = pe;
            this.mimico = mimico;
            this.drenado = drenado;
            this.peInicial = this.pe;
            this.pfInicial = this.pf;
        }

        public void Atacar(Personagem openente)
        {
            Random sorteio = new Random();

            int ns = sorteio.Next(0, this.poderes.Count);

            if (pe - poderes.ElementAt(ns).Pe > 0)
            {
                pe -= poderes.ElementAt(ns).Pe;
                openente.pf -= poderes.ElementAt(ns).Dano;

                Console.WriteLine("{0} usou seu poder {1} em {2}. Dano causado: {3}.", nome, poderes.ElementAt(ns).Nome, openente.Nome, poderes.ElementAt(ns).Dano);
            }
            else
            {
                Console.WriteLine("{0} está esgotado! Usou este turno para se recuperar!", nome);
                Recuperar();
            }

        }
        public void Recuperar()
        {
            pe += (int)(pfInicial * 0.3);
        }

        public void RecuperarTudo()
        {
            pe = peInicial;
        }

        public void Drenar(Personagem oponente)
        {
            if (drenado)
            {
                peInicial += oponente.Pe;
            }
        }

        public void ClonarPoderes(Personagem oponente)
        {
            poderes.Clear();

            foreach (var item in oponente.poderes)
            {
                this.poderes.Add(item);
            }
        }

        public void AdicionarPoder(Poder poder)
        {
            poderes.Add(poder);
        }

        public void RemoverPoder(Poder poder)
        {
            poderes.Remove(poder);
        }

        //APENAS PARA TESTE
        public void ExibirPoderes()
        {
            foreach (var item in poderes)
            {
                Console.WriteLine(item.Nome);
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Editora
        {
            get
            {
                return editora;
            }

            set
            {
                editora = value;
            }
        }

        public int PfInicial
        {
            get
            {
                return pfInicial;
            }

            set
            {
                pfInicial = value;
            }
        }

        public int PeInicial
        {
            get
            {
                return peInicial;
            }

            set
            {
                peInicial = value;
            }
        }

        public int Pf
        {
            get
            {
                return pf;
            }

            set
            {
                pf = value;
            }
        }

        public int Pe
        {
            get
            {
                return pe;
            }

            set
            {
                pe = value;
            }
        }

        public bool Mimico
        {
            get
            {
                return mimico;
            }

            set
            {
                mimico = value;
            }
        }

        public bool Drenado
        {
            get
            {
                return drenado;
            }

            set
            {
                drenado = value;
            }
        }

        protected List<Poder> Poderes
        {
            get
            {
                return poderes;
            }

            set
            {
                poderes = value;
            }
        }
    }
}
