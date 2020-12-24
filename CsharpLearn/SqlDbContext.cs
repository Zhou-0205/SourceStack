using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    class SqlDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=19bang;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            optionsBuilder.UseSqlServer(connstr);

            base.OnConfiguring(optionsBuilder);
#if debug
            optionsBuilder
                .UseSqlServer(connstr)
                .EnableSensitiveDataLogging()
                .LogTo
                (
                    (id, level) => level == LogLevel.Error,
                    log => Console.WriteLine(log)
                );
#endif


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasCheckConstraint("CK_Createtime", "Createtime >= '2000/1/1'")
                ;
            base.OnModelCreating(modelBuilder);
        }
    }
}
