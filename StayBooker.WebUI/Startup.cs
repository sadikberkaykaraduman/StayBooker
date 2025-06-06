using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StayBooker.DataAccessLayer.Concrete;
using StayBooker.EntityLayer.Conrete;
using StayBooker.WebUI.Dtos.GuestDtos;
using StayBooker.WebUI.Dtos.RoomDtos;
using StayBooker.WebUI.ValidationRules.GuestValidationRules;
using StayBooker.WebUI.ValidationRules.RoomValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StayBooker.WebUI
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
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
            services.AddHttpClient();
            services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
            services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
            services.AddTransient<IValidator<CreateRoomDto>, CreateRoomValidator>();
            services.AddTransient<IValidator<UpdateRoomDto>, UpdateRoomValidator>();
            services.AddControllersWithViews().AddFluentValidation();
            services.AddAutoMapper(typeof(Startup));

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.LoginPath = "/AdminLogin/Index";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Showcase/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Page400", "?code={0}");
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Page403", "?code={0}");
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Page404", "?code={0}");
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Page500", "?code={0}");
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Page503", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Showcase}/{action=Index}/{id?}");
            });
        }
    }
}
