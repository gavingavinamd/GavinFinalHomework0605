using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MapleStoryFinal0605.Models
{
    public partial class MapleStoryDBContext : DbContext
    {
        public MapleStoryDBContext()
        {
        }

        public MapleStoryDBContext(DbContextOptions<MapleStoryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblMonster> TblMonsters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-HMED35I9;Initial Catalog=MapleStoryDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblMonster>(entity =>
            {
                entity.ToTable("TblMonster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Atk).HasColumnName("ATK");

                entity.Property(e => e.Hp).HasColumnName("HP");

                entity.Property(e => e.Mlevel).HasColumnName("MLevel");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
