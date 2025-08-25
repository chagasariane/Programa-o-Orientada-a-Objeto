using ClasseProduto;

internal class Program
{
    private static void Main(string[] args)
    {   //primeira instanciação
        Produto p1 = new Produto();

        Console.Write("Digite o código: ");
        p1.codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome: ");
        p1.nome = Console.ReadLine();

        Console.Write("Digite o preço: ");
        p1.preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o estoque: ");
        p1.estoque = Convert.ToInt32(Console.ReadLine());

        //enviar para o método (chamada de função, em python)

        p1.MostrarAtributos();

        Console.Write("Digite uma porcentagem: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());
        p1.CalcularAumento(porcentagem);

        Console.Write("Digite uma quantidade: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        p1.RetirarEstoque(quantidade);

        p1.CalcularSubtotal();

        p1.MostrarAtributos();

        //segunda instanciação
    }
}