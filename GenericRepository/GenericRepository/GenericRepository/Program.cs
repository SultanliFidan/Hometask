
using GenericRepository.Contexts;
using GenericRepository.Entites;
using GenericRepository.Repositories.Abstractions;
using GenericRepository.Services.Abstractions;
using GenericRepository.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace GenericRepository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers().AddJsonOptions(x =>
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            builder.Services.AddControllers();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<ITRepository<Student>, TRepository<Student>>();
            builder.Services.AddScoped<IGroupService, GroupService>();
            builder.Services.AddScoped<ITRepository<Group>, TRepository<Group>>();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"));
            });
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
