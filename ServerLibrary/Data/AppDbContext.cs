using BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace ServerLibrary.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
}