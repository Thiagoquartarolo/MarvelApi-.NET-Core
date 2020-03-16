using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MarvelApi.Domain.Repositories;
using MarvelApi.Domain.Services;
using MarvelApi.Persistence;
using MarvelApi.Persistence.Repositories;
using MarvelApi.Services;
using MarvelApi.Domain.Models;
using MarvelApi.Seed;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MarvelApi
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
            services.AddResponseCompression();

            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("Database"));

            services.AddScoped<ICharactersRepository, CharactersRepository>();
            services.AddScoped<ICharactersService, CharactersService>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Documentação Api Marvel",
                        Version = "v1",
                        Description = "Exemplo de API REST criada com o ASP.NET Core 3.0 para consulta de personagens da Marvel",
                        Contact = new OpenApiContact
                        {
                            Name = "Thiago Quartarolo",
                            Url = new Uri("https://github.com/thiagoquartarolo")
                        }
                    });
            });

            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Documentação Api Marvel - V1");
            });

            app.UseHttpsRedirection();

            app.UseResponseCompression();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();
                ModelBuilderSeed _seed = new ModelBuilderSeed(context);
                _seed.AddSeed();
            }

        }
    }
}
