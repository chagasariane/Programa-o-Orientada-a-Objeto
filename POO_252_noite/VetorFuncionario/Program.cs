using VetorFuncionario;

internal class Program
{
    private static void Main(string[] args)
    {
        //declarar o vetor de funcionarios com 3 elementos
        Funcionario[] vetFuncionario = new Funcionario[3];

        //o laço de repetição realizará o cadastro dos funcionários
        for (int i = 0; i < vetFuncionario.Length; i++)
        {
            //intanciação de CADA índice //a instaciação está dentro do laço de repetição
            vetFuncionario[i] = new Funcionario();

            Console.Write("Digite o codigo: ");
            vetFuncionario[i].codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome: ");
            vetFuncionario[i].nome = Console.ReadLine();

            Console.Write("Digite o salário: ");
            vetFuncionario[i].salario = Convert.ToDouble(Console.ReadLine());
        }
        //some e mostre os total de salários pagos com for
        double soma = 0;
        for (int i = 0; i < vetFuncionario.Length; i++)
            soma += vetFuncionario[i].salario;
        Console.WriteLine($"O salário total pago foi de {soma:c}");
    }   
}

