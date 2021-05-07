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
                ); ;
            base.OnConfiguring(optionsBuilder);
        }
    }
}
