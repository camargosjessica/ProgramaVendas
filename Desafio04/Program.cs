using System;
using System.Collections.Generic;

namespace Desafio04
{
    class Program
    {
        static List<Venda> listaVendas = new List<Venda>(); //criei uma listaVendas
        static void Main(string[] args)
        {
            menu();

        }
        static void menu()
        {
            Console.WriteLine("Programa de vendas\n" +
                            "Digite uma opção para continuar\n" +
                            "1 - Adicionar vendas\n" +
                            "2 - Total de vendas\n" +
                            "3 - Média vendas\n" +
                            "4 - Exibir todas as vendas\n" +
                            "5 - Sair");

            int opcaoSelecionada = Int32.Parse(Console.ReadLine());
            if(opcaoSelecionada == 5)
            {
                Environment.Exit(0);
            }else if (opcaoSelecionada == 1)
            {
                adicionarVenda();
            }else if (opcaoSelecionada == 2)
            {
                totalVendas();
            }else if (opcaoSelecionada == 3)
            {
                mediaVendas();
            }else if (opcaoSelecionada == 4)
            {
                exibirTodasVendas();
            }
            else
            {
                Console.WriteLine("Opção invalida");
                menu();
            }
        }
        static void adicionarVenda()
        {
            Venda venda = new Venda(); //criei um objeto venda
            Console.WriteLine("Digite o nome");
            venda.nome = Console.ReadLine(); //lendo nome e colocando no objeto venda
            Console.WriteLine("Digite o valor");
            venda.valor = Double.Parse(Console.ReadLine()); //lendo valor e colocando no objeto venda

            listaVendas.Add(venda); //adiconando venda a lista

            menu();
        }
        static double calculaTotalVendas()
        {
            double totalVendas = 0.0;

            foreach(Venda venda1 in listaVendas)
            {
                totalVendas += venda1.valor;
            }
            return totalVendas;
        }
        static void totalVendas()
        {
            double totalVendas = calculaTotalVendas();

            Console.WriteLine("Total de vendas: " + totalVendas);

            menu();
        }
        static void mediaVendas()
        {
            double totalVendas = calculaTotalVendas();
            double mediaVendas = totalVendas / listaVendas.Count;

            Console.WriteLine("Media de vendas: " + mediaVendas);

            menu();
        }
        static void exibirTodasVendas()
        {
            foreach (Venda venda1 in listaVendas)
            {
                Console.WriteLine("Nome: " + venda1.nome +"\nValor: " + venda1.valor);
            }
            menu();
        }
    }
}
