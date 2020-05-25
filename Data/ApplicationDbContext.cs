using TPAuthorized.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPAuthorized.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Day> Days { get; set; }

        public ApplicationDbContext(
        DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmployeeSubject>()
                .HasKey(t => new { t.EmployeeId, t.SubjectId });

            modelBuilder.Entity<EmployeeSubject>()
                .HasOne(pt => pt.Employee)
                .WithMany(p => p.EmployeeSubjects)
                .HasForeignKey(pt => pt.EmployeeId);

            modelBuilder.Entity<EmployeeSubject>()
                .HasOne(pt => pt.Subject)
                .WithMany(t => t.EmployeeSubjects)
                .HasForeignKey(pt => pt.SubjectId);
        }
    }
}
