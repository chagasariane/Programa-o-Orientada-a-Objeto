using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetF { get; set; } //vetor aceita qualquer tipo de funcionário quando instanciado- generalização
        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código do departamento: {Codigo} \tNome: {Nome}");
        }
        public void AdmitirFuncionario(Funcionario f)
        {
            VetF.Add(f);
        }
        public void ListarFuncionarios()
        {
            foreach(var f in VetF)
                f.Mostrar();
        }
        public void DemitirFuncionario(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt(i); //generalização --> na variável f do tipo funcionario irá armazenar cada elemento da lista funcionário, tanto funcio nário assalariado quanto comissionado
                if (codigo == f.Codigo)
                    VetF.Remove(f); //Remove - classe pronta do C# para remover um elemento de uma lista
            }
        }
        public double CalcularFolha(int diasUteis) //diasUteis --> parâmetro
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt(i); 
                folha += f.CalcularSalario(diasUteis); //diasUteis --> argumento --> precisa ser o mesmo nome do parâmetro, pois dentro de CalcularFolha para acessar CalcularSalario
            }
            return folha;
        }
    }   
}