using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MessageBoard.Models;

namespace MessageBoard.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
                services.AddEntityFrameworkMySql();
                // .AddDbContext<MessageBoardContext>(options => options
                // .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

      //new code
    //             services.AddIdentity<ApplicationUser, IdentityRole>()
    //             .AddEntityFrameworkStores<MessageBoardContext>()
    //             .AddDefaultTokenProviders();
    //             services.Configure<IdentityOptions>(options =>
    //   {
    //       options.Password.RequireDigit = false;
    //       options.Password.RequiredLength = 0;
    //       options.Password.RequireLowercase = false;
    //       options.Password.RequireNonAlphanumeric = false;
    //       options.Password.RequireUppercase = false;
    //       options.Password.RequiredUniqueChars = 0;
    //   });
        }
        
        // private void ConfigureOAuthTokenConsumption(IApplicationBuilder app)
        // {
        //     var issuer = ConfigurationManager.AppSettings["Issuer"];
        //     var audienceId = ConfigurationManager.AppSettings["AudienceId"];
        //     var audienceSecret = TextEncodings.Base64Url.Decode(ConfigurationManager.AppSettings["AudienceSecret"]);

        //     // Api controllers with an [Authorize] attribute will be validated with JWT
        //     app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
        //     {
        //         AuthenticationMode = AuthenticationMode.Active,
        //         AllowedAudiences = new[] { audienceId },
        //         IssuerSecurityTokenProviders = new IIssuerSecurityTokenProvider[]
        //         {
        //             new SymmetricKeyIssuerSecurityTokenProvider(issuer, audienceSecret) 
        //         }
        //     });
        // }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
