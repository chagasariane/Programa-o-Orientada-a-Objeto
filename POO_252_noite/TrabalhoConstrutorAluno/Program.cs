using System;

public class Program
{
    public static void Main()
    {
        Aluno a1 = new Aluno();
        a1.MostrarAtributos();
        Aluno a2 = new Aluno("Ariane");
        a2.MostrarAtributos();
        Aluno a3 = new Aluno("Carla");
        a3.MostrarAtributos();

        Console.WriteLine($"\nTotal de alunos cadastrados: {Aluno.Contador}");
    }
}
