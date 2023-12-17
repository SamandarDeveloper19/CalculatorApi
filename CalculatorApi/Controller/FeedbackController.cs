using CalculatorApi.Models.Feedbacks;
using CalculatorApi.Services.Orchestrations;
using CalculatorApi.Services.Processings.Feedbacks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackProcessingService feedbackProcessingService;

        public FeedbackController(IFeedbackProcessingService feedbackProcessingService) =>
            this.feedbackProcessingService = feedbackProcessingService;

        [HttpGet]
        public ActionResult<IQueryable<Feedback>> GetFeedbacks()
        {
            var feedbacks = this.feedbackProcessingService.RetrieveAllFeedbacks();

            return Ok(feedbacks);
        }
    }
}
