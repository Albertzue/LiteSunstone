using LiteSunstone.Api.Services;
using LiteSunstone.Domain;
using LiteSunstone.Persistance;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System.Diagnostics.CodeAnalysis;

namespace LiteSunstone.Api
{
    [ExcludeFromCodeCoverage]
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<DataInMemory>();

            //var connectionstr = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var dataBase = client.GetDatabase("litesunstonedb");
            builder.Services.AddSingleton<IMongoDatabase>(dataBase);
            builder.Services.AddTransient<IPatientService, PatientService>();
           
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}