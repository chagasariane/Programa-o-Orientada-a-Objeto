using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaNoCaixa
{
    public class ItemVenda
    {
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }
        public double Subtotal { get; private set; }
        public Produto Produto { get; private set; }

        public ItemVenda(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
            Subtotal = quantidade * Preco;
        }
    }
}