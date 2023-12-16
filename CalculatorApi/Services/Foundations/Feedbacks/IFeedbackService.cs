using CalculatorApi.Models.Feedbacks;

namespace CalculatorApi.Services.Foundations.Feedbacks
{
    public interface IFeedbackService
    {
        ValueTask<Feedback> AddFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> RetrieveAllFeedbacks();
        ValueTask<Feedback> RetrieveFeedbackByIdAsync(Guid feedbackId);
        ValueTask<Feedback> ModifyFeedbackAsync(Feedback feedback);
        ValueTask<Feedback> RemoveFeedbackAsync(Feedback feedback);
    }
}
