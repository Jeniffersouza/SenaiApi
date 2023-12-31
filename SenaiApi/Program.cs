using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SenaiApi.Repository.Context;
using SenaiApi.Repository.Interface;
using SenaiApi.Repository.Repository;
using SenaiApi.Service.Interface;
using SenaiApi.Service.Service;

namespace SenaiApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            

            builder.Services.AddDbContext<ApiContext>(options =>
            options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:ApiSenai")));

            #region Inje��o de Depend�ncia

            builder.Services.AddScoped<IPessoaService, PessoaService>();
            builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();
            builder.Services.AddScoped(typeof(IGenericrepository<>),typeof(GenericRepository<>));
            #endregion

            #region AutoMapper
            MapperConfiguration mapperConfiguration = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddMaps(new[] { "SenaiApi.Service" });
            });
            builder.Services.AddSingleton(mapperConfiguration.CreateMapper());
            #endregion

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}