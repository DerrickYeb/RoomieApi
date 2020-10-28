using Microsoft.Extensions.DependencyInjection;
using System;
using Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.Extensions.Configuration;
using Entities.Data;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repository;

namespace RoomieApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPloicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RoomieDbContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("Roomie"), m =>
            m.MigrationsAssembly("RoomieApi")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
