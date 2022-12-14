using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;

public class DatabaseContext : DbContext
{
  public DatabaseContext
  (
    DbContextOptions<DatabaseContext> options
  ) : base(options)
  {

  }

  public DbSet<Pessoa> Pessoas { get; set; }
  public DbSet<Contrato> Contratos { get; set; }

  protected override void OnModelCreating(ModelBuilder builder) {
    builder.Entity<Pessoa>(tabela => {
      tabela.HasKey(e => e.Id); // insere chave na tabela
      tabela
        .HasMany(e => e.Contratos) // indica que ela recebe varios contratos
        .WithOne().HasForeignKey(c => c.PessoaId); // indica que para cada um delas existe uma chave estrangeira
        
    });

    builder.Entity<Contrato>(tabela => {
      tabela.HasKey(e => e.Id);
    });
  }
}