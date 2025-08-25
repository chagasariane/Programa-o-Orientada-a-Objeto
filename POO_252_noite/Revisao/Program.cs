//estruturas de repetição
/*for (int i = 0; i <= 10; i ++)
    Console.WriteLine("5 x " + i + " = " + 5 * i);*/



/*int i = 0;
Console.WriteLine("valor de i " + i);
while (i <= 10)
{
    Console.WriteLine("5 x " + i + " = " + (5 * i));
    i = i + 1;
}*/



//repita até
int i = 1;

do
{
    Console.WriteLine("5 x " + i + " = " + (5 * i));
    i = i + 1;
}while (i <= 10); //critério de parada fica no final -> ideal para montar MENU



//estruturas de decisão

/*Console.WriteLine("Menu de cálculos")
Console.WriteLine("1 - soma");
Console.WriteLine("2 - subtraindo");

int opcao = 1;
switch (opcao)
{
    case 1: Console.WriteLine("Realizando soma"); //case é o operador de igualdade, é igual o match, mas usado para números inteiros e strings, se tiver casas decimais ou os operadores forem >,<,>=,<=... é usado com o if
            break; //cada case tem que ter um break, porque podemos ter vários case
    case 2: 
        Console.WriteLine("Realizando subtração")
        break:
    default: //como se fosse o else
        Console.WriteLine("Opção inválida"):
}*/



/*int idade = 0; //not - não - !
if (idade >= 18) //or - ou -- ||
    Console.WriteLine("Maior idade"); //quando tiver uma linha entre chaves, não precisa abrir chaves
else if(idade == 0)
    Console.WriteLine("Não nasceu");
else//opcional
{
    Console.WriteLine("Menor idade");
}*/



/*Console.Write("Digite o ano de nascimento: ");
int ano = Convert.ToInt32(Console.ReadLine()); //quando uso a função de alguém é ARGUMENTO str, ou seja ConsoleReadLine() é um argumento strig do Conver.TotInt32
int idade = 2025 - ano; 
Console.WriteLine("Sua idade é " + idade + " anos!");*/