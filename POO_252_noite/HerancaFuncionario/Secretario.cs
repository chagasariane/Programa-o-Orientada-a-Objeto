using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Secretario : Funcionario
    {
        //Construtor
        public Secretario(double salario) : base (salario) // palavra base diz faz com que Secretario use o construtor da classe base
        {
        }
    }
}