
using LMS.Application;
using LMS.Application.Logic;
using LMS.Common;
using LMS.Common.Logic;
using LMS.Infrastructure;

namespace LMS.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<SqlContext>();
            builder.Services.AddScoped<ISqlContext, SqlContext>();
            builder.Services.AddScoped<IStuffLogic, StuffLogic>();
            builder.Services.AddScoped<ILogicProxy, LogicProxy>();

            // Add services to the container.
            builder.Services.AddControllers();
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();


        }
    }
}
