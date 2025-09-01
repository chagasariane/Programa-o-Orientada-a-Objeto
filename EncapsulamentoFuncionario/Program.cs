using EncapsulamentoConta;

internal class Program
{
   private static void Main(string[] args) 
   {
    Conta c1 = new Conta();
    c1.Numero = 1;
    c1.Titular = "Ana";
    c1.Saldo = 100;
    c1.MostrarAtributos();

    Conta c2 = new Conta();
    Console.Write("Digite o número: ");
    c2.Numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    c2.Titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    c2.Saldo = Convert.ToDouble(Console.ReadLine());
    c2.MostrarAtributos();
   }
}