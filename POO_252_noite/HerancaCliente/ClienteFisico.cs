using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteFisico : Cliente // classe derivada : classe base/superclasse
    {
        private int rg; //private para filho
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public void Mostrar()
        { 
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tRg: {Rg}"); //posso ver o atributo codigo que está na classe Cliente (pai)
        } //"codigo" e "nome" minisculo tem o modificador de acesso/visibilidade aberto, para acessar a superclasse pela palavra reservada "protected"
    }
}