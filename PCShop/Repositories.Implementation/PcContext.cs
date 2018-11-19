using Microsoft.EntityFrameworkCore;
using Models.Implementation;
using System;

namespace Repositories.Implementation
{
    public class PcContext : DbContext
    {
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<PcModel> Pcs { get; set; }
        public DbSet<ClientModel> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<OrderModel>().HasKey(x => x.Id);
            mb.Entity<PcModel>().HasKey(x => x.Id);
            mb.Entity<ClientModel>().HasKey(x => x.Id);

            mb.Entity<OrderModel>()
                .HasOne(om => om.Pc)
                .WithMany(p => p.Orders)
                .HasForeignKey(om => om.PcId);

            mb.Entity<OrderModel>()
                .HasOne(om => om.Client)
                .WithMany(p => p.Orders)
                .HasForeignKey(om => om.ClientId);
        }
    }
}
