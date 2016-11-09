using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerois
{
    class Vilao : Personagem
    {
        private int nivelDeMaldade;

        public Vilao(string nome, string editora, int nivelDeMaldade, int pf, int pe, bool mimico, bool drenado) : base(nome, editora, pf, pe, mimico, drenado)
        {
            this.NivelDeMaldade = nivelDeMaldade;
        }

        public int NivelDeMaldade
        {
            get
            {
                return nivelDeMaldade;
            }

            set
            {
                nivelDeMaldade = value;
            }
        }
    }
}
