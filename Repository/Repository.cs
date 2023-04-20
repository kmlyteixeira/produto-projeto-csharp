using Microsoft.EntityFrameworkCore;

namespace Repository
{
  public class Context : DbContext
  {
    public DbSet<Models.Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySql("Server=localhost;User Id=root;Database=products");
    }
  }
}