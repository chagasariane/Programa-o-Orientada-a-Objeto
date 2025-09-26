using ClasseFuncionario;//usando a namespace
internal class program
{
    private static void Main(string[] args)
    {
        //declaração de variáveis
        Funcionario f1 = new Funcionario(); //Funcioario - classe, tipo, estrutura de dados       
                                            //f1 - variável de instância ou objeto               
                                            //new - alocação de memória                         
                                            //Funcionario() - método construtor

                                            //new Funciona() - Instância  
                                            //o objeto só existe quando ele é instanciado 
                                            //estado do meu objeto - valor que está atribuido no objeto dentro da instacia

        Console.Write("Digite o código: "); 
        f1.codigo = Convert.ToInt32(Console.ReadLine()); // o valor digitado é convertido para inteiro e guardado no atributo "codigo" do objeto "f1" do tipo Funcionario


        Console.Write("Digite o nome: ");
        f1.nome = Console.ReadLine();

        Console.Write("Digite o salário: ");
        f1.salario = Convert.ToDouble(Console.ReadLine());

        //enviar para o método (chamada de função, em python)
        f1.MostrarAtributos();
        f1.CalcularAumento();
        f1.MostrarAtributos();
    }
}