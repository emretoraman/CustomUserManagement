using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CustomUserManagement.Areas.Identity.IdentityHostingStartup))]
namespace CustomUserManagement.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}