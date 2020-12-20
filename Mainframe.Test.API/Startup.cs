using Mainframe.Test.Core.Business_Entities;
using Mainframe.Test.Data;
using Mainframe.Test.Data.Data_Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mainframe.Test.API
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
            services.AddControllers();
            services.AddCors();
            services.AddMvc();
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("StudentDatabase")));

            services.AddScoped<IStudentBusinessEntity, StudentBusinessEntity>();
            services.AddScoped<IStudentDataService, StudentDataService>();
            services.AddScoped<ISubjectBusinessEntity, SubjectBusinessEntity>();
            services.AddScoped<ISubjectDataService, SubjectDataService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(p =>
             p
             .AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());
            //.AllowCredentials());

           

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Default", "{controller=StudentController}/{action=Index}/{id?}");
            });
        }
    }
}
