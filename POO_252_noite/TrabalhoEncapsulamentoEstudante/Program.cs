using EncapsulamentoEstudante;

internal class Program
{
   private static void Main(string[] args) 
   {
    Estudante e1 = new Estudante();
    e1.Nome = "Ana"; // esse é set
    e1.Media = 6; // esse é set
    e1.ExibirDetalhes();
    e1.ExibirInformacoes();

    Estudante e2 = new Estudante();
    Console.Write("Digite o nome: "); 
    e2.Nome = Console.ReadLine(); // esse é set
    Console.Write("Digite a média: "); 
    e2.Media = Convert.ToDouble(Console.ReadLine()); // esse é set
    e2.ExibirDetalhes();
    e2.ExibirInformacoes();
   }
}