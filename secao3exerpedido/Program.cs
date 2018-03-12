using System;
using System.Collections.Generic;

namespace secao3exerpedido
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();
        static void Main(string[] args)
        {
            int op = 0;
            //pode alterar e excluir produtos diretamente por aqui
            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofa de tres lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            while (op != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    op = 0;
                }

                if (op == 1)
                {
                    Tela.mostrarProduto();
                }
                else if (op == 2)
                {
                    try
                    {
                        Tela.cadastrarProduto();

                        op = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (op == 3)
                {
                    try
                    {
                        Tela.cadastrarPedido();

                        op = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (op == 4)
                {
                    try
                    {
                        Tela.mostrarPedido();

                        op = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (op == 5)
                {
                    Console.WriteLine("Fim do programa!");
                }
                else
                {
                    Console.WriteLine("Opcao invalida!");
                }
                Console.ReadKey();
            }
            }

        }
    }

