using AutoMapper.Configuration;
using LMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Common
{
    public class SecurityMapper : BaseMapper
    {
        public SecurityMapper()
        {

        }
        public SecurityMapper(ILogicProxy logic)
        {
            Logic = logic;
        }

        protected MapperConfigurationExpression GetMapperConfigurationExpression(string language)
        {
            MapperConfigurationExpression config = new MapperConfigurationExpression();

            config.CreateMap<UserView, UserModel>()
                .ForMember(x => x.Picture, opt => opt.MapFrom(x => x.Picture))
                .ForMember(x => x.IsFirstLogin, opt => opt.MapFrom(x => x.LastLogin == null))
                .ForMember(x => x.Password, opt => opt.Ignore());
                //.ForMember(x => x.Type, opt => opt.MapFrom(x => Enum.GetName(typeof(LearningUserType), x.Type)));

            return config;
        }

        public UserModel MapToUserModel(UserView userView, List<string> roles, List<PlatformPermission> permissions, string lang)
        {
            UserModel model = MapTo<UserModel>(userView, lang);

            model.Permissions = permissions.Select(x => x.Name.ToString()).ToList();

            foreach (string role in roles)
            {
                model.Profiles.Add(new ProfileModel(role));
            }
            return model;
        }
    }
}
