using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Call> Calls { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
