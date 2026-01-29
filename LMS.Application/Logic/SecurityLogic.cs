using LMS.Common.Logic;
using LMS.Domain;
using LMS.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace LMS.Application.Logic
{
    public class SecurityLogic : ISecurityLogic
    {
        private SqlContext _context;

        public SecurityLogic(SqlContext context)
        {
            _context = context;
        }

        public UserView UserViewsGetByEmail(string email)
        {
            return _context.UserView.Where(x => x.Email == email).FirstOrDefault();
        }

        public async Task<List<PlatformPermission>> GetPermissionsByUserId(Guid userId)
        {
            return await _context.PlatformPermission.FromSqlRaw<PlatformPermission>("exec GetUserPermissions {0}", userId).ToListAsync();
        }

    }
}
