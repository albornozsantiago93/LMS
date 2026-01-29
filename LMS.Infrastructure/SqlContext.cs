using LMS.Common;
using LMS.Domain;
using LMS.Domain.Stuff;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LMS.Infrastructure
{
    public class SqlContext : DbContext , ISqlContext
    {
        private readonly IConfiguration _configuration;
        public SqlContext(DbContextOptions<SqlContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        //public DbSet<BaseEntity> BaseEntity { get; set; }
        //public DbSet<BaseUserEntity> BaseUserEntity { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<PlatformPermission> PlatformPermission { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }
        public DbSet<LearningUser> LearningUser { get; set; }


    }
}
