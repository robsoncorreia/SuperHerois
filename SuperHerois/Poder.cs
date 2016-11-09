using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerois
{
    class Poder
    {
        private string nome;
        private int dano;
        private int pe;

        public Poder(string nome, int dano, int pe)
        {
            this.nome = nome;
            this.dano = dano;
            this.pe = pe;
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

        public int Dano
        {
            get
            {
                return dano;
            }

            set
            {
                dano = value;
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
    }
}
