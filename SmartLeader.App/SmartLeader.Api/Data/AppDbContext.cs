using SmartLeader.Api.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace SmartLeader.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CreditScore> CreditScores { get; set; }
        public DbSet<LoanQualification> LoanQualifications { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
