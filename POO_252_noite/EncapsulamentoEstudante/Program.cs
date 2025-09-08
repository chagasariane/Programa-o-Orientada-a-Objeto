using EncapsulamentoEstudante;

internal class Program
{
   private static void Main(string[] args) 
   {
    Estudante e1 = new Estudante();
    e1.Nome = "Ana"; // esse é set
    e1.Media = 6; // esse é set
    e1.ExibirInformacoes();
    e1.ExibirDetalhes();

    Estudante e2 = new Estudante();
    Console.Write("Digite o nome: "); //get
    e2.Nome = Console.ReadLine();//set
    Console.Write("Digite o nome: "); // get
    e2.Nome = Convert.ToDouble(Console.ReadLine());//set
    e2.ExibirInformacoes();
    e2.ExibirDetalhes();
   }
}