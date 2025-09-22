using ComposicaoNf;

ItemNotaFiscal it1 = new ItemNotaFiscal(12);
ItemNotaFiscal it2 = new ItemNotaFiscal(20);

NotaFiscal nf = new NotaFiscal(1,"22/09/2025"); //instancia a NotaFiscal e a list ao mesmo tempo
nf.VetItens.Add(it1);
nf.VetItens.Add(it2);
Console.WriteLine("\nApresentação dos itens de nota fiscal\n");
foreach (var item in nf.VetItens) // a compilação que faz identificar o tipo implicito var
    item.Mostrar();

// forçar a destruição do objeto 
nf = null; // aqui a variavel perde a referencia de memória ficando disponível para o coletor de lixo liberar a memória 
// chame o Coletor de Lixo
GC.Collect(); //nome da classe para chamar uma método(função), 
//normalmente é o objeto chama o atributo, mas a classe GC. chama o método Collect()
// usado quando tem a classe, o método ou atributo estático (static)