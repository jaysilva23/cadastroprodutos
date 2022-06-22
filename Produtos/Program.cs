using Produtos.Models;
using System;
using System.Collections.Generic;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Produto>();
            Console.WriteLine("Quantos produtos você quer adicionar na lista? ");
            var qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                lista.Add(AskProduto());
            }

            Console.ReadLine();
        }

        private static Produto AskProduto()
        {
            var prod = new Produto();
            Console.WriteLine("Insira aqui o nome do produto: ");
            prod.Nome = Console.ReadLine();
            Console.WriteLine("Insira aqui a descrição do produto: ");
            prod.Descricao = Console.ReadLine();
            Console.WriteLine("Insira aqui o nome do fabricante: ");
            prod.Fabricante = Console.ReadLine();
            Console.WriteLine("Insira aqui o valor do produto: ");
            prod.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira aqui o código do produto: ");
            prod.Codigo = int.Parse(Console.ReadLine());
            
            return prod;
        }
    }
}
