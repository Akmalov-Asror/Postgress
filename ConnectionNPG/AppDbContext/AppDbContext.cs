using Microsoft.EntityFrameworkCore;

namespace ConnectionNPG.AppDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }
}