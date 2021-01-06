using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpLearn
{
    class SqlDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public IQueryable<Problem> Problems { get; set; }
        public DbSet<Content> contents { get; set; }
        public DbSet<Suggest> suggests { get; set; }
        public DbSet<Article> articles { get; set; }
        public DbSet<Blog> blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=19bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            optionsBuilder.UseSqlServer(connstr);

            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseSqlServer(connstr)
#if Debug
                .EnableSensitiveDataLogging(true)
#endif
                .LogTo
                (
                    (id, level) => level == LogLevel.Error,
                    log => Console.WriteLine(log)
                );



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasCheckConstraint("CK_Createtime", "Createtime >= '2000/1/1'")
                ;
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne<Email>(u => u.Email)
                .WithOne(e => e.Author)
                .HasForeignKey<User>(u => u.Id);

            
        }
    }
}
