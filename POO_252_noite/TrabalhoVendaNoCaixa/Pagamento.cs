using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaNoCaixa
{
    public abstract class Pagamento
    {
        public DateTime Data { get; protected set; } = DateTime.Now;
        public double Total { get; protected set; }

        protected Pagamento(double total)
        {
            Total = total;
        }
    }
}