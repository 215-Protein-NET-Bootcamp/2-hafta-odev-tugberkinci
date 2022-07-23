using Microsoft.EntityFrameworkCore;
using PatikaHomework2.Dto.Dto;

namespace PatikaHomework2.Data.Context;

    public class PgContext : DbContext
    {
        public PgContext(DbContextOptions<PgContext> options) : base(options)
        {

        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.UseSerialColumns();
    }

        public DbSet<Country> country { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Folder> folder { get; set; }
    
    }
