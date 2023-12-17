using CalculatorApi.Models.Calculations;
using CalculatorApi.Services.Orchestrations;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : Controller
    {
        private readonly ICalculationOrchestrationService calculationOrchestrationService;

        public CalculationController(ICalculationOrchestrationService calculationOrchestrationService) =>
            this.calculationOrchestrationService = calculationOrchestrationService;

        [HttpPost]
        public async ValueTask<ActionResult<string>> GetFeedbackAsync(
            string userName, Calculation calculation)
        {
            var feedback = await this.calculationOrchestrationService
                .ManageAllFunctions(userName, calculation);

            return Ok(feedback);
        }
    }
}
