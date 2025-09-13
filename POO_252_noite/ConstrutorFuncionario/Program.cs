using ConstrutorFuncionario;

//instancia 1
Funcionario f1 = new Funcionario();
//instancia 2
Funcionario f2 = new Funcionario(1);
f2.MostrarAtributos();
//instancia 3
Funcionario f3 = new Funcionario(1,"Ariane");
f3.MostrarAtributos();
//instancia 4
Funcionario f4 = new Funcionario(1,"Ariane",1500.50);
f4.MostrarAtributos();

//Mostrar quantas instancia tem
Console.WriteLine("Quantidade de instâncias:"+ Funcionario.Contador); //Nome da classe e do atributo, também pode ser nome da classe e o método


//parte extra
Console.Write("Digite o código: ");
f1.Codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Digite o salario: ");
f1.Salario = Convert.ToDouble(Console.ReadLine());
f1.MostrarAtributos();


