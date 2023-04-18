using System.Collections.Generic;

namespace Controllers {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public List<Produto> produtos = new List<Produto>();

        public Produto(string nome, string preco) {
            this.Id = produtos.Count + 1;
            this.Nome = nome;
            this.Preco = double.Parse(preco);

            produtos.Add(this);
        }

        public void Editar(string nome, string preco) {
            this.Nome = nome;
            this.Preco = double.Parse(preco);
        }

        public void Excluir(int id) {
            produtos.Remove(produtos.Find(p => p.Id == id));
        }
    }
}