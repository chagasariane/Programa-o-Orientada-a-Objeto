using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
        public ClienteFisico(int codigo, string nome,int idade, int rg) : base(codigo, nome, idade) // quando tem base é o construtor da classe base e é por isso que aqui tem os dois parametros da superclasse na base e pode ter o construtor com mais outros parametros, porque precisa ter os mesmos parametros da superclasse
        {
            Rg = rg;
        }
        public override void Mostrar() //polimorfismo é só no método, overide na subclasse e lá na superclasse está a palavra virtual
            {
                // a palavra base. chama o método da superclasse
                base.Mostrar(); // na 
                Console.WriteLine("Rg: " + Rg);
            }
        public override void VerificarIdade()
        {
            if (Idade >= 18 && Idade <= 45)
                Console.WriteLine("Cliente físico!");
        }
    }
}