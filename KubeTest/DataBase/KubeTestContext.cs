using Microsoft.EntityFrameworkCore;

namespace KubeTest.DataBase;

public class KubeTestContext : DbContext
{
    public KubeTestContext(DbContextOptions<KubeTestContext> options) : base(options) { }
    public DbSet<MyEntity> MyEntities => Set<MyEntity>();
}

public class MyEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}