using LMS.Domain;

namespace LMS.Common.Logic
{
    public interface IStuffLogic
    {
        Task<List<Country>> GetCountries();

    }
}
