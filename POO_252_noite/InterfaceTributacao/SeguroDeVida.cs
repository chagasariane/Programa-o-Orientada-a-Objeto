using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributacao
{
    public class SeguroDeVida : ITributavel
    {
        public double ValorSeguro { get; set; }

        public SeguroDeVida(double valorSeguro)
        {
            ValorSeguro = valorSeguro;
        }

        public double CalculaTributos()
        {
            return 75; // valor fixo
        }
    }
}