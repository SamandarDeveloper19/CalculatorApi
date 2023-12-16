using CalculatorApi.Models.Calculations;

namespace CalculatorApi.Services.Foundations.Calculations
{
    public interface ICalculationService
    {
        ValueTask<Calculation> AddCalculationAsync(Calculation calculation);
        IQueryable<Calculation> RetrieveAllCalculations();
        ValueTask<Calculation> RetrieveCalculationByIdAsync(Guid calculationId);
        ValueTask<Calculation> ModifyCalculationAsync(Calculation calculation);
        ValueTask<Calculation> RemoveCalculationAsync(Calculation calculation);
    }
}
