using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public ClienteJuridico(int codigo, string nome,int idade, int cnpj) : base(codigo, nome, idade) // quando tem base é o construtor da classe base e é por isso que aqui tem os dois parametros da superclasse na base e pode ter o construtor com mais outros parametros, porque precisa ter os mesmos parametros da superclasse
        {
            Cnpj = cnpj;
        }
        public override void Mostrar() //polimorfismo é só no método, overide na subclasse e lá na superclasse está a palavra virtual
            {
                // a palavra base. chama o método da superclasse
                base.Mostrar(); // no método é base.
                Console.WriteLine("Cnpj: " + Cnpj);
            }
        public override void VerificarIdade()
        {
            if (Idade > 45)
                Console.WriteLine("Cliente jurídico!");
        }
    }
}
    
