using CalculatorApi.Models.Calculations;

namespace CalculatorApi.Services.Orchestrations
{
    public interface ICalculationOrchestrationService
    {
        ValueTask<string> ManageAllFunctions(string userName, Calculation calculation);
    }
}
