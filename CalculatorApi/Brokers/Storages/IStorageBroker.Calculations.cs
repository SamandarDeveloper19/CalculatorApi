using CalculatorApi.Models.Calculations;

namespace CalculatorApi.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Calculation> InsertCalculationAsync(Calculation calculation);
        IQueryable<Calculation> SelectAllCalculations();
        ValueTask<Calculation> SelectCalculationByIdAsync(Guid calculationId);
        ValueTask<Calculation> UpdateCalculationAsync(Calculation calculation);
        ValueTask<Calculation> DeleteCalculationAsync(Calculation calculation);
    }
}   
