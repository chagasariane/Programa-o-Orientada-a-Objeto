using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaNoCaixa
{
    public class Produto
    {
        public long Codigo { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Estoque { get; set; }

        public Produto(long codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}