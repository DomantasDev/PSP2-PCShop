using Microsoft.EntityFrameworkCore;
using Models.Contracts;
using Models.Implementation;
using System;

namespace Repositories.Implementation
{
    public class PcContext : DbContext
    {

        public PcContext(DbContextOptions<PcContext> options):base(options)
        {
        }

        public PcContext() : base() { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Pc> Pcs { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Order>().HasKey(x => x.Id);
            mb.Entity<Pc>().HasKey(x => x.Id);
            mb.Entity<Client>().HasKey(x => x.Id);

            mb.Entity<Order>().HasDiscriminator<string>("Type")
                .HasValue<BasicOrder>("BASIC")
                .HasValue<VIPOrder>("VIP");

            mb.Entity<Pc>().HasDiscriminator<string>("Type")
                .HasValue<WindowsPc>("WINDOWS")
                .HasValue<LinuxPc>("LINUX");

            mb.Entity<Client>().HasDiscriminator<string>("Type")
                .HasValue<BasicClient>("BASIC")
                .HasValue<VIPClient>("VIP");

            mb.Entity<Order>()
                .HasOne(om => om.Pc)
                .WithMany(p => p.Orders)
                .HasForeignKey(om => om.PcId);

            mb.Entity<Order>()
                .HasOne(om => om.Client)
                .WithMany(p => p.Orders)
                .HasForeignKey(om => om.ClientId);
        }
    }

    //public class ApplicationContextDbFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    //{
    //    ApplicationDbContext IDesignTimeDbContextFactory<ApplicationDbContext>.CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
    //        optionsBuilder.UseSqlServer<ApplicationDbContext>("Server = (localdb)\\mssqllocaldb; Database = MyDatabaseName; Trusted_Connection = True; MultipleActiveResultSets = true");

    //        return new ApplicationDbContext(optionsBuilder.Options);
    //    }
    //}
}
