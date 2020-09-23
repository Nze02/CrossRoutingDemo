using CrossRouting.Models;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EcoCompany> EcoCompany { get; set; }
        public DbSet<CoinageCompany> CoinageCompany { get; set; }
    }
}
