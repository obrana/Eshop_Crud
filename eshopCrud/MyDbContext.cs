using System;
using eshopCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace eshopCrud
{
	public class MyDbContext:DbContext
	{
    

   
       static readonly string connectionString = "Server=localhost; User ID=root; Password=admin123; Database=customers";

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        
     
    }
}

