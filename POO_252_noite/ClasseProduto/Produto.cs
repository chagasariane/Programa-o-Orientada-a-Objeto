using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//pasta
namespace ClasseProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string nome;
        public double preco;
        public int estoque;
        public double subtotal;

        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tPreço: " + preco + "\tEstoque: " + estoque);
        }
        public void CalcularAumento(double porcentagem)
        {
            preco = preco + (preco * (porcentagem/100));
        }
        public void RetirarEstoque(int quantidade)
        {
            estoque = estoque - quantidade;
        }
        public void CalcularSubtotal()
        {
            subtotal = estoque * preco;
        }
    }
}