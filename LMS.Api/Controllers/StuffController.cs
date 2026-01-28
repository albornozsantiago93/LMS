using LMS.Common;
using LMS.Common.DTOs;
using LMS.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StuffController : BaseController
    {

        private static readonly HttpClient Client = new HttpClient();
        private StuffMapper _mapper;

        public StuffController(ISqlContext context, ILogicProxy logicProxy, IHttpContextAccessor httpContextAccessor)
            : base(context, new StuffMapper(logicProxy), httpContextAccessor, logicProxy)
        {
            _mapper = new StuffMapper(logicProxy);
        }


        [HttpGet("countries")]
        public ActionResult<List<CountryModel>> GetCountries()
        {
            List<Country> entity = Logic.StuffLogic.GetCountries();
            var ret = _mapper.Mapper(CurrentLanguage).Map<List<CountryModel>>(entity);

            return Ok(ret);
        }
    }
}
