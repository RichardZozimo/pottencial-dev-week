using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;

public class DatabaseContext : DbContext
{
  public DbSet<Pessoa> Pessoas { get; set; }
  public DbSet<Contrato> Contratos { get; set; }
}