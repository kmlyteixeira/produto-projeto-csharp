using System.Linq;
using System.Collections.Generic;
using Repository;

namespace Models
{
    public class Almoxarifado
    {
      public int Id { get; set; }
      public string Nome { get; set; }

      public Almoxarifado() {}

      public Almoxarifado(string nome)
      {
        this.Nome = nome;

        Context db = new Context();
        db.Almoxarifados.Add(this);
        db.SaveChanges();
      }

      public static List<Almoxarifado> GetAlmoxarifados()
      {
        Context db = new Context();
        return db.Almoxarifados.ToList();
      }

      public static Almoxarifado GetAlmoxarifadoById(int id)
      {
        Context db = new Context();
        return db.Almoxarifados.Find(id);
      }

      public static void DeleteAlmoxarifadoById(int id)
      {
        Context db = new Context();
        Almoxarifado almoxarifado = db.Almoxarifados.Find(id);
        db.Almoxarifados.Remove(almoxarifado);
        db.SaveChanges();
      }

      public static void UpdateAlmoxarifadoById(int id, string nome)
      {
        Context db = new Context();
        Almoxarifado almoxarifado = db.Almoxarifados.Find(id);
        almoxarifado.Nome = nome;
        db.SaveChanges();
      }

    }
}