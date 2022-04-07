using DynamicBox.Shared.Configuration.Identity;
using DynamicBox.STS.Identity.Configuration.Interfaces;

namespace DynamicBox.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}





