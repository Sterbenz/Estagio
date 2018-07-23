using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {               

                var cliente = contexto
                    .Clientes
                    .Include(c => c.EnderecoDeEntrega)
                    .FirstOrDefault();

                Console.WriteLine($"Endereço de entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                var produto = contexto
                    .Produtos
                    .Include(p => p.Compras)
                    .Where(p => p.Id == 1002)
                    .FirstOrDefault();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine(item);
                }
            }
        }   
        
        private void MuitosParaMuitos()
        {
            var p1 = new Produto() { Nome = "Suco de laranja", Categoria = "Bebidas", PrecoUnitario = 8.5, Unidade = "Litros" };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.5, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.5, Unidade = "Gramas" };
            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataFinal = DateTime.Now.AddMonths(3);
            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                contexto.Promocoes.Add(promocaoDePascoa);
                contexto.SaveChanges();
            }
        }
    }
}
