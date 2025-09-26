// List<Funcionario> vetF = new List<Funcionario>();
// <> = generics
//uso no lugar de vetor

using ListFuncionario;

// crio a lista de funcionários chamada vetF 
List<Funcionario> vetF = new List<Funcionario>();
// List<Funcionario> é uma "coleção" que vai armazenar objetos do tipo Funcionario

double total = 0;
for (int i = 0; i < 3; i++)
{
    //intanciação 
    Funcionario f = new Funcionario();

    Console.Write("Digite o codigo: ");
    f.codigo = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o nome: ");
    f.nome = Console.ReadLine();

    Console.Write("Digite o salário: ");
    f.salario = Convert.ToDouble(Console.ReadLine());

    total = total + f.salario;

    vetF.Add(f); //vet.f.Add(objeto);
}
Console.Write($"\nO salário total é {total:c} dos funcionários\n");

// Funcionario --> tipo de objeto
// funci --> variável temporária que representa um funcionário por vez
// vetF --> coleção/lista de funcionários
foreach (Funcionario funci in vetF)
    funci.MostrarAtributos();