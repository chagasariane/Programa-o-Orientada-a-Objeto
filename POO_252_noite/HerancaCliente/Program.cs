using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Bia";

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Ana";
// objeto cliente fisico pode usar codigo e nome da classe Cliente porque está herdando essas propriedades
cf.Rg = 123;
cf.Mostrar();

