using System;

public class Aluno
{
    public long Ra { get; set; }
    public string Nome { get; set; }
    public static long Contador { get; private set; }

    static Aluno() // construtor estático --> ele será o primeiro a ser executado, mesmo se estive lá embaixo
    {
        Contador = 1570482413000;
    }

    public Aluno()
    {
        Contador += 1;
        Ra = Contador;
    }

    public Aluno(string nome)
    {
        Contador += 1;
        Ra = Contador;
        Nome = nome;
    }

    public void MostrarAtributos()
    {
        Console.WriteLine($"RA: {Ra} - Nome: {Nome}");
    }
}
