
using LMS.Common.Logic;

namespace LMS.Common
{
    public interface ILogicProxy
    {
        public IStuffLogic  StuffLogic { get; }
        public ICourseCfgLogic CourseCfgLogic { get; }
        public ISecurityLogic SecurityLogic { get; }    
    }
}
