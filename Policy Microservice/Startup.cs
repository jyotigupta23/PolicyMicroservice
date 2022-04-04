using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Policy_Microservice.Model;
using Policy_Microservice.Repository;
using Policy_Microservice.Services;
using QuotesService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace Policy_Microservice
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
            
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title="Policy Microservice",
                    Description="This microservice deals with CRUD functions of policy and issuing policy to the Consumers.",
                    Version="v1",
                    License=new OpenApiLicense 
                    { 
                        Name="MFPE Policy Administration System",
                        Url=new Uri("https://www.google.com")
                    }
                });
            });
            services.AddCors(options => 
            {
                options.AddDefaultPolicy(builder => 
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            // Repository Layer

            /*
             * This uses database from the localhost.
             * Uncomment this when the database is supposed to be used.
             */
            services.AddDbContext<ApplicationDBContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IAvesRepository, AvesRepository>();
            services.AddScoped<IPolicyRepository, PolicyRepository>();
            services.AddScoped<IAutomaticRepository, AutomaticRepository>();
            services.AddScoped<IPolicy_List_By_Consumer_IdRepository, Policy_List_By_Consumer_IdRepository>();
            services.AddScoped<IDeleteAvesByPolicyIdRepository, DeleteAvesByPolicyIdRepository>();

            /*
             * This uses inmemory database.
             * Uncomment this when inmemory database is supposed to be used for Cloud Deploument.
             */
            //services.AddScoped<IAvesRepository, InMemoryAvesRepository>();
            //services.AddScoped<IPolicyRepository, InMemoryPolicyRepository>();
            //services.AddScoped<IAutomaticRepository, InMemoryAutomaticRepository>();
            //services.AddScoped<IPolicy_List_By_Consumer_IdRepository, InMemoryPolicy_List_By_Consumer_IdRepository>();
            //services.AddScoped<IDeleteAvesByPolicyIdRepository, InMemoryDeleteAvesByPolicyIdRepository>();

            // Service Layer
            services.AddScoped<IAvesService, AvesService>();            
            services.AddScoped<IPolicyService, PolicyService>();            
            services.AddScoped<IAutomaticService, AutomaticService>();           
            services.AddScoped<IPolicy_List_By_Consumer_IdService, Policy_List_By_Consumer_IdService>();            
            services.AddScoped<IDeleteAvesByPolicyIdService, DeleteAvesByPolicyIdService>();

            

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Policy Microservice Version Lotus");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseMiddleware<JwtMiddleware>();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
