﻿
namespace WinformsApp
{
    // Data/AppDbContext.cs
    using Microsoft.EntityFrameworkCore;
    using WinformsApp.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
