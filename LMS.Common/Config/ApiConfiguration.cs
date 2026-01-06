using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace LMS.Common.Config
{
    public static class ApiConfiguration
    {
        private static Microsoft.Extensions.Configuration.IConfiguration currentConfig;

        public static void SetConfig(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            currentConfig = configuration;
        }


        public static string GetConnectionStringConfiguration(string configKey)
        {
            try
            {
                string connectionString = currentConfig.GetConnectionString(configKey);
                return connectionString;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static string GetConfig(string key)
        {
            return currentConfig[key];
        }
    }
}
