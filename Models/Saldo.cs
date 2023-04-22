using System.Linq;
using System.Collections.Generic;
using Repository;

namespace Models
{
  public class Saldo
  {
    public int Id { get; set; }
    public int Quantidade { get; set; }
    public int ProdutoId { get; set; }
    public int AlmoxarifadoId { get; set; }
    public Produto Produto { get; set; }
    public Almoxarifado Almoxarifado { get; set; }

    public Saldo() {}

    public Saldo(int quantidade, int produtoId, int almoxarifadoId)
    {
      this.Quantidade = quantidade;
      this.ProdutoId = produtoId;
      this.AlmoxarifadoId = almoxarifadoId;

      Context db = new Context();
      db.Saldos.Add(this);
      db.SaveChanges();
    }

    public static List<Saldo> GetSaldos()
    {
      Context db = new Context();
      return db.Saldos.ToList();
    }

    public static Saldo GetSaldoById(int id)
    {
      Context db = new Context();
      return db.Saldos.Find(id);
    }

    public static void DeleteSaldoById(int id)
    {
      Context db = new Context();
      Saldo saldo = db.Saldos.Find(id);
      db.Saldos.Remove(saldo);
      db.SaveChanges();
    }

    public static void UpdateSaldoById(int id, int quantidade, int produtoId, int almoxarifadoId)
    {
      Context db = new Context();
      Saldo saldo = db.Saldos.Find(id);
      saldo.Quantidade = quantidade;
      saldo.ProdutoId = produtoId;
      saldo.AlmoxarifadoId = almoxarifadoId;
      db.SaveChanges();
    }
  }
}