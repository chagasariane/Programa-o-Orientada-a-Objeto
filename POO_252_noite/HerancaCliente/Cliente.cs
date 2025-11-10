using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente //superclasse - base
    {
        // atalho - propfull
        protected int codigo; //protected para pai
        protected string? nome;

        public int Codigo //propriedade
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome //propriedade
        {
            get { return nome; }
            set { nome = value; }
        }
        public virtual void Mostrar()
        {
            Console. WriteLine("Código: " + codigo + "\tNome: "+ nome);
        }
    }
}

  git config --global user.email "you@example.com"
  git config --global user.name "Your Name"