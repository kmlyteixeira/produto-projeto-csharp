using System.Collections.Generic;

namespace Controllers {
    public class Produto {
        public static List<Models.Produto> GetProdutos() {
            return Models.Produto.GetProdutos();
        }

        public static Models.Produto GetProdutoById(int id) {
            return Models.Produto.GetProdutoById(id);
        }

        public static void DeleteProdutoById(int id) {
            Models.Produto.DeleteProdutoById(id);
        }

        public static void UpdateProdutoById(int id, string nome, string preco) {
            preco = preco.Replace("$", "");
            preco = preco.Replace(" ", "");
            Models.Produto.UpdateProdutoById(id, nome, double.Parse(preco));
        }

        public static void CreateProduto(string nome, string preco) {
            preco = preco.Replace("$", "");
            preco = preco.Replace(" ", "");
            new Models.Produto(nome, double.Parse(preco));
        }
    }
}