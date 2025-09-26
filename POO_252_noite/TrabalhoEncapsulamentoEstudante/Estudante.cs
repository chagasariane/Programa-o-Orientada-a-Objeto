using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        //declaração dos atributos
        // private string? nome; --> não precisa declarar porque estou usando o encapsulamento compacto 
        private double media; // declarei porque preciso personalizar a lógica do get ou do set

        //declaração das propriedades
        public string? Nome{ get; set; } // já faz automaticamente private string? nome;

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

        //declaração do métodos
        public void ExibirDetalhes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Media: " + Media);
        }
        public bool EstaAprovado()
        {
            if (Media >= 6)
                return true;
            else
                return false;
        }
        public void ExibirInformacoes()
        {
            if (EstaAprovado())
                Console.WriteLine("Status: Aprovado(a)");
            else
                Console.WriteLine("Status: Reprovado(a)");
        }
    }       
}