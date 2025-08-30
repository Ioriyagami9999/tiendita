using Microsoft.EntityFrameworkCore;
using TienditaApi.Models;

namespace TienditaApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Producto> Productos { get; set; }
}
