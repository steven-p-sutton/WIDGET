using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore; // In Memory Datastore
using Conductus.Widget.Context;

namespace Conductus.Widget.API
{
    // InMemory Databaase
    // https://exceptionnotfound.net/ef-core-inmemory-asp-net-core-store-database/
    // Install-Package Microsoft.EntityFrameworkCore.InMemory

    // Logging
    // https://www.tutorialsteacher.com/core/aspnet-core-logging
    // Install-Package Serilog.Extensions.Logging.File
    //
    // example:
    //
    //2020-09-07T21:37:45.0524332+01:00  [INF]
    //Application started.Press Ctrl+C to shut down. (dcaefe54)
    //2020-09-07T21:37:45.0866780+01:00  [INF] Hosting environment: "Development" (c3307c92)
    //2020-09-07T21:37:45.0912908+01:00  [INF] Content root path: "C:\Users\steve\Documents\Visual Studio Work\Widget-API" (b5d60022)
    //2020-09-07T21:37:45.5596152+01:00 80000002-0000-fd00-b63f-84710c7967bb[INF] GET: widget (1b26113d)
    //2020-09-07T21:37:58.8012111+01:00 80000010-0001-fd00-b63f-84710c7967bb[INF] POST: widget/5 (69647a09)
    //2020-09-07T21:38:09.7802512+01:00 80000011-0001-fd00-b63f-84710c7967bb[INF] POST: widget/5 (69647a09)
    //2020-09-07T21:38:17.0738669+01:00 80000011-0001-fd00-b63f-84710c7967bb[ERR] Widget 5 Already exists(5c75da79)

    public class StartupSQLServerDB
    {
        public StartupSQLServerDB(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WidgetContextMemory>(options =>

                // SQL Server HERE ------>
                options.UseInMemoryDatabase(databaseName: "WidgetsDB"));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        // Logging added
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                // libWidgetController Project defines a controlller as below and will therefore
                // be picked up here and accessed https://localhost:44334/widget/
                // [ApiController]
                // [Route("widget")]
                // public class WidgetController : ControllerBase { ... }
                endpoints.MapControllers();
            });
            // Logging added 
            loggerFactory.AddFile("Logs/mylog-{Date}.txt");
        }
    }
}
