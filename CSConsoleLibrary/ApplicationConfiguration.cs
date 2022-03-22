using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary
{
    public struct ApplicationConfiguration
    {
        public string ApplicationName { get; set; }
        public bool UseAuthorization { get; set; }
    }

    public static class ApplicationConfigurationBuilder
    {
        public static ApplicationConfiguration CreateConfiguration()
        {
            return new ApplicationConfiguration();
        }

        public static ApplicationConfiguration UseAuthorization(this ApplicationConfiguration configuration, bool useAuthorization)
        {
            configuration.UseAuthorization = useAuthorization;
            return configuration;
        }

        public static ApplicationConfiguration SetApplicationName(this ApplicationConfiguration configuration, string name)
        {
            configuration.ApplicationName = name;
            return configuration;
        }
    }
}
