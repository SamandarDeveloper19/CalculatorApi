using CalculatorApi.Models.Calculations;
using CalculatorApi.Models.Users;
using CalculatorApi.Services.Foundations.Calculations;

namespace CalculatorApi.Services.Processings.Calculations
{
    public class CalculationProcessingService : ICalculationProcessingService
    {
        private readonly ICalculationService calculationService;

        public CalculationProcessingService() =>
            this.calculationService = calculationService;

        public async ValueTask<string> Calculate(Calculation calculation, User user)
        {
            calculation.Id = Guid.NewGuid();
            calculation.UserId = user.Id;
            calculation.UserName = user.FirstName;

            await this.calculationService.AddCalculationAsync(calculation);

            decimal firstNumber = calculation.FirstNumber;
            decimal secondNumber = calculation.SecondNumber;

            decimal result = calculation.Function switch
            {
                Function.Add => firstNumber + secondNumber,
                Function.Subtract => firstNumber - secondNumber,
                Function.Multiply => firstNumber * secondNumber,
                Function.Divide when secondNumber != 0 => firstNumber / secondNumber,
                _ => throw new InvalidOperationException("Invalid operation!")
            };

            string feedback = $"Name: {user.FirstName}, Your result: {result}";

            return feedback;
        }
    }
}
