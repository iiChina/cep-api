using BuscaCEP.Models;
using Microsoft.EntityFrameworkCore;

namespace BuscaCEP.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
}
