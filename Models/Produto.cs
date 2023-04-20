using System.Linq;
using System.Collections.Generic;
using Repository;

namespace Models 
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produto() {}

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;

            Context db = new Context();
            db.Produtos.Add(this);
            db.SaveChanges();
        }

        public static List<Produto> GetProdutos()
        {
            Context db = new Context();
            return db.Produtos.ToList();
        }

        public static Produto GetProdutoById(int id)
        {
            Context db = new Context();
            return db.Produtos.Find(id);
        }

        public static void DeleteProdutoById(int id)
        {
            Context db = new Context();
            Produto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();
        }

        public static void UpdateProdutoById(int id, string nome, double preco)
        {
            Context db = new Context();
            Produto produto = db.Produtos.Find(id);
            produto.Nome = nome;
            produto.Preco = preco;
            db.SaveChanges();
        }
    }


}