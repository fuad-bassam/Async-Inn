using Async_Inn_app.data;
using Async_Inn_app.models;
using Async_Inn_app.models.Interfaces;
using Async_Inn_app.models.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn_app
{
    public class Startup
    {
        public IConfiguration Configuration { get; }




        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           

            services.AddDbContext<AsyncInnDbContext>(options => {
                // Our DATABASE_URL from js days
                string connectionString = Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<JwtTokenService>();

            services.AddScoped < IHotelBranches, HotelBranchesService>();

            services.AddScoped<IAmenities, AmenitiesService>();

            services.AddScoped<IRooms, RoomsServices>();

            services.AddIdentity <ApplicationUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;

            })
                            .AddEntityFrameworkStores<AsyncInnDbContext>();

            services.AddTransient<IUserService, IdentityUserService>();
            // Add the wiring for adding "Authentication" for our API
            // "We want the system to always use these "Schemes" to authenticate us
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
              .AddJwtBearer(options =>
              {
          // Tell the authenticaion scheme "how/where" to validate the token + secret
             options.TokenValidationParameters = JwtTokenService.GetValidationParameters(Configuration);
              });


            services.AddControllers().AddNewtonsoftJson(



                 x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore


                 );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
           
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapGet("/hey", async context =>
                {
                     throw new InvalidOperationException("booyah");
                });

            });
        }
    }
}
