using robodoc.backend.Data;
using Microsoft.EntityFrameworkCore;
using robodoc.backend.Repositories;
using robodoc.backend.Services;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;
using robodoc.backend.Common;

namespace robodoc.backend
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(config =>
            {
                config.UseMySql(
                    Configuration.GetConnectionString("DefaultConnection"),
                    ServerVersion.AutoDetect(Configuration.GetConnectionString("DefaultConnection"))
                    );
            });

            // add Tables
            services.AddTransient<IMedikamentService, MedikamentService>();
            services.AddScoped<IRepository<Medikament>, MedikamentRepository>();

            services.AddTransient<ITherapieService, TherapieService>();
            services.AddScoped<IRepository<Therapie>, TherapieRepository>();

            services.AddAutoMapper(typeof(Medikament));

            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Robodoc", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

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
