using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DbManger.Web
{
    public static class ConfigHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Get(string key)
        {
            var value = ConfigurationManager.AppSettings.Get(key);
            return value;
        }
    }
}