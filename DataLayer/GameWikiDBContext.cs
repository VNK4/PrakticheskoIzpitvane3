using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GameWikiDBContext : DbContext
    {

        public GameWikiDBContext()
        {
            
        }
        public GameWikiDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=IVAN-VIPER\SQLEXPRESS; Database=TESTGAMEWIKI1;Trusted_Connection=True;");
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Ammo> Ammo { get; set; }

        public DbSet<Enemy> Enemies { get; set; }

        public DbSet<Weapon> Weapons { get; set; }
    }
}
