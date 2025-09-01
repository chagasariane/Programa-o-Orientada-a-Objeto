using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos (variáveis, em python)
        private int codigo;
        private string nome;
        private double salario;

        //declaração dos métodos
        public int Codigo
        {
            get{return codigo;}
            set{codigo = value;}
        }

        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }

        public double Salario
        {
            get{return salario;}
            set{salario = value;}
        }

        //declaracção do método (função, em python) 
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salário: R$" + salario);
        }
        public void CalcularAumento()
        {
            //5% de aumento no salário
            salario = salario + (salario*0.05);
        }
    }
}