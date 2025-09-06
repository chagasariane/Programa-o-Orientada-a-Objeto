using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        //declaração dos atributos
        // private string? nome; --> não precisa declarar porque estou usando o encapsulamento compacto na declaração do método
        private double media;

        //declaração dos métodos
        public string? Nome{ get; set; }

        public double Media
        {
            get{return media;}
            set{
                if (value > 0 && value < 10) 
                    media = value;
                else 
                    Console.WriteLine("Média inválida");
                }
        }
        public ExibirDetalhes()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Media: " + media);
        }
        public bool EstaAprovado(double media)
        {
            if (media >= 6)
                return true;
            else
                return false;
        }
        public ExibirInformacoes()
        {
            Console.WriteLine("Status ")
        }
    }       
}