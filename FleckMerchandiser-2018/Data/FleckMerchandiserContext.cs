using FleckMerchandiser2018.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleckMerchandiser2018.Data
{
    public class FleckMerchandiserContext : DbContext
{
        private readonly string connectionStringName;

        public FleckMerchandiserContext(DbContextOptions<FleckMerchandiserContext> options) : base(options)
        {

        }

        public FleckMerchandiserContext(string ConnectionStringName)
        {
            this.connectionStringName = ConnectionStringName;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
        }

        public DbSet<Users> Users { get; set; }
    }
}
