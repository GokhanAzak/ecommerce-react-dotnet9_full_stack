using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(

            new List<Product>{
                new Product{Id=1,Name="Iphone 15  ",Description="Telefon Aciklamasi",ImageUrl="1.jpg"
                ,Price=4000,IsActive=true,Stock=100},
                 new Product{Id=2,Name="Iphone 16 ",Description="Telefon Aciklamasi",ImageUrl="2.jpg"
                ,Price=170000,IsActive=true,Stock=100},
                 new Product{Id=3,Name="Iphone pro ",Description="Telefon Aciklamai",ImageUrl="3.jpg"
                ,Price=40000,IsActive=true,Stock=100},
                 new Product{Id=4,Name="Iphone max ",Description="Telefon Aciklamasi",ImageUrl="4.jpg"
                ,Price=20000,IsActive=false,Stock=100},
                 new Product{Id=5,Name="Iphone lite  ",Description="Telefon Aciklamasi",ImageUrl="5.jpg"
                ,Price=30000,IsActive=true,Stock=100},
                


            }
        );
    }
}
