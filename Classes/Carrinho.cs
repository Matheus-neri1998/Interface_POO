using System;
using System.Collections.Generic;

namespace Interface_POO.Classes
{
    public class Carrinho
    {
        // public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        // método criado para alterar produto
        public void Alterar(int cod, Produto novoProduto)
        {
            // Expressão lambda para alterar o produto
            carrinho.Find(x => x.Codigo == cod).Nome = novoProduto.Nome;

        }
        
        // método criado para cadastrar produto
        public void Cadastrar(Produto produto)
        {

            carrinho.Add(produto);
        }

        // método criado para algum produto

        public void Deletar(int cod)
        {
            Produto deleteProduct = carrinho.Find(x => x.Codigo == cod);

            if (deleteProduct != null)
            {
                carrinho.Remove(deleteProduct);
            }
        }

        // método criado para listar produto

        public void Listar()
        {   // listando os produto em carrinho

            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Identificação: {item.Nome}");
                Console.WriteLine($"Valor: {item.Preco}");
                Console.WriteLine("-------------------------");
            }

        }

    }
}