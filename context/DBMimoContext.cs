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
        public DbSet<Category> Categories { get; set; }
        public DbSet<MYTask> tasks { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                //config par defaut pour les outils EF Core
                optionsBuilder.UseSqlite("data source =quick.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuration de la relation recipe category (many-to-one)
            modelBuilder.Entity<MYTask>()
                 .HasOne(r => r.user)
                 .WithMany(r => r.tasks)
                 .HasForeignKey(r => r.userId)
                 .OnDelete(DeleteBehavior.SetNull);

            // Configuration pour User
            modelBuilder.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany(u => u.notes)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            // Configuration pour Category
            modelBuilder.Entity<Note>()
                .HasOne(n => n.Category)
                .WithMany(c => c.notes)
                .HasForeignKey(n => n.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);


        }
       

        }
}
