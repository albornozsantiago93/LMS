using AutoMapper.Configuration;
using LMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Common
{
    public class StuffMapper : BaseMapper
    {
        public StuffMapper()
        {

        }
        public StuffMapper(ILogicProxy logic)
        {
            Logic = logic;
        }

        protected MapperConfigurationExpression GetMapperConfigurationExpression(string language)
        {
            MapperConfigurationExpression config = new MapperConfigurationExpression();

            config.CreateMap<Country, CountryModel>();

            return config;
        }
    }
}
