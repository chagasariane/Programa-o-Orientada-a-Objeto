using System;

namespace VetorProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int estoque;
        public double subtotal;

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tPreço: " + preco + "\tEstoque: " + estoque + "\tSubtotal: " + subtotal);
        }
        public void CalcularAumento(double porcentagem)
        {
            preco = preco + (preco * (porcentagem / 100));
        }
        public void CalcularSubtotal()
        {
            subtotal = preco * estoque;
        }
        public void RetirarEstoque(int quantidade)
        {
            estoque = estoque - quantidade;
        }
    }
}