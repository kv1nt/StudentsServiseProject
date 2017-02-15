using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using DbEntities;

namespace StudService1
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext() : base("connectToDb")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentInfo>().HasMany(x => x.StudentPhones);
            modelBuilder.Entity<ParentsInfo>().HasMany(x => x.Phones);
            modelBuilder.Entity<StudentInfo>().HasMany(x => x.ParentsInfo);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<StudentInfo> StudentInfos { get; set; }    //Tables
        public DbSet<ParentsInfo> ParentsInfos { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentProgress> StudentsProgresses { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public object StudentInfo { get; set; }
    }
}