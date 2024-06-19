using Microsoft.EntityFrameworkCore;
using Warehouse.Models;

namespace Warehouse.Database;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Store> Stores { get; set; }
    public DbSet<Stuff> Stuffs { get; set; }
}