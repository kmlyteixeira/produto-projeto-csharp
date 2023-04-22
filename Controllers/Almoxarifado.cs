using System.Collections.Generic;

namespace Controllers
{
  public class Almoxarifado
  {
    public static List<Models.Almoxarifado> GetAlmoxarifados()
    {
      return Models.Almoxarifado.GetAlmoxarifados();
    }

    public static Models.Almoxarifado GetAlmoxarifadoById(int id)
    {
      return Models.Almoxarifado.GetAlmoxarifadoById(id);
    }

    public static void DeleteAlmoxarifadoById(int id)
    {
      Models.Almoxarifado.DeleteAlmoxarifadoById(id);
    }

    public static void UpdateAlmoxarifadoById(int id, string nome)
    {
      Models.Almoxarifado.UpdateAlmoxarifadoById(id, nome);
    }

    public static void CreateAlmoxarifado(string nome)
    {
      new Models.Almoxarifado(nome);
    }
  }
}