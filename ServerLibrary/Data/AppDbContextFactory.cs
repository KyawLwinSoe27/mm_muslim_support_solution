using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ServerLibrary.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mm_muslim_support;Username=root;Password=kyawlwinsoe");

        return new AppDbContext(optionsBuilder.Options);
    }
}