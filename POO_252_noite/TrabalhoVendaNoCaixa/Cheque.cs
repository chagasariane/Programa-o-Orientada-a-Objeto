using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaNoCaixa
{
    public class Cheque : Pagamento
    {
        public long Numero { get; private set; }
        public DateTime DataDeposito { get; private set; } = DateTime.Now;
        public int Situacao { get; private set; } = 0;

        public Cheque(double total, long numero) : base(total)
        {
            Numero = numero;
        }
    }
}