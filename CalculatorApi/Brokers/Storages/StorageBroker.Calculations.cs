using CalculatorApi.Models.Calculations;
using Microsoft.EntityFrameworkCore;

namespace CalculatorApi.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Calculation> Calculations { get; set; }

        public async ValueTask<Calculation> InsertCalculationAsync(Calculation calculation) => 
            await InsertAsync(calculation);

        public IQueryable<Calculation> SelectAllCalculations() =>
            SelectAll<Calculation>();

        public async ValueTask<Calculation> SelectCalculationByIdAsync(Guid calculationId) =>
            await SelectAsync<Calculation>(calculationId);

        public async ValueTask<Calculation> UpdateCalculationAsync(Calculation calculation) =>
            await UpdateAsync(calculation);

        public async ValueTask<Calculation> DeleteCalculationAsync(Calculation calculation) =>
            await DeleteAsync(calculation);
    }
}
