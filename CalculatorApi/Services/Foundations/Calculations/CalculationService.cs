using CalculatorApi.Brokers.Storages;
using CalculatorApi.Models.Calculations;
using Microsoft.EntityFrameworkCore.Query;

namespace CalculatorApi.Services.Foundations.Calculations
{
    public class CalculationService : ICalculationService
    {
        private readonly IStorageBroker storageBroker;

        public CalculationService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Calculation> AddCalculationAsync(Calculation calculation) =>
            await this.storageBroker.InsertCalculationAsync(calculation);

        public IQueryable<Calculation> RetrieveAllCalculations() =>
            this.storageBroker.SelectAllCalculations();

        public async ValueTask<Calculation> RetrieveCalculationByIdAsync(Guid calculationId) =>
            await this.storageBroker.SelectCalculationByIdAsync(calculationId);

        public async ValueTask<Calculation> ModifyCalculationAsync(Calculation calculation) =>
            await this.storageBroker.UpdateCalculationAsync(calculation);

        public async ValueTask<Calculation> RemoveCalculationAsync(Calculation calculation) =>
            await this.storageBroker.DeleteCalculationAsync(calculation);
    }
}
