using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Business.Concrete;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.DataAccess.Concrete;
using InternLeaveandPayment.DataAccess.Connection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InternLeaveandPayment.API
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
            services.AddDbContext<InterneeLeaveandPaymentDBContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("InternDBConnection")));
            services.AddScoped<IInternDAL,InternDAL>();
            services.AddScoped<IInternService,InternManager>();
            services.AddScoped<IInternLeaveDAL,InternLeaveDAL>();
            services.AddScoped<IInternLeaveService,InternLeaveManager>();
            services.AddScoped<IInternLeaveDetailDAL,InternLeaveDetailDAL>();
            services.AddScoped<IInternLeaveDetailService,InternLeaveDetailManager>();
            services.AddScoped<IEmployeeService,EmployeeManager>();
            services.AddScoped<IEmployeeDAL,EmployeeDAL>();
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InternLeaveandPayment.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "InternLeaveandPayment.API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
