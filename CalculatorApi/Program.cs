using CalculatorApi.Brokers.Storages;
using CalculatorApi.Services.Foundations.Calculations;
using CalculatorApi.Services.Foundations.Feedbacks;
using CalculatorApi.Services.Foundations.Users;
using CalculatorApi.Services.Orchestrations;
using CalculatorApi.Services.Processings.Calculations;
using CalculatorApi.Services.Processings.Feedbacks;
using CalculatorApi.Services.Processings.Users;

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

            AddFoundations(builder);
            AddProcessings(builder);
            Orchestrations(builder);

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

            static void AddFoundations(WebApplicationBuilder builder)
            {
                builder.Services.AddTransient<IUserService, UserService>();
                builder.Services.AddTransient<ICalculationService, CalculationService>();
                builder.Services.AddTransient<IFeedbackService, FeedbackService>();
            }

            static void AddProcessings(WebApplicationBuilder builder)
            {
                builder.Services.AddTransient<IUserProcessingService, UserProcessingService>();
                builder.Services.AddTransient<ICalculationProcessingService, CalculationProcessingService>();
                builder.Services.AddTransient<IFeedbackProcessingService, FeedbackProcessingService>();
            }

            static void Orchestrations(WebApplicationBuilder builder)
            {
                builder.Services.AddTransient<ICalculationOrchestrationService, CalculationOrchestrationService>();
            }
        }
    }
}