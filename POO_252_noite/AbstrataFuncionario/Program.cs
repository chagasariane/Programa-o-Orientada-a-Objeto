using AbstrataFuncionario;

Endereco e = new Endereco("Terezina", 75, "Vila Paulo Roberto", "PP");
e.Mostrar();

Assalariado a1 = new Assalariado(1, "Assalariado 1", e, 1000);
Assalariado a2 = new Assalariado(2, "Assalariado 2", e,1000);

Comissionado c1 = new Comissionado(3, "Comissionado 1", e, 1000, 20);
Comissionado c2 = new Comissionado(4, "Comissionado 2", e, 1000, 30);

Departamento depTI = new Departamento(11, "TI");
depTI.VetF = new List<Funcionario>();
depTI.AdmitirFuncionario(a1);
depTI.AdmitirFuncionario(c1);

Departamento depRH = new Departamento(12, "RH");
depRH.VetF = new List<Funcionario>();
depRH.AdmitirFuncionario(a2);
depRH.AdmitirFuncionario(c2);

depRH.DemitirFuncionario(2); // o número é o código do funcionário que quero excluir
depRH.ListarFuncionarios();

Dependente dep1 = new Dependente(101, "Pedro", 12);
Dependente dep2 = new Dependente(102, "Ana", 20);
Dependente dep3 = new Dependente(103, "Lucas", 7);

a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep3);

a2.AdicionarDependente(dep2);

depTI.Mostrar();
depTI.ListarFuncionarios();
Console.WriteLine($"Total {depTI.CalcularFolha(30):c}");
depTI.MostrarQtdeDependentesFuncionario();

depRH.Mostrar();
depRH.ListarFuncionarios();
Console.WriteLine($"Total {depRH.CalcularFolha(30):c}");
depRH.MostrarQtdeDependentesFuncionario();

a2.RemoverDependentesMaioridade(102);
a2.ListarDependentes();