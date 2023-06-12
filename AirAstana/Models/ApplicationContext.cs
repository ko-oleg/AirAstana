using Microsoft.EntityFrameworkCore;

namespace AirAstana.Models;

public class ApplicationContext : DbContext
{
    public DbSet<Flight> Flights { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }
}