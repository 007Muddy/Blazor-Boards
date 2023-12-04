using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BoardsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<BoardAPIContext>(options => options
           .UseSqlServer(builder.Configuration.GetConnectionString("BoardAPIContext") ?? throw new InvalidOperationException("Connection string not found.")));

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

            app.UseCors(Options =>
            {
                Options.AllowAnyOrigin();
                Options.AllowAnyMethod();
                Options.AllowAnyHeader();
            }); // Apply your CORS policy here

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}