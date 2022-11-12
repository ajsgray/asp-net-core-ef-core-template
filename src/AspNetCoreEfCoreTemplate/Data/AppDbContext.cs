using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEfCoreTemplate.Data;

public class ExampleEntity : EntityBase
{

}

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<ExampleEntity> ExampleEntities => Set<ExampleEntity>();
}