using Microsoft.EntityFrameworkCore;
using SharedLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrandWebApi.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public DbSet<ServiceWorker> ServiceWorkers { get; set; }
        public DbSet<Errand> Errands { get; set; }
    }
}
