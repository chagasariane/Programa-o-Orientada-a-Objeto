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

        //construtor 
        public Funcionario(int codigo, string nome, Endereco endereco, double salario)
        { // propriedade recebe o parâmetro
            Codigo = codigo;
            Nome = nome;
            _Endereco = endereco;
            Salario = salario;
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
    }
}