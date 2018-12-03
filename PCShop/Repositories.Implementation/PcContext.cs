using Microsoft.EntityFrameworkCore;
using Models.Contracts;
using Models.Contracts.ClientOrder;
using Models.Contracts.Pcs;
using Models.Implementation;
using Models.Implementation.Basic;
using Models.Implementation.Linux;
using Models.Implementation.VIP;
using Models.Implementation.Windows;
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
}
