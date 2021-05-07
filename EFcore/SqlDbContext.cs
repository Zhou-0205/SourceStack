using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore
{
    class SqlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Keyword> Keyword { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connStr)
#if Debug
                .EnableSensitiveDataLogging(true)
#endif
                .LogTo
                (
                    (id, level) => level == LogLevel.Error,
                    log => Console.WriteLine(log)
                );
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Article>().ToTable("Articles");
            //modelBuilder.Entity<Problem>().ToTable("Problems");

            modelBuilder.Entity<User>()
                .HasOne<Email>(u => u.Send)
                .WithOne(e => e.Author)
                .HasForeignKey<User>(u => u.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
