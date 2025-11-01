using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    { // a palavra abstract NÃO DEIXA INSTANCIAR objeto
        protected int codigo;
        protected string? nome;
        protected int idade;
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
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public virtual void Mostrar() //método concreto --> com lógica
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tIdade: " + Idade);
        }
        public Cliente(int codigo, string nome, int idade) // construtor
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public abstract void VerificarIdade(); //método abstrato, não tem nenhuma linha de lógica na superclasse e só pode estar na classe abstrata, e encerra com ";"
    }   // tipo NomeMetodo (precisa ou não de parâmetros); --> assinatura de método
        // classe abstrata permite método sem lógica --> método abstract
        // nunca classe filha tem nome abstraact
}