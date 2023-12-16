using CalculatorApi.Brokers.Storages;
using CalculatorApi.Services.Foundations.Calculations;
using CalculatorApi.Services.Foundations.Feedbacks;
using CalculatorApi.Services.Foundations.Users;

namespace CalculatorApi
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
            builder.Services.AddDbContext<IStorageBroker, StorageBroker>();
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<ICalculationService, CalculationService>();
            builder.Services.AddTransient<IFeedbackService, FeedbackService>();

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