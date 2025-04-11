using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using quickmimo.Entities;

namespace quickmimo.context
{
    public class DBMimoContext:DbContext
    {
        public DBMimoContext() { }
        public DBMimoContext(DbContextOptions<DBMimoContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<MYTask> tasks { get; set; }
        public DbSet<Note> notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                //config par defaut pour les outils EF Core
                optionsBuilder.UseSqlite("data source =mimo.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuration de la relation recipe category (many-to-one)
            modelBuilder.Entity<MYTask>()
                 .HasOne(r => r.user)
                 .WithMany(r => r.tasks)
                 .HasForeignKey(r => r.userId)
                 .OnDelete(DeleteBehavior.SetNull);

            //config des contraintes de validation
            modelBuilder.Entity<Note>()
                .HasOne(r => r.user)
                .WithMany(r => r.notes)
                .HasForeignKey(r => r.userId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Note>()
              .HasOne(r => r.category)
              .WithMany(r => r.notes)
              .HasForeignKey(r => r.categotyId)
              .OnDelete(DeleteBehavior.SetNull);


        }
       

        }
}
