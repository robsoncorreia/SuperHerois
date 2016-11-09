using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerois
{
    class Heroi : Personagem
    {
        private string nomeReal;

        public Heroi(string nome, string editora, int pf, int pe, bool mimico, bool drenado, string nomeReal) : base(nome, editora, pf, pe, mimico, drenado)
        {
            this.NomeReal = nomeReal;
        }

        public string NomeReal
        {
            get
            {
                return nomeReal;
            }

            set
            {
                nomeReal = value;
            }
        }
    }
}
