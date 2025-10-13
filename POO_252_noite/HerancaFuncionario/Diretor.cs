using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(double salario) : base (salario) // palavra base faz com que Secretario use o construtor da classe base
        {
        }
        public override double CalcularBonificacao() // override para polimorfismo
        {
            return base.CalcularBonificacao() + 1000; // base.CalcularBonificacao(). trouxe traz o valor de 10% da classe base + 1000
        }
    }
}