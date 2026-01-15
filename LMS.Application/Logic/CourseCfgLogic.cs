using LMS.Common.Logic;
using LMS.Infrastructure;

namespace LMS.Application.Logic
{
    public class CourseCfgLogic : ICourseCfgLogic
    {
        private SqlContext _context;

        public CourseCfgLogic(SqlContext context)
        {
            _context = context;
        }

        public string GetCourseInfo()
        {
            return "Course information retrieved successfully.";
        }


    }
}
