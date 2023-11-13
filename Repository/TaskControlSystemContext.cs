using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafioIngaCode.Models;
using Microsoft.EntityFrameworkCore;

namespace desafioIngaCode.Repository
{
    public class TaskControlSystemContext : DbContext
    {
        public TaskControlSystemContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Collaborators> Collaborators { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<TimeTrackers> TimeTrackers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(u => new{u.Id});
            modelBuilder.Entity<Collaborators>().HasKey(c => new{c.Id});
            modelBuilder.Entity<Projects>().HasKey(p => new{p.Id});
            modelBuilder.Entity<Tasks>().HasKey(t => new{t.Id});
            modelBuilder.Entity<TimeTrackers>().HasKey(tt => new{tt.Id});
        }
    }
}