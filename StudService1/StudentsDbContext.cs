using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace StudService1
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext() : base("connectToDb")
        {
            
        }

        public DbSet<StudentInfo> StudentInfos { get; set; }    //Tables
        public DbSet<ParentsInfo> ParentsInfos { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentProgress> StudentsProgresses { get; set; }
        public DbSet<Relation> Relations { get; set; }
     
    }
}