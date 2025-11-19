using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaNoCaixa
{
    public class Venda
    {
        public DateTime Data { get; private set; } = DateTime.Now;
        public double Total { get; private set; }
        public List<ItemVenda> Itens { get; private set; } = new List<ItemVenda>();

        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
            Total += item.Subtotal;
        }

        public int ObterQuantidadeTotal()
        {
            return Itens.Sum(i => i.Quantidade);
        }

        public void AplicarDescontoAtacado()
        {
            if (ObterQuantidadeTotal() >= 50)
            {
                Total *= 0.80; // desconto de 20%
            }
        }
    }
}