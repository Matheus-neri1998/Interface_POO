using System;
using Interface_POO.Classes;

namespace Interface_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            // Inserindo os produtos

            Produto product1 = new Produto();
            product1.Codigo = 98; 
            product1.Nome = "Biscoito";
            product1.Preco = 5f; // produto 1

            Produto product2 = new Produto();
            product2.Codigo = 97; 
            product2.Nome = "Refrigerante";
            product2.Preco = 3f; // produto 2

            Produto product3 = new Produto();
            product3.Codigo = 96; 
            product3.Nome = "Salgadinho";
            product3.Preco = 1.50f; // produto 3

            Produto product4 = new Produto();
            product4.Codigo = 95; 
            product4.Nome = "Iogurte";
            product4.Preco = 2f; // produto 4

            // Cadastrando os produtos

            cart.Cadastrar(product1);
            cart.Cadastrar(product2);
            cart.Cadastrar(product3);
            cart.Cadastrar(product4);

            // Listando todos os produtos
            cart.Listar();

            Console.ForegroundColor = ConsoleColor.Blue;

            // Alterando produto
            cart.Alterar(98, product4); // alterando de Biscoito para Iogurte

            // listando novamente os produtos
            cart.Listar();

            Console.ForegroundColor = ConsoleColor.Yellow;

            // Deletando o produto usando o código
            cart.Deletar(product3.Codigo);

            // Passo final: listando novamente após as alterações
            cart.Listar();

            Console.ResetColor();

        }
    }
}
