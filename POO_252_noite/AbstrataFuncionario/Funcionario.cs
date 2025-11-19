using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected Endereco endereco; //endereco é o atributo e Endereco é o tipo 
        protected double salario;

         public List<Dependente> Dependentes { get; set; }

        //construtor 
        public Funcionario(int codigo, string nome, Endereco endereco, double salario)
        { // propriedade recebe o parâmetro
            Codigo = codigo;
            Nome = nome;
            _Endereco = endereco;
            Salario = salario;

            Dependentes = new List<Dependente>();
        }

        // métodos de encapsulamento
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Endereco _Endereco //_Endereco é a propriedade e Endereco é o tipo 
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tSalário: {Salario:c}");
        }
        public abstract double CalcularSalario(int diasUteis); //assinatura de método
        // o que o método faz pelo nome, sabe os parâmetros, mas não sabe a lógica
        // obrigatório que as classes filhas utilizem esse método
        // método abstrato só pode estar dentro de classe bastrata
        // nunca tem lógica

        public int CalcularTotalDependente()
        {
            return Dependentes.Count;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            Dependentes.Add(novoDep);
        }

        public void RemoverDependentesMaioridade(int codigoDep)
        {
            for (int i = 0; i < Dependentes.Count; i++)
            {
                if (Dependentes[i].Codigo == codigoDep)
                {
                    if (Dependentes[i].VerificarMaiorIdade())
                        Dependentes.RemoveAt(i);

                    return;
                }
            }
        }

        public void ListarDependentes()
        {
            if (Dependentes.Count == 0)
            {
                Console.WriteLine("Nenhum dependente cadastrado.");
                return;
            }

            foreach (var d in Dependentes)
                d.Mostrar();
        }
    }
}
//criar classe Dependente
//implementar funções
//terá um vetor de dependente


