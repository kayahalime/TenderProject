﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebAPI
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

            /* services.AddSingleton<ICategoryService, CategoryManager>();
             services.AddSingleton<ICategoryDal, EfCategoryDal>();

             services.AddSingleton<IAdminService, AdminManager>();
             services.AddSingleton<IAdminDal, EfAdminDal>();

             services.AddSingleton<IBidService, BidManager>();
             services.AddSingleton<IBidDal, EfBidDal>();

             services.AddSingleton<IClientService, ClientManager>();
             services.AddSingleton<IClientDal, EfClientDal>();

             services.AddSingleton<IImageService, ImageManager>();
             services.AddSingleton<IImageDal, EfImageDal>();

             services.AddSingleton<ITenderService, TenderManager>();
             services.AddSingleton<ITenderDal, EfTenderDal>();

             services.AddSingleton<IUserService, UserManager>();
             services.AddSingleton<IUserDal, EfUserDal>();*/
             services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
             services.AddCors();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
           

            app.UseAuthorization();


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
