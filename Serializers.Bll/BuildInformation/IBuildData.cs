using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializers.Bll.BuildInformation
{
    public interface IBuildData
    {        
        Dto.BuildInformation.Version setBuidInformation(string version, string date);
    }
}
