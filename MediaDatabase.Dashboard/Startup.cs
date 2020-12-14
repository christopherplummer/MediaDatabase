using MediaDatabase.Dashboard.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaDatabase.Dashboard.Data.Anime;
using MediaDatabase.Dashboard.Data.Authentication;
using MediaDatabase.Dashboard.Data.Manga;
using MediaDatabase.Dashboard.Services;
using MediaDatabase.Dashboard.Services.Interfaces;
using RestSharp;
using MediaDatabase.Dashboard.Cache.Interfaces;
using MediaDatabase.Dashboard.Cache;

namespace MediaDatabase.Dashboard
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<IRestClient, RestClient>(x =>
                new RestClient("https://kitsu.io/api")); // TODO: Replace with AppSettings variable
            
            //services.AddSingleton<IEntityService<Authentication>, AuthenticationService>();
            //services.AddSingleton<ICache<Anime>, AnimeCache>(); // TODO: Implement the cache

            services.AddSingleton<IEntityService<Anime>, AnimeService>();
            services.AddSingleton<IEntityService<Manga>, MangaService>();

            //services.AddSingleton<ICache<List<Manga>>, MangaCache>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
