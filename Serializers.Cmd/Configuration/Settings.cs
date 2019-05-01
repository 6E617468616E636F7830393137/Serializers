using System.Configuration;

namespace Serializers.Cmd.Configuration
{
    public class Settings : ISettings
    {
        public string ConfigMessage { get; } = ConfigurationManager.AppSettings["ConfigMessage"];
    }
}
