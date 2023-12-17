using CalculatorApi.Models.Calculations;
using CalculatorApi.Models.Users;

namespace CalculatorApi.Services.Processings.Calculations
{
    public interface ICalculationProcessingService
    {
        ValueTask<string> Calculate(Calculation calculaiton, User user);
    }

}
