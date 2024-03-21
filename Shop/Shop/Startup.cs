using shop.Data;
using shop.Data.Interfaces;
using shop.Repository;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace shop
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IHostingEnvironment hostEvn)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEvn.ContentRootPath).AddJsonFile("dbsettings.json")
                .Build();

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AppDBContent<AppDBContent>(options =>
                options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
                services.AddTransient<IAllCars, CarRepository>();
                services.AddTransient<ICarsCategory, MockCategory>();
                services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}