using CalculatorApi.Models.Feedbacks;

namespace CalculatorApi.Services.Processings.Feedbacks
{
    public interface IFeedbackProcessingService
    {
        ValueTask<Feedback> AddFeedbackAsync(string answer, Guid userId);
        IQueryable<Feedback> RetrieveAllFeedbacks();
    }
}
