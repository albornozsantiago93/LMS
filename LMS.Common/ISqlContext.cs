using LMS.Domain;
using LMS.Domain.Stuff;
using Microsoft.EntityFrameworkCore;

namespace LMS.Common
{
    public interface ISqlContext
    {
        //public DbSet<BaseEntity> BaseEntity { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<BaseUserEntity> BaseUserEntity { get; set; }



        Task<int> SaveChangesAsync(CancellationToken token = default);

    }
}
