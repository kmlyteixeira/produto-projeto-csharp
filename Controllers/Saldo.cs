using System.Collections.Generic;
using System.Linq;
using System;

namespace Controllers
{
  public class Saldo
  {
    public static List<Models.Saldo> GetSaldos()
    {
      return Models.Saldo.GetSaldos();
    }

    public static Models.Saldo GetSaldoById(int id)
    {
      return Models.Saldo.GetSaldoById(id);
    }

    public static void DeleteSaldoById(int id)
    {
      Models.Saldo.DeleteSaldoById(id);
    }

    public static void UpdateSaldoById(int id, string quantidade, string produtoId, string almoxarifadoId)
    {
      Models.Saldo.UpdateSaldoById(id, Int32.Parse(quantidade), Int32.Parse(produtoId), Int32.Parse(almoxarifadoId));
    }

    public static void CreateSaldo(string quantidade, string produtoId, string almoxarifadoId)
    {
      new Models.Saldo(Int32.Parse(quantidade), Int32.Parse(produtoId), Int32.Parse(almoxarifadoId));
    }

    public static List<Models.Saldo> GetSaldosByAlmoxarifadoId(int id)
    {
      return Models.Saldo.GetSaldos().Where(s => s.Almoxarifado.Id == id).ToList();
    }

    public static List<Models.Saldo> GetSaldosByProdutoId(int id)
    {
      return Models.Saldo.GetSaldos().Where(s => s.Produto.Id == id).ToList();
    }

  }
}