using BookServiceWEBAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookServiceWEBAPI.Database
{
    public class MyContext : DbContext //inheriting dbcontext
    {

        public DbSet<Book>? Books { get; set; }


        //configure connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= MSI/DATMODEL; Initial Catalog=BookServiceDB;User Id=Ramjee;Password=1234;TrustServerCertificate=true");
        }
    }
}
