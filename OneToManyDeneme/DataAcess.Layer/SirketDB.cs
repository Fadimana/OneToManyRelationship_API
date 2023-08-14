using DataAcess.Layer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAcess.Layer
{
    public class SirketDB:DbContext
    {
      public  DbSet<Departman> Departmanlar { get; set; }
      public DbSet<Calisan> Calisanlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}