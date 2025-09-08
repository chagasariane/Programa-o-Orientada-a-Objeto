using ConstrutorFuncionario;

Funcionario f1 = new Funcionario();
Console.Write("Digite o código: ");
f1.Codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Digite o salario: ");
f1.Salario = Convert.ToDouble(Console.ReadLine());
f1.MostrarAtributos();

Funcionario f2 = new Funcionario(1);
f2.MostrarAtributos();

Funcionario f3 = new Funcionario(1,"Ariane");
f3.MostrarAtributos();

Funcionario f4 = new Funcionario(1,"Ariane",1500.50);
f4.MostrarAtributos();

