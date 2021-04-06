using System.Collections.Generic;
using System.Linq;

namespace Umi.API.Services
{
    public class PropertyMappingValue
    {
        
        public IEnumerable<string> DestinationProperties { get; private set; }

        public PropertyMappingValue(IEnumerable<string> destinationsProperties)
        {
            DestinationProperties = destinationsProperties;
        }
    }
}