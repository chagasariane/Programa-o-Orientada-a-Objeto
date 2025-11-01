using AbstrataCliente;
// instância correta, mas usamos a palavra abstract NÃO EXECUTADA
ClienteFisico cf = new ClienteFisico(1, "Ana", 18, 100);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(2, "Empresa", 46, 200);
cj.Mostrar();

Teste t = new Teste();
t.AvaliarIdadeCliente(cf);
t.AvaliarIdadeCliente(cj);