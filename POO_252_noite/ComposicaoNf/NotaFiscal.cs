using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNf
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string? Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }
        public NotaFiscal(int nf, string data) // Construtor - inicializa os atributos da classe
        {
            VetItens = new List<ItemNotaFiscal>(); //No momento da instancia do objeto todo NotaFiscal, a instancia da relação/associação deve ser realizada/estabelecida
            NumeroNf = nf;
            Data = data;
        }  

        ~NotaFiscal() // Destrutor - retira a referencia de memória do objeto instanciando
        {
            // implemente o fechamento dos recursos em aberto aqui
            VetItens = null; //palavra null retira essa referencia para casos de vetor
            Console.WriteLine("Destruindo a nota fiscal"); // não vemos essa fras
        }
    }
}