using InterfaceTributacao;

ContaCorrente cc = new ContaCorrente(1000);
SeguroDeVida sv = new SeguroDeVida(50000); 

Console.WriteLine($"Tributo Conta Corrente: {cc.CalculaTributos():c}");
Console.WriteLine($"Tributo Seguro de Vida: {sv.CalculaTributos():c}");

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

totalizador.Adiciona(cc);
totalizador.Adiciona(sv);

Console.WriteLine($"\nTotal de tributos: {totalizador.Total:c}");