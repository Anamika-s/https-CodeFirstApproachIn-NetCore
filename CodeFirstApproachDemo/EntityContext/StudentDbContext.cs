using CodeFirstApproachDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproachDemo.EntityContext
{
      class StudentDbContext : DbContext
    {
        public StudentDbContext()
        {

        }
        //public StudentDbContext(DbContextOptions<StudentDbContext> options)
        //   : base(options) { }

       
        public DbSet<Student> Students { get; set; }
        public DbSet<Batch> Batches { get; set; }

        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder  builder)
        {
            builder.UseSqlServer(@"data source=adminvm\SQLEXPRESS;initial catalog=practicedb;user id=sa;password=pass@123");

        }
        // Fluent ApI
        protected  override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Domain>()
               .ToTable("tbl_Domain");
            builder.Entity<Domain>()
                .HasKey(x => x.DomainCode);
            builder.Entity<Domain>()
                .Property(x => x.Name)
                .HasColumnName("DomainName")
                .IsRequired()
                .HasMaxLength(30);
            


        }

    }
}
