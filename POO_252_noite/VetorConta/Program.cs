using VetorConta;

internal class Program
{
    private static void Main(string[] args)
    {
        //declaração do vetor - vetor vazio (null)
        Conta[] vetContas = new Conta[3]; // Conta[] define que a variável vetContas vai armazenar um vetor de objetos do tipo Conta
                                          // new Conta[3] instancia o vetor com capacidade de 3 posições, ou seja cria um vetor na memória
                                          //até o momento o vetor está vazio --> vetContas → [ null, null, null ]

        //o laço de repetição realizará o cadastro das contas 
        for (int i = 0; i < vetContas.Length; i++)
        {
            //a instaciação está dentro do laço de repetição, então haverá a intanciação de CADA índice 3x
            vetContas[i] = new Conta(); // new Conta() instancia/cria um objeto do tipo Conta na memória e ganha um endereço
                                        // vetContas[i] é uma referência (um ponteiro/endereço) que aponta para um objeto do tipo Conta, esse objeto é a “caixa” na memória com os atributos
                                        // vetContas[i] guarda, na posição i, o endereço de um objeto do tipo Conta, ou seja, vetContas[i] aponta para esse objeto criado

            Console.Write("Digite o número: ");
            vetContas[i].numero = Convert.ToInt32(Console.ReadLine()); //O valor digitado é convertido para inteiro e armazenado no atributo "numero" de um objeto do tipo "Conta", e a posição i do vetor guarda o endereço desse objeto

            Console.Write("Digite o titular: ");
            vetContas[i].titular = Console.ReadLine();

            Console.Write("Digite o saldo: ");
            vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
        }

        //apresentação das contas com for 
        for (int i = 0; i < vetContas.Length; i++)
            vetContas[i].MostrarAtributos();

        //apresentação das contas com foreach 
        //Restrição --> usar apenas quando o vetor tem conteúdo, ou seja, não usar em cadastro
        foreach (Conta c in vetContas)
            c.MostrarAtributos();
    }
}