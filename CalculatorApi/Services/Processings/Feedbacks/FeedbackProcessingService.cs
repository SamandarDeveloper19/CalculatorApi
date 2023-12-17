using CalculatorApi.Models.Feedbacks;
using CalculatorApi.Services.Foundations.Feedbacks;

namespace CalculatorApi.Services.Processings.Feedbacks
{
    public class FeedbackProcessingService : IFeedbackProcessingService
    {
        private readonly IFeedbackService feedbackService;

        public FeedbackProcessingService(IFeedbackService feedbackService) =>
            this.feedbackService = feedbackService;

        public async ValueTask<Feedback> AddFeedbackAsync(string answer, Guid userId)
        {
            var feedback = new Feedback
            {
                Id = Guid.NewGuid(),
                Answer = answer,
                UserId = userId
            };

            return await this.feedbackService.AddFeedbackAsync(feedback);
        }
            
        public IQueryable<Feedback> RetrieveAllFeedbacks() =>
            this.feedbackService.RetrieveAllFeedbacks();

    }
}
