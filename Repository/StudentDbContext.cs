using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using efcore.Models;

namespace efcore.Repository {
    public class StudentDbContext : DbContext {
        public StudentDbContext() { }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<StudentModel> Students { get; set; }
    }
}