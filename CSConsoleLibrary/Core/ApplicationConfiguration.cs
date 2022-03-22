using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary.Core
{
    public struct ApplicationConfiguration
    {
        public enum Platform
        {
            None,
            Windows,
            Linux
        }

        public Platform? PlatformType { get; set; }
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

        public static ApplicationConfiguration SetPlatformType(this ApplicationConfiguration configuration, ApplicationConfiguration.Platform platformType)
        {
            configuration.PlatformType = platformType;
            return configuration;
        }
    }
}
