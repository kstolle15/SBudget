using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SBudget.Areas.Identity.Data;
using SBudget.Data;

[assembly: HostingStartup(typeof(SBudget.Areas.Identity.IdentityHostingStartup))]
namespace SBudget.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SBudgetContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("SBudgetContextConnection")));

                services.AddDefaultIdentity<SBudgetUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SBudgetContext>();
            });
        }
    }
}