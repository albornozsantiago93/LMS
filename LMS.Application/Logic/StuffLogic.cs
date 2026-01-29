using LMS.Common.Logic;
using LMS.Domain;
using LMS.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace LMS.Application.Logic
{
    public class StuffLogic : IStuffLogic
    {
        private SqlContext _context;

        public StuffLogic(SqlContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetCountries()
        {
            return await _context.Country.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
