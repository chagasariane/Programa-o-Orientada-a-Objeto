using System;
using VetorProduto;

internal class Program
{
    private static void Main(string[] args)
    {

        Produto[] vetProduto = new Produto[4];

        for (int i = 0; i < vetProduto.Length; i++) 
        {
            vetProduto[i] = new Produto();

            Console.Write("Digite o codigo do produto: ");
            vetProduto[i].codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            vetProduto[i].nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            vetProduto[i].preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o estoque do produto: ");
            vetProduto[i].estoque = Convert.ToInt32(Console.ReadLine());

            vetProduto[i].subtotal = 0;
        }
        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].MostrarAtributos();
        }
        for (int i = 0; i < vetProduto.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("Digite uma porcentagem: ");
                double porcentagem = Convert.ToDouble(Console.ReadLine());
                vetProduto[i].CalcularAumento(porcentagem);
            }
            else
            {
                Console.Write("Digite uma quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                vetProduto[i].RetirarEstoque(quantidade);
            }
        }
        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].MostrarAtributos();
        }
        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].CalcularSubtotal();
        }
        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].MostrarAtributos();
        }
    }
}
