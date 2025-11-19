using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaNoCaixa
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; private set; }
        public int ResultadoTransacao { get; private set; }

        public Cartao(double total, string dados) : base(total)
        {
            DadosTransacao = dados;
            ResultadoTransacao = 1; // Sucesso da transação
        }
    }
}