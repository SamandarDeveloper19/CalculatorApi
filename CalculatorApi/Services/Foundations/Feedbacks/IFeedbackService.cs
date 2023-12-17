using CalculatorApi.Models.Feedbacks;

namespace CalculatorApi.Services.Foundations.Feedbacks
{
    public interface IFeedbackService
    {
        ValueTask<Feedback> AddFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> RetrieveAllFeedbacks();
    }
}
