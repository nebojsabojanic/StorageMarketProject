using StorageMarketProjectAPI.Models.DbContexts;
using Microsoft.EntityFrameworkCore;
using StorageMarketProjectAPI.Sevices;
using Microsoft.Extensions.Options;

namespace StorageMarketProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                //options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreAPIMentorship;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Multi Subnet Failover=False");

                //options.UseSqlServer("Data Source = localhost\\SQLEXPRESS; Initial Catalog = StorageDB; User ID = sa; Password = 1234");
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StorageDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            });

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IStorageService, StorageService>();
            builder.Services.AddScoped<IStateOfStorageService, StateOfStorageService>();

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