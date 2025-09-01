using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta //namespace é uma subpasta
{   //classe
    public class Conta //tipos de dados meu de programador 
    {
        //declaração do atributos
        private int numero;
        private string titular;
        private double saldo;

        //declaração dos métodos
        public int Numero{ //Numero com "N" maisculo é a propriedade - é a representação dos métodos de encapsulamento get e set
            set{if (value > 0) numero = value; else Console.WriteLine("Número inválido!");}//numero com "n" minisculo é atributo
            get{return numero;}//numero com "n" minisculo é atributo
        }

        public string Titular
        {
            get{return titular;}
            set{titular = value;}
        }

        public double Saldo
        {
            set{saldo = value;}
            get{return saldo;}
        }

        //declaração dos métodos (função em python)
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}