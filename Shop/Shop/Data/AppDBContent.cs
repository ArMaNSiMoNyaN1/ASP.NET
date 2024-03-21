using System.Data.Entity;
using shop.Data.Models;

namespace shop.Data;

public class AppDBContent : DbContext {
    public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
    {
    }

    public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }