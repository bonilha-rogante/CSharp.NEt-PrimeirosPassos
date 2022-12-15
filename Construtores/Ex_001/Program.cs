﻿using System;
using System.Globalization;

namespace Ex_001
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            Console.WriteLine();
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser retirados do estoque: ");
            qte = int.Parse(Console.ReadLine());
            Console.WriteLine();
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}