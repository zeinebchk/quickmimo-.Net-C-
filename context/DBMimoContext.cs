using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using quickmimo.Entities;

namespace quickmimo.context
{
    internal class DBMimoContext:DbContext
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
        //initialier la base de donnees avec les donnees de test
        //public void Seed()
        //{
        //    if (!categories.Any())
        //    {
        //        categories.AddRange(
        //        new Category
        //        {

        //            Name = "desserts",
        //            Description = "Recette sucree pour terminer un repas"

        //        },
        //         new Category
        //         {
        //             Name = "Plats principeaux",
        //             Description = "Recette pour le plats principale"

        //         }, new Category
        //         {
        //             Name = "Entree chaudes",
        //             Description = "Recettes d'entre services chaudes"

        //         }, new Category
        //         {
        //             Name = "Entree froide",
        //             Description = "Recette d'entree service froide"

        //         }, new Category
        //         {
        //             Name = "Boissons chaudes",
        //             Description = "Recette de boisson service chaude"

        //         }, new Category
        //         {
        //             Name = "Boissons froide",
        //             Description = "Recette de boissons service froide"

        //         }
        //            );
        //    }

        }
}
