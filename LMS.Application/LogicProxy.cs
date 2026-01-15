using LMS.Application.Logic;
using LMS.Common;
using LMS.Common.Logic;
using LMS.Infrastructure;

namespace LMS.Application
{
    public class LogicProxy : ILogicProxy
    {
        private readonly IStuffLogic _stuffLogic;
        private readonly ICourseCfgLogic _courseCfgLogic;

        public LogicProxy(ISqlContext context)
        {
            _stuffLogic = new StuffLogic((SqlContext)context);
            _courseCfgLogic = new CourseCfgLogic((SqlContext)context);
        }

        public IStuffLogic StuffLogic => _stuffLogic;
        public ICourseCfgLogic CourseCfgLogic => _courseCfgLogic;

    }
}
