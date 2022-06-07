using Microsoft.EntityFrameworkCore;
using Practice_1.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.DAL
{
    public class ApplicationContext : DbContext
    {
        readonly string _connectionString;
        public DbSet<Basis_of_study> Basis_of_study { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Direction> Direction { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Form_of_study> Form_of_study { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Reasons_for_deduction> Reasons_for_deduction { get; set; }
        public DbSet<Register> Register { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Certificate> Certificate { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            /*Database.EnsureCreated();  *///подключение к БД
        }
        public ApplicationContext():base()
        { }

        public ApplicationContext(string connectionString) : base()
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Student;Trusted_Connection=True;");
            }
        }
    }
}
