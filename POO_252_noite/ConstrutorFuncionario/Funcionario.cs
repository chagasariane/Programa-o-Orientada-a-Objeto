using System;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos de forma implicita e declaração da propriedade com os métodos de encapsulamento get e set
        //(atalho prop)
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public static int Contador { get; private set; } //declaração da variárel contador e já inicializa em 0, pois a instancia new Construtor() zera as variávies dentro de cada instanca
        // a classe controla o contator com a plavra static - static é uma variável de classe / diretia 
        // o atributo Contador não pode ser controlada pelo objeto por que não é uma variável instanciada, quando dizemos que é static

        //declaração do construtor (atalho - ctor)
        //construtor inicializa a variável de instância(objeto), ou seja, inicializa os atributos da classe depois da instanciação
        //atributos conhecidos (atribitos são os em maiúsculo)
        public Funcionario() //construtor padrão --> NUNCA terá retorno
        {
        }
        public Funcionario(int codigo)
        {
            Codigo = codigo;
            Contador += 1;
        }
        public Funcionario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Contador += 1;
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Contador += 1;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
            // Console.WriteLine($"Código: {Codigo} / tNome");
        }
    }
}