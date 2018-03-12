using System;
using System.Globalization;

namespace secao3exerpedido
{
    class Tela
    {
        //classe responsavel por conter operações que interagem com o usuario

        public static void mostrarMenu()
        {
            Console.WriteLine("**** MENU ****");
            Console.WriteLine("1 - Listar produtos orgenadamente");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public static void mostrarProduto()
        {
            Console.WriteLine("Listagem de Produtos: ");
            for(int x=0; x<Program.produtos.Count; x++)
            {
                Console.WriteLine(Program.produtos[x]);
            }
        }

        public static void cadastrarProduto()
        {
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto P = new Produto(codigo, descricao, preco);
            Program.produtos.Add(P);
            Program.produtos.Sort();
        }

        public static void cadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Digite o codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido P = new Pedido(codigo, dia, mes, ano);
            Console.Write("Quantos itens tem o pedido: ");
            int N = int.Parse(Console.ReadLine());
            for (int x=1; x<=N; x++)
            {
                Console.WriteLine("Digite os dados do " + x + "° item:");
                Console.Write("Produto (codigo): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(i => i.codigo == codProduto);
                if (pos == -1)
                {
                    Console.Write("Condigo de produto nao encontrado: " + codProduto);
                }
                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de Desconto: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ItemPedido ip = new ItemPedido(qte, porcent, P, Program.produtos[pos]);
                P.itens.Add(ip);
            }
            Program.pedidos.Add(P);

        }
         public static void mostrarPedido()
        {
            Console.Write("Digite o codigo do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if (pos == -1)
            {
                Console.Write("Codigo de pedidao nao encontrado: " + codPedido);
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }
    }
}
