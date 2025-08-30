using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos (variáveis, em python)
        public int codigo;
        public string nome;
        public double salario;

        //declaracção do método (função, em python) 
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine($"Salário: {salario:c}");
        }
        public void CalcularAumento()
        {
            //5% de aumento no salário
            salario = salario + (salario*0.05);
        }
    }
}