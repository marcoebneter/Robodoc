using Microsoft.EntityFrameworkCore;
using robodoc.backend.Common;
using robodoc.backend.Data;
using robodoc.backend.Repositories;
using robodoc.backend.Services;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(config =>
{
    config.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
        );
});

// add Tables
builder.Services.AddTransient<IMedikamentService, MedikamentService>();
builder.Services.AddScoped<IRepository<Medikament>, MedikamentRepository>();

//builder.Services.AddScoped<IRepository<MedikamentTherapie>, MedikamentRepository>();
builder.Services.AddTransient<ITherapieService, TherapieService>();
builder.Services.AddScoped<IRepository<Therapie>, TherapieRepository>();
builder.Services.AddTransient<IPatientService, PatientService>();
builder.Services.AddScoped<IRepository<Patient>, PatientRepository>();
//builder.Services.AddScoped<IRepository<Therapieverfahren>, MedikamentRepository>();
//builder.Services.AddScoped<IRepository<TherapieverfahrenDurchfuehrung>, MedikamentRepository>();


builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Medikament));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.Run();
