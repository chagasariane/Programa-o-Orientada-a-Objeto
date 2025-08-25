using ClasseConta; //usa os arquivos que estão na mesma pasta/namespace
internal class Program
{
    private static void Main(string[] args) //o arquivo Program é a main
    {
        //declaração de variável
        Conta c1;//o tipo da variável é "Conta"
        //instaciação de objeto
        c1 = new Conta(); //Conta() construtor e agora c1 é um objeto
        c1.numero = 1; //objeto . atributo
        c1.titular = "Ana";
        c1.saldo = 100;
        c1.MostrarAtributos();     

        //outra instanciação  (declaração+instancia)
        Conta c2 = new Conta();
        //c2 objeto variável de instancia e Conta() é o construtor que autoriza 
        //instancia é new Conta();
        //new é para alocação de memória, ou seja, alocação das variáveis dentro de c1: numero, titular e saldo
        Console.Write("Digite o número: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o titular: ");
        c2.titular = Console.ReadLine();
        Console.Write("Digite o saldo: ");
        c2.saldo = Convert.ToDouble(Console.ReadLine());
        //chamada de um método
        c2.MostrarAtributos();
        c2.Sacar(10);
        c2.MostrarAtributos();
        c2.Depositar(120);
        c2.MostrarAtributos();

        Conta c3 = new Conta();
        c3.MostrarAtributos();
    }
}