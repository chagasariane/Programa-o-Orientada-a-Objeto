using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        //Construtor
        public Gerente(double salario) : base (salario) // palavra base diz faz com que Secretario use o construtor da classe base
        {
        }
        public override double CalcularBonificacao() // override para polimorfismo
        {
            return Salario * 15 / 100;
        }
    }
}