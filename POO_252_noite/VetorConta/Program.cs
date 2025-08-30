using VetorConta;

internal class Program
{
    private static void Main(string[] args)
    {
        //declaração do vetor - vetor vazio (null)
        Conta[] vetContas = new Conta[3];

        //o laço de repetição realizará o cadastro das contas 
        for (int i = 0; i < vetContas.Length; i++)
        {
            //intanciação de CADA índice //a instaciação está dentro do laço de repetição
            vetContas[i] = new Conta();

            Console.Write("Digite o número: ");
            vetContas[i].numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o titular: ");
            vetContas[i].titular = Console.ReadLine();

            Console.Write("Digite o saldo: ");
            vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
        }

        //apresentação das contas com for
        for (int i = 0; i < vetContas.Length; i++)
            vetContas[i].MostrarAtributos();

        //apresentação das contas com foreach 
        //Restrição: usar apenas quando o vetor tem conteúdo, ou seja, não usar em cadastro
        foreach (Conta c in vetContas)
            c.MostrarAtributos();
    }
}