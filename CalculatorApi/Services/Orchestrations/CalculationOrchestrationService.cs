using CalculatorApi.Models.Calculations;
using CalculatorApi.Services.Processings.Calculations;
using CalculatorApi.Services.Processings.Feedbacks;
using CalculatorApi.Services.Processings.Users;

namespace CalculatorApi.Services.Orchestrations
{
    public class CalculationOrchestrationService : ICalculationOrchestrationService
    {
        private readonly IUserProcessingService userProcessingService;
        private readonly ICalculationProcessingService calculationProcessingService;
        private readonly IFeedbackProcessingService feedbackProcessingService;

        public CalculationOrchestrationService(
            IUserProcessingService userProcessingService,
            ICalculationProcessingService calculationProcessingService,
            IFeedbackProcessingService feedbackProcessingService)
        {
            this.userProcessingService = userProcessingService;
            this.calculationProcessingService = calculationProcessingService;
            this.feedbackProcessingService = feedbackProcessingService;
        }
            

        public async ValueTask<string> ManageAllFunctions(string userName, Calculation calculation)
        {
            var user = this.userProcessingService.RetrieveUserByName(userName);

            var feedback = await this.calculationProcessingService.Calculate(calculation, user);

            await this.feedbackProcessingService.AddFeedbackAsync(feedback, user.Id);

            return feedback;
        }

    }
}
