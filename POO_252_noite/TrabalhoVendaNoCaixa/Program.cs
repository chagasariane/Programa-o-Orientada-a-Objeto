using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoVendaNoCaixa
{
    class Program
    {
        static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("\n===== MENU DO CAIXA =====");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Iniciar venda");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: CadastrarProduto(); break;
                    case 2: ListarProdutos(); break;
                    case 3: RealizarVenda(); break;
                }

            } while (opcao != 0);
        }

        static void CadastrarProduto()
        {
            Console.Write("Código: ");
            long codigo = long.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            produtos.Add(new Produto(codigo, nome, preco, estoque));

            Console.WriteLine("Produto cadastrado!");
        }

        static void ListarProdutos()
        {
            Console.WriteLine("\n--- PRODUTOS ---");
            foreach (var p in produtos)
            {
                Console.WriteLine($"Código: {p.Codigo} | {p.Nome} | R${p.Preco} | Estoque: {p.Estoque}");
            }
        }

        static void RealizarVenda()
        {
            Venda venda = new Venda();
            int opcao;

            do
            {
                Console.WriteLine("\n1 - Adicionar item");
                Console.WriteLine("2 - Finalizar venda");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                    AdicionarItem(venda);

            } while (opcao != 2);

            venda.AplicarDescontoAtacado();

            Console.WriteLine($"\nTotal da venda: R$ {venda.Total:F2}");

            Pagamento pagamento = RealizarPagamento(venda.Total);

            Console.WriteLine("Venda concluída!");
        }

        static void AdicionarItem(Venda venda)
        {
            ListarProdutos();

            Console.Write("Código do produto: ");
            long codigo = long.Parse(Console.ReadLine());

            Produto produto = produtos.FirstOrDefault(p => p.Codigo == codigo);

            if (produto == null)
            {
                Console.WriteLine("Produto inexistente!");
                return;
            }

            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            if (qtd > produto.Estoque)
            {
                Console.WriteLine("Estoque insuficiente!");
                return;
            }

            produto.Estoque -= qtd;

            venda.AdicionarItem(new ItemVenda(produto, qtd));

            Console.WriteLine("Item adicionado!");
        }

        static Pagamento RealizarPagamento(double total)
        {
            Console.WriteLine("\nForma de pagamento:");
            Console.WriteLine("1 - Espécie");
            Console.WriteLine("2 - Cartão");
            Console.WriteLine("3 - Cheque");
            Console.Write("Escolha: ");

            int op = int.Parse(Console.ReadLine());

            return op switch
            {
                1 => PagarEmEspecie(total),
                2 => PagarComCartao(total),
                3 => PagarComCheque(total),
                _ => null
            };
        }

        static Pagamento PagarEmEspecie(double total)
        {
            Console.Write("Valor entregue: ");
            double valor = double.Parse(Console.ReadLine());

            return new Especie(total, valor);
        }

        static Pagamento PagarComCartao(double total)
        {
            Console.Write("Dados do cartão: ");
            string dados = Console.ReadLine();

            return new Cartao(total, dados);
        }

        static Pagamento PagarComCheque(double total)
        {
            Console.Write("Número do cheque: ");
            long numero = long.Parse(Console.ReadLine());

            return new Cheque(total, numero);
        }
    }
}
