using Serializers.Dto.BuildInformation;

namespace Serializers.Bll.BuildInformation
{
    public class BuildData : IBuildData
    {        
        public Version setBuidInformation(string version, string date)
        {
            return new Version
            {
                BuildVersion = version,
                BuildDate = date
            };
        }        
    }
}
