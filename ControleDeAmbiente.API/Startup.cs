using ControleDeAmbiente.DAL;
using ControleDeAmbiente.DAL.Interfaces;
using ControleDeAmbiente.DAL.Repositorio;
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
using System.Threading.Tasks;

namespace ControleDeAmbiente.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Contexto>(opcoes => opcoes.UseSqlServer(Configuration.GetConnectionString("ConexaoDB")));

            services.AddScoped<IAmbienteRepositorio,AmbienteRepositorio>();
            services.AddScoped<IWebRepositorio, WebRepositorio>();
            services.AddScoped<IIosRepositorio, IosRepositorio>();
            services.AddScoped<IAndroidRepositorio, AndroidRepositorio>();
            services.AddScoped<INegocioRepositorio , NegocioRepositorio>();
            services.AddScoped<IApiRepositorio, ApiRepositorio>();
            services.AddScoped<IChamadoRepositorio, ChamadoRepositorio>();
            services.AddScoped<IAmbienteChamadoRepositorio, AmbienteChamadoRepositorio>();

            services.AddControllers()
                .AddJsonOptions(opcoes =>
                {
                    opcoes.JsonSerializerOptions.IgnoreNullValues = true;
                }).AddNewtonsoftJson(opcoes =>
                {
                    opcoes.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "Controle de Ambiente Dayconnect", 
                    Version = "v1",
                    Description = "Web API com informações sobre os Ambientes de desenvolvimento Dayconnect"
                });
            });

            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();             
            }
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors(opcoes => opcoes.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

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
