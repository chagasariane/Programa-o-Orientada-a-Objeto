using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetorConta //namespace é uma subpasta
{   //classe
    public class Conta //tipos de dados meu de programador 
    {
        //declaração do atributos
        public int numero;
        public string titular;
        public double saldo;

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