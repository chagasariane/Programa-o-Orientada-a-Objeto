using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public bool VerificarMaiorIdade()
        {
            return Idade >= 18;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Dependente: {Nome} \tIdade: {Idade} \tCódigo: {Codigo}");
        }
    }
}