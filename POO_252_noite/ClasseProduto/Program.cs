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

        p1.MostrarAtributos();

        Console.Write("Digite uma porcentagem: ");
        double porcentagem = Convert.ToDouble(Console.ReadLine());
        p1.CalcularAumento(percent);

        //envio de mensagem (argumento) do objeto para o método (chamada de função, em python)
        //um unico valor numerico, envio de mensagem do objeto por valor
        //vários valores, envio de mensagem do objeto por referencia

        Console.Write("Digite uma quantidade: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        p1.RetirarEstoque(quantidade);

        p1.CalcularSubtotal();

        //segunda instanciação
    }
}

// o parâmetro na main se chama argumento
// pesquisar o por quê

//aqui é como se fosse a interface, onde chamamos os métodos

