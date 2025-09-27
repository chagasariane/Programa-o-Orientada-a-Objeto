using EncapsulamentoFuncionario;

internal class Program
{
   private static void Main(string[] args) 
   {
    Funcionario f1 = new Funcionario();
    // após o encapsulamento deixa de ser objeto.atributo para objeto.propriedade 
    f1.Codigo = 1; // esse é o set
    f1.Nome = "Ana";
    f1.Salario = 100;
    f1.MostrarAtributos();

    Funcionario f2 = new Funcionario();
    Console.Write("Digite o codigo: "); //get
    f2.Codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o nome: ");
    f2.Nome = Console.ReadLine();
    Console.Write("Digite o salario: ");
    f2.Salario = Convert.ToDouble(Console.ReadLine());
    f2.MostrarAtributos();
   }
}