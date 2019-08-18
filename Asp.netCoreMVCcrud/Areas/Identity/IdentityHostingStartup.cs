using System;
using Asp.netCoreMVCcrud.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Asp.netCoreMVCcrud.Areas.Identity.IdentityHostingStartup))]
namespace Asp.netCoreMVCcrud.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DevConnection>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DevConnection")));

                services.AddDefaultIdentity<DevConnectionUser>()
                    .AddEntityFrameworkStores<DevConnection>();
            });
        }
    }
}